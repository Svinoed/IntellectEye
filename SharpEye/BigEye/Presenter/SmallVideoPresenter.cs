using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using View.Interfaces;
using System.ComponentModel.Composition;

namespace Presenter
{
    class SmallVideoPresenter : ISmallVideoPresenter
    {
        private ISmallView _view;
        private ICameraModel _camera;
        [Import]
        private IVideoModel _videoModel;

        public ICameraModel Camera
        {
            get
            {
                return _camera;
            }

            set
            {
                _camera = value;
                _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel);
            }
        }

        public event Action<ICameraModel> FullScreen;

        public SmallVideoPresenter(ISmallView view, Action<ICameraModel> handler)
        {
            ComposContainer.Instance().Compose(this);
            if ((view != null) && (handler != null))
            {
                _view = view;
                FullScreen += handler;
            }
        }

        private void ViewFullScreenHandler()
        {
            if (FullScreen != null)
            {
                FullScreen(Camera);
            }
        }

        public ISmallView GetView()
        {
            return _view;
        }
    }
}
