using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using View.Interfaces;
using System.ComponentModel.Composition;
using System.Diagnostics;

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
            }
        }

        private void ViewFullScreenHandler(object sender, EventArgs e)
        {
            Debug.WriteLine("Sender: {0}\nArgs: {1}", sender.ToString(), e.ToString());
            if (FullScreen != null && _camera != null)
            {
                FullScreen(Camera);
            }
        }

        public ISmallView GetView()
        {
            return _view;
        }

        public async void ShowVideo()
        {
          
            await Task.Run(() =>
            {
                _view.VideoPanel.BeginInvoke(((Action) delegate
              {
                  _videoModel.SetVideoStreamInPanel(_camera, 
                      _view.VideoPanel, ViewFullScreenHandler);
              })); 
            });
        }

        public void Disconnect()
        {
            if (_camera != null)
            {
                _videoModel.Disconnect();
            }
        }
    }
}
