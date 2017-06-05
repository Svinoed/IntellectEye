using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using Contract;
using System.ComponentModel.Composition;

namespace Presenter
{
    class SmallSearchPresenter
    {
        [Import]
        private ICameraManagerModel _cameraManager;
        private ISmallSearchView _view;
        private IPlaybackPresenter _presenter;
        private IMainPresenter _presToAdd;

        private List<ICameraModel> _camerasList;

        public SmallSearchPresenter(ISmallSearchView view, IMainPresenter presToAdd)
        {
            ComposContainer.Instance().Compose(this);
            _view = view;
            _presToAdd = presToAdd;
            _view.CreatePresenter += () => CreatePresenter();
            _view.GetCameras += SetCameraList;
            SetCameraList();
        }


        public ISmallSearchView GetView()
        {
            return _view;
        }

        private void CreatePresenter()
        {
            PlaybackPresenter playbackPres = new PlaybackPresenter(new MiniPlayBack());
            playbackPres.InitialTime = _view.StartTimePicker.Value;
            playbackPres.EndTime = _view.EndTimePicker.Value;
            dynamic id = _view.CamerasListView.SelectedItems[0].Tag;
            ICameraModel cam = _cameraManager.GetCamera(id);
            playbackPres.Camera = cam;
            _presToAdd.AddPlayback(playbackPres);
        }

        private void SetCameraList()
        {
            _camerasList = new List<ICameraModel>();
            _camerasList = _cameraManager.GetCameras();
            Dictionary<dynamic, string> cameras = new Dictionary<dynamic, string>();
            foreach (var c in _camerasList)
            {
                cameras.Add(c.Id, c.Name);
            }
            _view.Cameras = cameras;
        }
    }
}
