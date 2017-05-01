using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
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

        public VideoPresenter(IVideoView view, Action backHandler)
        {
            if(view != null)
            {
                _view = view;
                _view.Back += backHandler;
            }
           
        }

        public IVideoView GetView()
        {
            return _view;
        }
    }
}
