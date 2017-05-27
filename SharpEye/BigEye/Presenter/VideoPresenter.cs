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
        private IVideoView _view;
        private ICameraModel _camera;
        private Action _backHandler;

        [Import]
        private IVideoModel _videoModel;
        private IAudioModel _audioModel;//Она тут нужна или отдельно выносим? Ответ: Да, нужна. Все правильно делаешь.

        [Import]
        private IPTZModel _ptzModel;
        [Import]
        private IPrintScreenModel _printScreenModel;

        public ICameraModel Camera { get { return this._camera; }
            set
            {
                this._camera = value;
                _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
                _ptzModel.Camera = _camera;
                //_audioModel.SetAudioStreamInPanelDefault(_camera, _view.VideoPanel);           
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
            _backHandler();
        }

        public IVideoView GetView()
        {
            return _view;
        }

        private void CreateScreen ()
        {
            // из конфига 
            _printScreenModel.HostName = "5.136.72.14";
            _view.ShowProgressBar();
            _printScreenModel.CreateLiveScreen(_camera);
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

        private void Progress(float value)
        {
            _view.SetValueProgressBar(value);
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
                Task task = new Task(() => { _ptzModel.Left(); });
                task.Start();
            };
            _view.UpRight += () => {
                Task task = new Task(() => { _ptzModel.Right(); });
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
                Task task = new Task(() => { });
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
