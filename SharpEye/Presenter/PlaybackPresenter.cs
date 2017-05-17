using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.Composition;
using Presenter.Interfaces;
using View.Interfaces;

namespace Presenter
{
    class PlaybackPresenter
    {
    
    private IPlaybackView _view;
    private ICameraModel _camera;
    [Import(typeof(IPlaybackModel))]
    private IPlaybackModel _playbackModel;
    //private IAudioModel _audioModel;//Она тут нужна или отдельно выносим? Ответ: Да, нужна. Все правильно делаешь.

    public ICameraModel Camera
    {
        get { return this._camera; }
        set
        {
            this._camera = value;
            _playbackModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
            _playbackModel.SetAndEnableTimeline(_view.TimeLinePanel);
            //_playbackModel.SetAudioStreamInPanelDefault(_camera, _view.VideoPanel);
        }
    }

        public PlaybackPresenter(IPlaybackView view, IPlaybackModel playbackModel/*,IAudioModel audioModel*/)
        {
            ComposContainer.Instance().Compose(this);
            if (view != null && playbackModel != null)
            {
                _view = view;
                _playbackModel = playbackModel;
                //_audioModel = audioModel;
                _view.PlayButtonPressed += () => play();
                _view.SlowDownButtonPressed += () => slowDown();
                _view.SpeedUpButtonPressed += () => speedUp();
                _view.ChangeDirectionButtonPressed += () => changeDirection();
                _view.ResetSpeedButtonPressed += () => resetSpeed();
                _playbackModel.SpeedChanged += () => updateSpeed();
                _view.CreateComment += () => throw new NotImplementedException();
                _view.CreateBookMarker += () => throw new NotImplementedException();
                _view.CreatePrintScreen += () => throw new NotImplementedException();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void play()
        {
            _playbackModel.Play();
        }

        private void speedUp()
        {
            _playbackModel.SpeedUp();
        }

        private void slowDown()
        {
            _playbackModel.SlowDown();
        }


        private void changeDirection()
        {
            _playbackModel.ChangeDirection();
        }

        private void resetSpeed()
        {
            _playbackModel.ChangeDirection();
        }

        private void updateSpeed()
        {
            _view.CurrentPlaybackSpeedLabel.Text = _playbackModel.PlaybackSpeed.ToString();
        }


    public IVideoView GetView()
    {
        return _view;
    }
}
}
