using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using VideoOS.Platform.Client;
using VideoOS.Platform;
using VideoOS.Platform.SDK.Export;
using VideoOS.Platform.SDK.Media;
using VideoOS.Platform.Messaging;
using System.Diagnostics;
using System.Drawing;
using VideoOS.Platform.UI;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.Threading;
using VideoOS.Platform.Data;
using System.IO;

namespace Model
{
    [Export(typeof(IPlaybackModel))]
    public class PlaybackModel : IPlaybackModel
    {
        #region private fields

        public double PlaybackSpeed { get {return _playbackSpeed; } set { this._playbackSpeed = value; } }

        public ProgressBar TimeLine { get { return _currentProgressBar; } set { _currentProgressBar = value; } }
        public bool SkipGaps { get { return _playbackController.SkipGaps; } set{ _playbackController.SkipGaps = value; } }

        private Bitmap _currentOriginalBitmap = null;

        private Panel _currentVideoPanel;
        private PictureBox _videoPictureBox;
        private ProgressBar _currentProgressBar;

        private FQID _playbackFQID;
        private Item _newlySelectedItem;

        private PlaybackController _playbackController;
        private PlaybackUserControl _playbackUserControl;

        private DateTime _currentSequnceStartTime;

        //private PlaybackTimeInformationData _currentTimeInformation;
        private BitmapSource _bitmapSource;
        private PlaybackController.PlaybackModeType previousType = PlaybackController.PlaybackModeType.Stop;

        private double _playbackSpeed = 0.0F;
        private double standartAmountOfSpeed = 0.5F;

        public event Action SpeedChanged;

        #endregion
        public void SetVideoStreamInPanel(ICameraModel camera, Panel videoPanel)
        {
            PrepareControls(videoPanel);
            try
            {
                CloseCurrent();
                _newlySelectedItem = Configuration.Instance.GetItem(camera.Id);
                _bitmapSource.Item = _newlySelectedItem;
                InitBitmap();
                SetCurrentTime();
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Camera select", ex);
            }
        }

        public void SetVideoStreamInPanelAtTime(ICameraModel camera, Panel videoPanel, DateTime initialTime)
        {
            PrepareControls(videoPanel);
            try
            {
                CloseCurrent();
                _newlySelectedItem = Configuration.Instance.GetItem(camera.Id);
                _bitmapSource.Item = _newlySelectedItem;
                InitBitmap();
                SetLoopedTime(initialTime);
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Camera select", ex);
            }
        }

        private void SetLoopedTime(DateTime initialTime)
        {
            SetVideoFragmentForPlayback(initialTime);
            _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Stop;
            _playbackController.PlaybackSpeed = 0.0F;
            TimeSpan check = _playbackController.PlaybackTime - initialTime;
            _playbackController.PlaybackTime = _playbackController.PlaybackTime.AddHours(-6.5);//Задержка из-за часового пояса, пока хз, как фиксить
            _playbackController.PlaybackTime = _playbackController.PlaybackTime.Add(-check);
            Thread.Sleep(300);
            _playbackController.PlaybackSpeed = 1.0F;
            _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Forward;
        }
        private void SetCurrentTime()
        {
            _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Stop;
            _playbackController.PlaybackSpeed = 0.0F;
            TimeSpan check = _playbackController.PlaybackTime - DateTime.Now.ToUniversalTime();//На всякий случай ищем разницу во времени плеера и системы
            _playbackController.PlaybackTime = _playbackController.PlaybackTime.Add(-check);//Синхронизируем
            _playbackController.PlaybackTime = _playbackController.PlaybackTime.AddHours(-7).ToUniversalTime();//Задержка из-за часового пояса, пока хз, как фиксить
            _playbackController.PlaybackSpeed = 1.0F;
            _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Forward;
        }

        public void SetVideoStreamInPanel(ICameraModel camera, Panel panel, EventHandler doubleClickHandler)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void PTZDefault()
        {
            throw new NotImplementedException();
        }

        public void SetVideoStreamInPanelFromFileAtTime(string filename, Panel videoPanel, DateTime initialTime)
        {
            PrepareControls(videoPanel);
            try
            {
                if(filename.ToUpper().EndsWith("INI"))
                {
                    if (filename.ToUpper().EndsWith("SURVPRO2.INI"))
                    {
                        Uri uri = new Uri("file:\\" + filename);
                        VideoOS.Platform.SDK.Environment.AddServer(uri, System.Net.CredentialCache.DefaultNetworkCredentials);

                        VideoOS.Platform.SDK.Environment.LoadConfiguration(uri);
                        _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Stop;
                        ChooseCameraSource();
                        SetLoopedTime(initialTime);
                    }
                    else
                    {
                        MessageBox.Show("Only SURVPRO2.INI Files can be selected");
                    }
                }
                else
                {
                    Uri uri = new Uri("file:\\" + filename);
                    VideoOS.Platform.SDK.Environment.AddServer(uri, System.Net.CredentialCache.DefaultNetworkCredentials);

                    VideoOS.Platform.SDK.Environment.LoadConfiguration(uri);

                    ChooseCameraSource();
                }
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("File select", ex);
            }
        }

        public void SetVideoStreamInPanelFromFolderAtTime(string pathToFolder, Panel videoPanel, DateTime initialTime)
        {
            PrepareControls(videoPanel);
            try
            {
                if (File.Exists(Path.Combine(pathToFolder, "cache.xml")) ||
                    File.Exists(Path.Combine(pathToFolder, "archives_cache.xml")))
                {
                    Uri uri = new Uri("file:\\" + pathToFolder);
                    VideoOS.Platform.SDK.Environment.AddServer(uri, System.Net.CredentialCache.DefaultNetworkCredentials);

                    VideoOS.Platform.SDK.Environment.LoadConfiguration(uri);

                    ChooseCameraSource();
                    SetLoopedTime(initialTime);
                }
                else
                {
                    MessageBox.Show("No cache.xml or archives_cache.xml file were found in selected folder.");
                }
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Folder select", ex);
            }
        }

        public void SetVideoFragmentForPlayback(DateTime startTime)
        {
            _currentSequnceStartTime = startTime.AddHours(-6.5);//Везде проставил магические числа, разница с UTC получается как раз 6,5 часов, пока не придумал как пофиксить
            _playbackController.SetSequence(_currentSequnceStartTime.AddMinutes(-30), _currentSequnceStartTime.AddMinutes(30));
            _currentProgressBar.Minimum = Convert.ToInt32(0);
            _currentProgressBar.Maximum = Convert.ToInt32(_currentSequnceStartTime.AddMinutes(30).Subtract(_currentSequnceStartTime.AddMinutes(-30)).TotalSeconds);
            _currentProgressBar.Value = Convert.ToInt32(_currentSequnceStartTime.Subtract(_currentSequnceStartTime.AddMinutes(-30)).TotalSeconds);
            _playbackController.SequenceProgressChanged += (g, s) => moveProgressBar();
        }

        private void moveProgressBar()
        {
            _currentProgressBar.Value = Convert.ToInt32(_playbackController.PlaybackTime.Subtract(_currentSequnceStartTime.AddMinutes(-30)).TotalSeconds);
        }

        private void _bitmapSource_NewBitmapEvent(Bitmap bitmap)
        {
            Control hostElement = _currentVideoPanel.Parent;
            if (hostElement.InvokeRequired)
            {
                if (_currentOriginalBitmap != null)
                    _currentOriginalBitmap.Dispose();
                _currentOriginalBitmap = new Bitmap(bitmap);
                bitmap.Dispose();

                hostElement.BeginInvoke(new MethodInvoker(() => _bitmapSource_NewBitmapEvent(_currentOriginalBitmap)));
            }
            else
            {
                lock (hostElement)
                {
                    _videoPictureBox.Image = new Bitmap(bitmap, _videoPictureBox.Width, _videoPictureBox.Height);
                    //hostElement.Refresh();
                    _videoPictureBox.Refresh();
                }
            }
        }


        private void InitBitmap()
        {
            if (_bitmapSource != null)
            {
                _bitmapSource.Init();
            }
        }

        private void CloseCurrent()
        {
            CloseBitmap();
        }

        private void CloseBitmap()
        {
            if (_bitmapSource != null)
            {
                _bitmapSource.Close();
            }
        }


        private void ChooseCameraSource()
        {
            try
            {
                CloseCurrent();
                ItemPickerForm form = new ItemPickerForm();
                form.KindFilter = Kind.Camera;
                form.AutoAccept = true;
                form.Init(Configuration.Instance.GetItems(ItemHierarchy.Both));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _newlySelectedItem = form.SelectedItem;
                    _bitmapSource.Item = _newlySelectedItem;
                    InitBitmap();
                    
                }
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Camera select", ex);
            }
        }

        



        public void Play()
        {
            if(_playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Stop)
            {
                if(previousType == PlaybackController.PlaybackModeType.Stop)
                {
                    _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Forward;
                    _playbackController.PlaybackSpeed = 1.0F;
                }
                else
                {
                    _playbackController.PlaybackMode = previousType;
                }
                _playbackSpeed = _playbackController.PlaybackSpeed;
                SpeedChanged();
            }
            else if(
                _playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Forward ||
                _playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Reverse ||
                _playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Custom)
            {
                previousType = _playbackController.PlaybackMode;
                _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Stop;
                _playbackSpeed = _playbackController.PlaybackSpeed;
                SpeedChanged();
            }


        }

        public void SlowDown()
        {
            if ((_playbackController.PlaybackSpeed - standartAmountOfSpeed) > 0)
                _playbackController.PlaybackSpeed -= standartAmountOfSpeed;
            else if ((_playbackController.PlaybackSpeed - standartAmountOfSpeed) <= 0)
                _playbackController.PlaybackSpeed = 0;
            else
                throw new Exception("Произошло что-то до абсурда странное");
            _playbackSpeed = _playbackController.PlaybackSpeed;
            SpeedChanged();
        }

        public void SpeedUp()
        {
            _playbackController.PlaybackSpeed += standartAmountOfSpeed;
            _playbackSpeed = _playbackController.PlaybackSpeed;
            SpeedChanged();
        }

        public void ChangeDirection()
        {
            if (_playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Forward)
                _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Reverse;
            else if (_playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Reverse)
                _playbackController.PlaybackMode = PlaybackController.PlaybackModeType.Forward;
            else if (_playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Stop)
            { }
            else if (_playbackController.PlaybackMode == PlaybackController.PlaybackModeType.Custom)
                _playbackController.PlaybackSpeed = -_playbackController.PlaybackSpeed;
            _playbackSpeed = _playbackController.PlaybackSpeed;
            SpeedChanged();
        }

        public void ResetSpeed()
        {
            _playbackController.PlaybackSpeed = 1.0F;
            _playbackSpeed = _playbackController.PlaybackSpeed;
            SpeedChanged();
        }


        private void PrepareControls(Panel videoPanel)
        {
            _currentVideoPanel = videoPanel;
            _videoPictureBox = new PictureBox();
            videoPanel.Controls.Clear();
            videoPanel.Controls.Add(_videoPictureBox);
            _videoPictureBox.Dock = DockStyle.Fill;

            _playbackFQID = null;//Null в данном случае - использование стандартного способа управления контролом
            _playbackUserControl = ClientControl.Instance.GeneratePlaybackUserControl();
            _playbackUserControl.Visible = true;
            _playbackUserControl.Dock = DockStyle.Fill;

            _playbackController = ClientControl.Instance.GetPlaybackController(_playbackFQID);

            _bitmapSource = new BitmapSource();
            _bitmapSource.PlaybackFQID = _playbackFQID;
            _bitmapSource.NewBitmapEvent += _bitmapSource_NewBitmapEvent;
            _bitmapSource.Selected = true;
        }

        /*public void chooseCameraManually(Panel videoPanel) //Удобные функции для тестирования архива
        {//Первая выставляет изображение в выбранную панель, вторая возвращает аргументом выбранную камеру
            PrepareControls(videoPanel);
            CloseCurrent();
            ItemPickerForm form = new ItemPickerForm();
            form.KindFilter = Kind.Camera;
            form.AutoAccept = true;
            form.Init(Configuration.Instance.GetItems(ItemHierarchy.Both));
            if (form.ShowDialog() == DialogResult.OK)
            {
                _newlySelectedItem = form.SelectedItem;
                _bitmapSource.Item = _newlySelectedItem;
                InitBitmap();
            }
        }*/

        public ICameraModel chooseCameraManually()
        {
            ItemPickerForm form = new ItemPickerForm();
            form.KindFilter = Kind.Camera;
            form.AutoAccept = true;
            form.Init(Configuration.Instance.GetItems(ItemHierarchy.Both));
            if (form.ShowDialog() == DialogResult.OK)
            {
                Camera cam = new Camera(form.SelectedItem.FQID, form.SelectedItem.Name);
                return cam;
            }
            return null;
        }
    }
}
