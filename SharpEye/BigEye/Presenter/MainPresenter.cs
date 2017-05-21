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
    public class MainPresenter : IMainPresenter
    {

        private IMainView _view;
        [Import]
        private ICameraManagerModel _cameraManager;
        private IVideoPresenter _videoPresenter;

        private Dictionary<Guid, Group> _groups;
        private List<ISmallVideoPresenter> _smallPresenters; 
        private Group _activeGroup;

        // Переход к
        private Action<ICameraModel> _handler;

        public MainPresenter(IMainView view, Action<ICameraModel> handler)
        {
            ComposContainer.Instance().Compose(this);
            if ((view != null) && (handler != null))
            {
                this._view = view;
                _handler = handler;
                _view.CamEditClick += (g) => EditGroup(g);
                _view.GropsEditClick += () => EditGroups();
           
                _groups = new Dictionary<Guid, Group>();
                _smallPresenters = new List<ISmallVideoPresenter>();
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
            GreateSmallPresenter();
            List<ISmallView> listVideo = GetListView();
            _view.AddListControl(listVideo);
            SetCameraToSmallView();
        }

        #region ListVideo
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void GreateSmallPresenter()
        {
            int diff = _activeGroup.Cameras.Count - _smallPresenters.Count;
            for (int i = 0; i < diff; i++)
            {
                ISmallVideoPresenter smallPresenter =
                    new SmallVideoPresenter(new SmallControl(), _handler);
                _smallPresenters.Add(smallPresenter);
            }         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<ISmallView> GetListView()
        {
            List<ISmallView> list = new List<ISmallView>();
            foreach(var v in _smallPresenters)
            {
                list.Add(v.GetView());
            }
            return list;
        }

        private void SetCameraToSmallView()
        {
            var c = _activeGroup.Cameras.Keys;
            for (int i = 0; i < c.Count; i++)
            {
                ICameraModel camera = _cameraManager.GetCameras().ElementAt(0);
                _smallPresenters[i].Camera = camera;
            }
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
                    ICameraModel camera = _cameraManager.GetCameras().ElementAt(0);
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
