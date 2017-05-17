using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using VideoOS.Platform.Client;
using VideoOS.Platform;
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
    class PlaybackModel : IPlaybackModel
    {
        #region private fields

        public double PlaybackSpeed { get {return _playbackSpeed; } set { this._playbackSpeed = value; } }

        public bool SkipGaps { get { return _playbackController.SkipGaps; } set{ _playbackController.SkipGaps = value; } }

        private Bitmap _currentOriginalBitmap = null;

        private Panel currentVideoPanel;
        private PictureBox videoPictureBox;

        private FQID _playbackFQID;
        private Item _newlySelectedItem;

        private PlaybackController _playbackController;
        private PlaybackUserControl _playbackUserControl;

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
                _newlySelectedItem = new Item(camera.Id, camera.Name);
                _bitmapSource.Item = _newlySelectedItem;
                InitBitmap();
            }
            catch (Exception ex)
            {
                EnvironmentManager.Instance.ExceptionDialog("Camera select", ex);
            }
        }
        
        public void SetVideoStreamInPanelFromFile(string filename, Panel videoPanel)
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

                        ChooseCameraSource();
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

        public void SetVideoStreamInPanelFromFolder(string pathToFolder, Panel videoPanel)
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

        public void SetAndEnableTimeline(Panel timeLinePanel)
        {
            //Milestone variant
            _playbackUserControl = ClientControl.Instance.GeneratePlaybackUserControl();
            _playbackUserControl.Visible = true;
            _playbackUserControl.Dock = DockStyle.Fill;
            timeLinePanel.Controls.Add(_playbackUserControl);
            _playbackUserControl.BringToFront();
            _playbackUserControl.Init(_playbackFQID);
            _playbackUserControl.SetCameras(new List<FQID>() { _newlySelectedItem.FQID });
            _playbackUserControl.SetEnabled(true);  // Refresh the TimeLine 
            //Milestone varian
        }


        
        private void _bitmapSource_NewBitmapEvent(Bitmap bitmap)
        {
            Control hostElement = currentVideoPanel.Parent;
            if (hostElement.InvokeRequired)
            {
                if (_currentOriginalBitmap != null)
                    _currentOriginalBitmap.Dispose();
                _currentOriginalBitmap = new Bitmap(bitmap);
                bitmap.Dispose();

                hostElement.BeginInvoke(new MethodInvoker(() => _bitmapSource_NewBitmapEvent(_currentOriginalBitmap)));
                MethodInvoker toSend = new MethodInvoker(() => _bitmapSource_NewBitmapEvent(_currentOriginalBitmap));
            }
            else
            {
                lock (hostElement)
                {
                    videoPictureBox.Image = new Bitmap(bitmap, videoPictureBox.Width, videoPictureBox.Height);
                    hostElement.Refresh();
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

            videoPictureBox.Image = new Bitmap(100, 60);
            //buttonCamera.Text = "Select camera...";//Разнообразные атавизмы, если будет какая-то система оповещений,
            //buttonCamera.Enabled = false;//то надо бы дописать вывод состояний
            //_loggedOn = false;
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

        private void PrepareControls(Panel videoPanel)
        {
            _playbackFQID = null;//Зачем мы присваеваем ему null?
            currentVideoPanel = videoPanel;
            videoPanel.Controls.Clear();
            videoPanel.Controls.Add(videoPictureBox);
            videoPictureBox.Dock = DockStyle.Fill;

            _playbackController = ClientControl.Instance.GetPlaybackController(_playbackFQID);
            _bitmapSource = new BitmapSource();
            _bitmapSource.PlaybackFQID = _playbackFQID;
            _bitmapSource.NewBitmapEvent += _bitmapSource_NewBitmapEvent;
            _bitmapSource.Selected = true;

            EnvironmentManager.Instance.TraceFunctionCalls = true;
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
    }
}
