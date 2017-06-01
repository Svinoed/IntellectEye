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
            else if (!IsChangedActiveGroupe())
            {
                return;
            }

            _activeGroup = _groups[_activeGroup.Id];
            RefreshVideo();
        }

        private bool IsChangedActiveGroupe()
        {
            var keys = _groups[_activeGroup.Id].Cameras.Keys;
            if (keys.Count != _activeGroup.Cameras.Count)
            {
                return true;
            }

            for (int i = 0; i < keys.Count; i++)
            {
                ICameraModel camera = _cameraManager.GetCamera(keys.ElementAt(i));
                if (!camera.EqualsId(_activeGroup.Cameras.ElementAt(i).Key))
                {
                    return true;
                }
            }
            return false;
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
                presenter.Disconnect();
                presenter.Camera = camera;
                presenter.ShowVideo();
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
                Group defaultGroup = new Group("Группа по умолчанию");
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
            int prevControlNumber = FreePlace(_smallPresenters.Count);
            int diff = _activeGroup.Cameras.Count - _smallPresenters.Count;
            int currentControlNumber = FreePlace(_activeGroup.Cameras.Count);

            // Если число камер в группе увеличилось 
            // и в сетке есть места для новых камер, то помещаем их туда
            if (diff > 0 && diff <= prevControlNumber)
            {
                int prevSize = _smallPresenters.Count;
                GreateSmallPresenter();
                for (int i = prevSize; i < _activeGroup.Cameras.Count; i++)
                {
                    _view.AddVideoControl(_smallPresenters[i].GetView());
                }
            }
            // Если число камер в группе уменьшилось так, что не нужно перестраиваить сетку,
            // то пользуемся ей
            else if (diff < 0 && currentControlNumber == prevControlNumber)
            {
                int index = _smallPresenters.Count + diff;
                for (int i = index - 1; i < _smallPresenters.Count; i++)
                {
                    _smallPresenters[i].Disconnect();
                    _smallPresenters.RemoveAt(i);
                }

               _view.ClearCellsLiveTable(index);    
            }
            // Нет возможности воспользоваться созданной сеткой
            else if (diff > prevControlNumber || (diff < 0 && currentControlNumber != prevControlNumber))
            {
                DisconnectAll();
                List<IVideoBase> listVideo = GetListView();
                _view.AddListVideoLiveControl(listVideo);
            }
            SetCameraToSmallView();
            _view.SetGroups(_groups, _activeGroup.Id);
        }
        #endregion



        #region Video playback

        private void ActivatedPlayBackTab()
        {
            if (_playbackPresenters.Count == 0)
            {
                GreatePlaybacks();
            }
            List<IVideoBase> list = GetPlaybackView();
            _view.AddListPlayBack(list);
        }

        private void AddPlayback()
        {
            int numberFreePlace = FreePlace(_playbackPresenters.Count);
            IPlaybackPresenter playbackPresenter = new PlaybackPresenter(new MiniPlayBack());
            _playbackPresenters.Add(playbackPresenter);
            if (numberFreePlace > 0)
            {
                _view.AddPlaybackControl(playbackPresenter.GetView());
            }
            else
            {
                List<IVideoBase> list = GetPlaybackView();
                _view.AddListPlayBack(list);
            }
        }

        private void RemovePlayback()
        {
            
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">Число элементов требующих размещения</param>
        /// <returns>Число свободных мест</returns>
        private int FreePlace(int size)
        {
            int sqrt = (int)Math.Sqrt(size);
            int columns;
            if (sqrt * sqrt == size)
            {
                columns = sqrt;
            }
            else
            {
                columns = sqrt + 1;
            }

            int rows;
            if ((columns - 1) * columns >= size)
            {
                rows = columns - 1;
            }
            else
            {
                rows = columns;
            }

            int cels = rows * columns;
            return cels;
        }
    }
}
