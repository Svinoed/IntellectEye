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
                MessageBox.Show("Step1");
            this._camera = value;
            MessageBox.Show("Set");
            _playbackModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
             
            //_playbackModel.SetAndEnableTimeline(_view.TimeLinePanel);
            //_playbackModel.SetAudioStreamInPanelDefault(_camera, _view.VideoPanel);
        }
    }

        public PlaybackPresenter(IPlaybackView view/*,IAudioModel audioModel*/)
        {
            ComposContainer.Instance().Compose(this);
            if (view != null)
            {
                _view = view;
                //_audioModel = audioModel;
                _view.PlayButtonPressed += play;
                _view.SlowDownButtonPressed += slowDown;
                _view.SpeedUpButtonPressed += speedUp;
                _view.ChangeDirectionButtonPressed += changeDirection;
                _view.ResetSpeedButtonPressed += resetSpeed;
                _playbackModel.SpeedChanged += updateSpeed;
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
            _playbackModel.ResetSpeed();
        }

        private void updateSpeed()
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
