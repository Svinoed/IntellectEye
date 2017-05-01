using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using System.Windows.Forms;
using System.ComponentModel.Composition;

namespace Presenter
{
    /// <summary>
    /// Этот класс
    /// управляет всеми презентерами в приложении.
    /// </summary>
    class MainPresenter : IMainPresenter
    {

        private IMainView _view;
        [Import]
        private ICameraManagerModel _cameraManager;
        [Import]
        private IVideoPresenter _videoPresenter;

        // Переход к
        private Action<ICameraModel> _handler;

        public MainPresenter(IMainView view, Action<ICameraModel> handler)
        {
            if((view != null) && (handler != null))
            {
                this._view = view;
                _handler = handler;
                _view.CamEditClick += (g) => EditGroup(g);
                _view.GropsEditClick += () => EditGroups();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public IMainView GetView()
        {
            return this._view;
        }

        public void Run()
        {
            // временный код
            _view.SetCameraList(CameraNames());
            //_videoPresenter = new VideoPresenter( new VideoControl(), EntityCreator.VideoModelBuild(), EntityCreator.AudioModelBuild());
            _view.AddVideoControl(_videoPresenter.GetView());
        }

        public void SetVisible(bool visible)
        {
            if (visible != _view.ViewVisible)
            {
                _view.ViewVisible = visible;
            }
        }

        private void EditGroup(string group)
        {

        } 

        private void EditGroups()
        {

        }

        private void CameraSelected()
        {
            ICameraModel camera = _cameraManager.GetCameras().Find(c => c.Name == _view.Camera);
            _videoPresenter.Camera = camera;
        }

        #region array camera names
        private string[] CameraNames()
        {
            int count = _cameraManager.GetCameras().Count;
            string[] names = new string[count];
            for(int i = 0; i < count; i++)
            {
                names[i] = _cameraManager.GetCameras().ElementAt(i).Name;
            }
            return names;
        }
        #endregion

        #region Video live
        private void VideoLive()
        {

        }
        #endregion

        #region Video playback
        private void VideoPlayback()
        {

        }
        #endregion
    }
}
