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

        public ICameraModel Camera { get { return _camera; } set { _camera = value;} }

        public event Action<ICameraModel> FullScreen;

        public SmallVideoPresenter(ISmallView view, Action<ICameraModel> handler)
        {
            ComposContainer.Instance().Compose(this);
            if ((view != null) && (handler != null))
            {
                _view = view;
                FullScreen += handler;
                _view.FullScreen += () => ViewFullScreenHandler();
            }
        }

        private void ViewFullScreenHandler()
        {
            if (FullScreen != null && _camera != null)
            {
                FullScreen(Camera);
            }
        }

        public ISmallView GetView()
        {
            return _view;
        }

        public async void SetCamera()
        {
  
            await Task.Run(() =>
            {
                _view.VideoPanel.Invoke(((Action)delegate
              {
                  _videoModel.SetVideoStreamInPanel(_camera, _view.VideoPanel, (s, e) =>
                  {
                      ViewFullScreenHandler();
                  });
              })); 
            });
        }

        public void Disconnect()
        {
           _videoModel.Disconnect();
        }
    }
}
