using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.Composition;
using Presenter.Interfaces;
using View.Interfaces;
using System.Windows.Forms;

namespace Presenter
{
    class PlaybackPresenter : IPlaybackPresenter
    {

    
        private IPlaybackView _view;
        private ICameraModel _camera;
        [Import(typeof(IPlaybackModel))]
        private IPlaybackModel _playbackModel;
        //private IAudioModel _audioModel;//Она тут нужна или отдельно выносим? Ответ: Да, нужна. Все правильно делаешь.

        private DateTime _initialTime = DateTime.MinValue;
        private DateTime _endTime = DateTime.MaxValue;

        public ICameraModel Camera
        {
            get { return this._camera; }
            set
            {
                this._camera = value;
                if (InitialTime != DateTime.MinValue && EndTime != DateTime.MaxValue)
                {
                    _playbackModel.SetVideoStreamInPanelAtTime(_camera, _view.VideoPanel, _initialTime,_endTime);
                }
                else if(InitialTime != DateTime.MinValue && EndTime == DateTime.MaxValue)
                {
                    _playbackModel.SetVideoStreamInPanel(_camera, _view.VideoPanel, _initialTime);
                }
                else
                {
                    _playbackModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
                }
                //_playbackModel.SetAudioStreamInPanelDefault(_camera, _view.VideoPanel);
            }
        }

        public DateTime InitialTime
        {
            get { return _initialTime; }
            set { _initialTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { this._endTime = value; }
        }

        public PlaybackPresenter(IPlaybackView view/*,IAudioModel audioModel*/) 
        {
            ComposContainer.Instance().Compose(this);
            if (view != null)
            {
                _view = view;
                //_audioModel = audioModel;
                _playbackModel.TimeLine = view.TimeLine;
                _view.PlayButtonPressed += () => Play();
                _view.SlowDownButtonPressed += () => SlowDown();
                _view.SpeedUpButtonPressed += () => SpeedUp();
                _view.ChangeDirectionButtonPressed += () => ChangeDirection();
                _view.ResetSpeedButtonPressed += () => ResetSpeed();
                _playbackModel.SpeedChanged += () => UpdateSpeed();
                _view.CreateComment += () => throw new NotImplementedException();
                _view.CreateBookMarker += () => throw new NotImplementedException();
                _view.CreatePrintScreen += () => throw new NotImplementedException();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void PickCameraFromFile(string filename)
        {
            _playbackModel.SetVideoStreamInPanelFromFileAtTime(filename, _view.VideoPanel,_initialTime,_endTime);
        }

        public void PickCameraFromFolder(string folderPath)
        {
            _playbackModel.SetVideoStreamInPanelFromFolderAtTime(folderPath, _view.VideoPanel,_initialTime,_endTime);
        }
        public void Play()
        {
            _playbackModel.Play();
        }

        public void SpeedUp()
        {
            _playbackModel.SpeedUp();
        }

        public void SlowDown()
        {
            _playbackModel.SlowDown();
        }


        public void ChangeDirection()
        {
            _playbackModel.ChangeDirection();
        }

        public void ResetSpeed()
        {
            _playbackModel.ResetSpeed();
        }

        public void UpdateSpeed()
        {
            _view.CurrentPlaybackSpeedLabel.Text = _playbackModel.PlaybackSpeed.ToString();
        }


    public IVideoView GetView()
    {
        return _view;
    }

    /*public void chooseCameraManually(Panel videoPanel) Отладочные функции
    {
            _playbackModel.chooseCameraManually(videoPanel);
    }*/
    
    public ICameraModel chooseCameraManually()
        {
            ICameraModel id;
            id = _playbackModel.chooseCameraManually();
            return id;
        }
}
}
