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
using View.Utils;

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

        private Dictionary<Guid, Group> _groups;
        private Group _activeGroup;

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

                _groups = new Dictionary<Guid, Group>();
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

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            LoadGroups();
            List<ISmallView> listVideo = GetListVideo();
            _view.AddListControl(listVideo);
        }

        #region ListVideo
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<ISmallView> GetListVideo()
        {
            List<ISmallView> listVideo = new List<ISmallView>();
            foreach (var c in _activeGroup.Cameras.Keys)
            {
                ICameraModel camera = _cameraManager.GetCameras().Find(p => p.Id == c);
                ISmallVideoPresenter smallPresenter =
                    new SmallVideoPresenter(new SmallControl(), _handler);
                smallPresenter.Camera = camera;
                listVideo.Add(smallPresenter.GetView());
            }
            return listVideo;
        }
        #endregion

        /// <summary>
        /// Метод подгружает группы из конфига,
        /// если их нет, то создает одну группу по умолчанию
        /// </summary>
        private void LoadGroups()
        {
            // Здесь, подгружаем список групп
            if (false)
            {

            }
            else
            {
                int countOfCamera = _cameraManager.GetCameras().Count;
                Group defaultGroup = new Group("По умолчанию");
                for (int i = 0; i < countOfCamera && i < 16; i++)
                {
                    ICameraModel camera = _cameraManager.GetCameras().ElementAt(i);
                    defaultGroup.Cameras.Add(camera.Id, camera.Name);
                }
                _activeGroup = defaultGroup;
                _groups.Add(defaultGroup.Id, defaultGroup);
            }
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
            //ICameraModel camera = _cameraManager.GetCameras().Find(c => c.Name == _view.Camera);
            //_videoPresenter.Camera = camera;
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
