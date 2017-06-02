using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoOS.Platform.Live;
using VideoOS.Platform;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Contract;


namespace MiniEye.SDK
{
    delegate void ImageReseived(Bitmap picture);


    interface ILiveStream
    {
        void Resize(int newWidth, int newHeight);
        bool Initialize(ICameraModel camera, int imageWidth, int imageHeight);
        //Подключитесь к данному событию чтобы получать изображения с камеры
        event ImageReseived ImageIsReady;
    }

    class LiveStream : ILiveStream
    {
        #region Properties
        private JPEGLiveSource _JpegLiveSource;
        private int _Width = 320;
        private int _Height = 240;

        //Событие о готовности картинки с камеры или картинки с ошибкой
        public event ImageReseived ImageIsReady;
        #endregion


        public LiveStream() { }

        private void _JpegLiveSource_LiveStatusEvent(object sender, EventArgs e)
        {
            //TODO: Добавить обработку изменения статуса
        }

        private void _JpegLiveSource_LiveContentEvent(object sender, EventArgs e)
        {
            LiveContentEventArgs args = e as LiveContentEventArgs;
            if (args != null)
            {
                if (args.LiveContent != null)
                {
                    int width = args.LiveContent.Width;
                    int height = args.LiveContent.Height;

                    MemoryStream ms = new MemoryStream(args.LiveContent.Content);
                    Bitmap newBitmap = new Bitmap(ms);
                    if(ImageIsReady != null)
                        ImageIsReady(newBitmap);
                    else
                        _JpegLiveSource.LiveContentEvent -= _JpegLiveSource_LiveContentEvent;

                    ms.Close();
                    ms.Dispose();
                    args.LiveContent.Dispose();
                }
                else if (args.Exception != null)
                {
                    // Обработать любые исключения

                    Bitmap bitmap = new Bitmap(_Width, _Height);
                    Graphics g = Graphics.FromImage(bitmap);
                    g.FillRectangle(Brushes.Black, 0, 0, bitmap.Width, bitmap.Height);
                    g.DrawString("Нет соединения ...", new Font(FontFamily.GenericMonospace, 12), Brushes.White, new PointF(20, _Height / 2 - 20));
                    g.Dispose();
                    //Готовое сообщение с ошибкой
                    ImageIsReady(new Bitmap(bitmap, new Size(_Width, _Height)));
                    bitmap.Dispose();
                }
            }
        }

        /// <summary>
        /// Изменить размеры картинки
        /// </summary>
        public void Resize(int width, int height)
        {
            this._Width = width;
            this._Height = height;
            if (_JpegLiveSource != null)
            {
                _JpegLiveSource.Width = width;
                _JpegLiveSource.Height = height;
                _JpegLiveSource.SetWidthHeight();
            }
        }

        public bool Initialize(ICameraModel camera, int imageWidth, int imageHeight)
        {
            this._Width = imageWidth;
            this._Height = imageHeight;
            Item cameraItem = null;
            try
            {   
                //Инициализировать камеру
                cameraItem = Configuration.Instance.GetItem(camera.Id);
                _JpegLiveSource = new JPEGLiveSource(cameraItem); //Исключение если камера не найдена
                //SetResolution();
                _JpegLiveSource.LiveModeStart = true;
                _JpegLiveSource.SetKeepAspectRatio(true, false);
                _JpegLiveSource.Width = imageWidth;
                _JpegLiveSource.Height = imageHeight;
                _JpegLiveSource.KeyFramesOnly = false;
                _JpegLiveSource.Init();
                _JpegLiveSource.LiveContentEvent += _JpegLiveSource_LiveContentEvent;
                //_JpegLiveSource.LiveStatusEvent += _JpegLiveSource_LiveStatusEvent;
                return true;
            }
            catch (Exception)
            {
                _JpegLiveSource = null;
                cameraItem = null;
                return false;
            }
        }
    }
}
