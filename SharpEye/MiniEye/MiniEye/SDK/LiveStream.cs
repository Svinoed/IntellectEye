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


namespace MiniEye.SDK
{
    delegate void ImageReseived(Bitmap picture);


    interface ILiveStream
    {
        void Resize(int width, int height);
        bool ChangeCamera(string cameraName, int width, int height);
        //Подключитесь к данному событию чтобы получать изображения с камеры
        event ImageReseived ImageIsReady;
    }

    class LiveStream : ILiveStream
    {
        #region Properties
        private JPEGLiveSource _JpegLiveSource;
        private Item _Camera;
        private int _Width = 320;
        private int _Height = 240;

        //Событие о готовности картинки с камеры или картинки с ошибкой
        public event ImageReseived ImageIsReady;
        #endregion


        public LiveStream() { }
        /// <summary>
        /// Устанавливает камеру
        /// </summary>
        /// <param name="camera">Камера для подключения</param>
        /// <param name="width">Длина по горизонтали для изображения</param>
        /// <param name="height">Длина по вертикали для изображения</param>
        public bool ChangeCamera(string camera, int width, int height)
        {
            //VideoOS.Platform.SDK.Environment.Initialize();              // Initialize the standalone Environment
            VideoOS.Platform.SDK.Media.Environment.Initialize();		// Initialize the standalone Environment
            Cameras list = new Cameras();
            this._Width = width;
            this._Height = height;
            try
            {
                //Найти нужную камеру в списке
                foreach (var item in list.GetItems())
                    if (camera.Equals(item.Name.ToString()))
                        _Camera = item;
                _JpegLiveSource = new JPEGLiveSource(_Camera); //Исключение если камера не найдена
                //SetResolution();
                _JpegLiveSource.LiveModeStart = true;
                _JpegLiveSource.SetKeepAspectRatio(true, true);
                _JpegLiveSource.Width = width;
                _JpegLiveSource.Height = height;
                _JpegLiveSource.KeyFramesOnly = false;
                _JpegLiveSource.Init();
                _JpegLiveSource.LiveContentEvent += _JpegLiveSource_LiveContentEvent;
                _JpegLiveSource.LiveStatusEvent += _JpegLiveSource_LiveStatusEvent;
                return true;
            }
            catch (Exception)
            {
                _JpegLiveSource = null;
                _Camera = null;
                return false;
            }
        }

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
                    ImageIsReady(newBitmap);

                    /*Изменение размеров
                     * if (pictureBox1.Size.Width != 0 && pictureBox1.Size.Height != 0)
                    {
                        if (!checkBoxAspect.Checked && (newBitmap.Width != pictureBox1.Width || newBitmap.Height != pictureBox1.Height))
                        {
                            pictureBox1.Image = new Bitmap(newBitmap, pictureBox1.Size);
                        }
                        else
                        {
                            pictureBox1.Image = newBitmap;
                        }
                    }*/

                    ms.Close();
                    ms.Dispose();
                    args.LiveContent.Dispose();
                }
                else if (args.Exception != null)
                {
                    // Handle any exceptions occurred inside toolkit or on the communication to the VMS

                    Bitmap bitmap = new Bitmap(320, 240);
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
    }
}
