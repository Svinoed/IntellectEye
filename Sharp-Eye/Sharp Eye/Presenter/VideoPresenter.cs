using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Presenter.Interfaces;
using View.Interfaces;
using System.Windows.Forms;

namespace Presenter
{
    class VideoPresenter: IVideoPresenter
    {
        private IVideoView _view;
        private ICameraModel _camera;
        private IVideoModel _videoModel;
        private IAudioModel _audioModel;//Она тут нужна или отдельно выносим? Ответ: Да, нужна. Все правильно делаешь.

        public ICameraModel Camera { get { return this._camera; }
            set
            {
                this._camera = value;
                _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
                _audioModel.SetAudioStreamInPanelDefault(_camera, _view.VideoPanel);           
            }
        }

        public VideoPresenter(IVideoView view, IVideoModel videoModel, IAudioModel audioModel)
        {
            if(view != null && videoModel != null && audioModel != null)
            {
                _view = view;
                _videoModel = videoModel;
                _audioModel = audioModel;
            }
        }

        public IVideoView GetView()
        {
            return _view;
        }
    }
}
