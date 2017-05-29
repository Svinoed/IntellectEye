using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Presenter.Interfaces;
using View.Interfaces;
using System.Windows.Forms;
using System.ComponentModel.Composition;

namespace Presenter
{
    class VideoPresenter: IVideoPresenter
    {
        private readonly IVideoView _view;
        private ICameraModel _camera;
        private readonly Action _backHandler;

        [Import]
        private IVideoModel _videoModel;
        [Import]
        private IAudioModel _audioModel;
        [Import]
        private IPTZModel _ptzModel;
        [Import]
        private IPrintScreenModel _printScreenModel;

        public ICameraModel Camera { get { return this._camera; }
            set
            {
                this._camera = value;
                Set();
            }
        }

        public VideoPresenter(IVideoView view, Action backHandler)
        {
            ComposContainer.Instance().Compose(this);
            if (view != null)
            {
                _view = view;
                _backHandler = backHandler;
                _view.Back += Back;
               _view.CreatePrintScreen += CreateScreen;
                BindMoveCommandHandler();
                _printScreenModel.SendMessage += ErrorMessage;
                _printScreenModel.Created += PrintScreenCreated;
                _printScreenModel.Progress += Progress;
            }
           
        }
        
        private void Back()
        {
            _videoModel.Disconnect();
            _audioModel.Disconnect();
            _backHandler();
        }
 

        public IVideoView GetView()
        {
            return _view;
        }

        private void Set()
        {
            _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
            if (_camera.IsPtz)
            {
                _ptzModel.Camera = _camera;
                _view.ShowPtzControl();
            }
            else
            {
                _view.HidePtzControl();
            }

            if (_camera.MicrophoneId != null)
            {
                _audioModel.SetAudioStreamInPanel(_camera, _view.VideoPanel);
            }
        }

        private void CreateScreen ()
        {
            // из конфига 
            _printScreenModel.HostName = "5.136.125.97";
            Task task = new Task(() =>
            {
                _printScreenModel.CreateLiveScreen(_camera);
            });
            task.Start();
            _view.ShowProgressBar();
        }

        private void PrintScreenCreated(byte[] img, string format)
        {
            if (!format.StartsWith("."))
            {
                format = "." + format;
            }
            _view.HideProgressBar();
            _view.SaveImage(img, format);
        }

        private void ErrorMessage(string message)
        {
            _view.HideProgressBar();
            _view.ShowMessage(message);
        }

        private async void Progress(float value)
        {
            await _view.SetValueProgressBar(value);
        }

        #region PTZCommand handler
        private void BindMoveCommandHandler()
        {
            _view.Down += () => {
                Task task = new Task(() => { _ptzModel.Down(); });
                task.Start();
            };
            _view.DownLeft += () => {
                Task task = new Task(() => { _ptzModel.Left(); });
                task.Start();
            };
            _view.DownRight += () => {
                Task task = new Task(() => { _ptzModel.DownRight(); });
                task.Start();
            };
            _view.Up += () => {
                Task task = new Task(() => { _ptzModel.Up(); });
                task.Start();
            };
            _view.UpLeft += () => {
                Task task = new Task(() => { _ptzModel.UpLeft(); });
                task.Start();
            };
            _view.UpRight += () => {
                Task task = new Task(() => { _ptzModel.UpRight(); });
                task.Start();
            };
            _view.ToLeft += () => {
                Task task = new Task(() => { _ptzModel.Left(); });
                task.Start();
            };
            _view.ToRight += () => {
                Task task = new Task(() => { _ptzModel.Right(); });
                task.Start();
            };
            _view.ZoomIn += (s) => {
                Task task = new Task(() => { _ptzModel.ZoomIn(s); });
                task.Start();
            };
            _view.ZoomOut += (s) => {
                Task task = new Task(() => { _ptzModel.ZoomOut(s); });
                task.Start();
            };
            _view.Home += () => {
                Task task = new Task(() =>
                {
                    _ptzModel.Home();
                });
                Task taskDefaultZoom = new Task(() =>
                {
                    _videoModel.PTZDefault();
                });

                task.Start();
                taskDefaultZoom.Start();
            };
        }
        #endregion
    }
}
