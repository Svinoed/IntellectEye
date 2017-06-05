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
            _view.VideoPanel.BeginInvoke((Action) delegate
            {
                _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
            });
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
            _printScreenModel.HostName = "5.136.105.0";
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
            _view.Down += () =>
            {
                Task.Run(() => { _ptzModel.Down(); });
            };
            _view.DownLeft += () => {
                Task.Run(() => { _ptzModel.Left(); });
            };
            _view.DownRight += () => { Task.Run(() => { _ptzModel.DownRight(); }); };

            _view.Up += () => { Task.Run(() => { _ptzModel.Up(); }); };

            _view.UpLeft += () => { Task.Run(() => { _ptzModel.UpLeft(); }); };

            _view.UpRight += () => { Task.Run(() => { _ptzModel.UpRight(); }); };

            _view.ToLeft += () => { Task.Run(() => { _ptzModel.Left(); }); };

            _view.ToRight += () => { Task.Run(() => { _ptzModel.Right(); }); };

            _view.ZoomIn += (s) => { Task.Run(() => { _ptzModel.ZoomIn(s); }); };

            _view.ZoomOut += (s) => { Task.Run(() => { _ptzModel.ZoomOut(s); }); };

            _view.Home += () => { Task.Run(() =>
                {
                    _ptzModel.Home();
                    _videoModel.PTZDefault();
                });
            };
        }
        #endregion
    }
}
