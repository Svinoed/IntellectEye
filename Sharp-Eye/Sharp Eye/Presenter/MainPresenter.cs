﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Interfaces;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using System.Windows.Forms;

namespace Presenter
{
    /// <summary>
    /// Этот класс
    /// управляет всеми презентерами в приложении.
    /// </summary>
    class MainPresenter : IMainPresenter
    {

        private IMainView _view;
        private ICameraManagerModel _cameraManager;
        private IVideoPresenter _videoPresenter;

        public MainPresenter(IMainView view)
        {
            if(view != null)
            {
                this._view = view;
                _view.CameraSelected += () => CameraSelected();
                _cameraManager = EntityCreator.CameraManagerBuild();
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
            _videoPresenter = new VideoPresenter( new VideoControl(), EntityCreator.VideoModelBuild(), EntityCreator.AudioModelBuild());
            _view.AddVideoControl(_videoPresenter.GetView());
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
