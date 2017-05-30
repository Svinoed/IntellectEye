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
        private List<IPlaybackPresenter> _playbackPresenters;
        private Group _activeGroup;

        // Переход к
        private readonly Action<ICameraModel> _handler;

        public MainPresenter(IMainView view, Action<ICameraModel> handler)
        {
            ComposContainer.Instance().Compose(this);
            if ((view != null) && (handler != null))
            {
                this._view = view;
                _handler = handler;
                _view.GroupsEditClick += EditGroups;
                _view.GroupSelected += SetActiveGroup;
                _view.ActivatedPlaybackTab += ActivatedPlayBackTab;
           
                _groups = new Dictionary<Guid, Group>();
                _smallPresenters = new List<ISmallVideoPresenter>();
                _playbackPresenters = new List<IPlaybackPresenter>();
                LoadGroups();
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
            GreateSmallPresenter();
            List<IVideoBase> listVideo = new List<IVideoBase>(GetListView());
            _view.AddListVideoLiveControl(listVideo);
            SetCameraToSmallView();
            _view.SetGroups(_groups, _activeGroup.Id);
        }

        public void SetVisible(bool visible)
        {
            if (visible != _view.ViewVisible)
            {
                _view.ViewVisible = visible;
            }
        }

        #region  Video live

        #region Edit handler by shukur
        /// <summary>
        /// Обрабатывает собитие кнопки редактирования групп
        /// </summary>
        private void EditGroups()
        {
            Dictionary<dynamic, string> cameras = GetListCamera();
            var groups = _view.EditGroups(_groups, cameras);
            if (groups == null)
            {
                return; // изменений не было
            }
            _groups = groups;

            if (!_groups.ContainsKey(_activeGroup.Id))
            {
                _activeGroup = _groups.ElementAt(0).Value;
            }
            else
            {
                _activeGroup = _groups[_activeGroup.Id];
            }

            RefreshVideo();
        }

        private Dictionary<dynamic, string> GetListCamera()
        {
            Dictionary<dynamic, string> cameras = new Dictionary<dynamic, string>();
            List<ICameraModel> list = _cameraManager.GetCameras();

            foreach (var c in list)
            {
                cameras.Add(c.Id, c.Name);
            }

            return cameras;
        }
        #endregion

        private void SetActiveGroup(Group group)
        {
            if (!group.Equals(_activeGroup))
            {
                _activeGroup = group;
                RefreshVideo();
            }
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
        private List<IVideoBase> GetListView()
        {
            List<IVideoBase> list = new List<IVideoBase>();
            int count = _activeGroup.Cameras.Count;
            for (int i = 0; i < count; i++)
            {
                ISmallView view = _smallPresenters[i].GetView();
                view.ClearPanel();
                list.Add(view);
            }
            return list;
        }

        private void DisconnectAll()
        {
            foreach (var p in _smallPresenters)
            {
                p.Disconnect();
            }
        }

        private void SetCameraToSmallView()
        {
            var c = _activeGroup.Cameras.Keys; ;
            for (int i = 0; i < c.Count; i++)
            {
                ICameraModel camera = _cameraManager.GetCamera(c.ElementAt(i));
                ISmallVideoPresenter presenter = _smallPresenters[i];
                presenter.Camera = camera;
                presenter.SetCamera();
            }
        }


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
                List<ICameraModel> cameras = _cameraManager.GetCameras();
                Group defaultGroup = new Group("По умолчанию");
                for (int i = 0; i < cameras.Count && i < 16; i++)
                {
                    ICameraModel camera = cameras.ElementAt(i);
                    defaultGroup.Cameras.Add(camera.Id, camera.Name);
                }
                _activeGroup = defaultGroup;
                _groups.Add(defaultGroup.Id, defaultGroup);
            }
        }
        #endregion

        private void RefreshVideo()
        {
            if (_activeGroup.Cameras.Count > _smallPresenters.Count)
            {
                GreateSmallPresenter();
            }
            DisconnectAll();
            List<IVideoBase> listVideo = GetListView();
            _view.AddListVideoLiveControl(listVideo);
            SetCameraToSmallView();
            _view.SetGroups(_groups, _activeGroup.Id);
        }

        #endregion



        #region Video playback

        private void ActivatedPlayBackTab()
        {
            GreatePlaybacks();
            List<IVideoBase> list = GetPlaybackView();
            _view.AddListPlayBack(list);
        }

        private void GreatePlaybacks()
        {
            for (int i = 0; i < 4; i++)
            {
                IPlaybackPresenter playbackPresenter = new PlaybackPresenter(new MiniPlayBack());
                _playbackPresenters.Add(playbackPresenter);
            }
        }

        private List<IVideoBase> GetPlaybackView()
        {
            List<IVideoBase> list = new List<IVideoBase>();
            foreach (IPlaybackPresenter p in _playbackPresenters)
            {
                list.Add(p.GetView());
            }
            return list;
        }
        #endregion
    }
}
