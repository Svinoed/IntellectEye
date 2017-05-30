using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Utils;

namespace View.Interfaces
{
    public interface IMainView
    {

        bool ViewVisible { get; set; }
        void AddVideoControl(IVideoView view);
        void AddListVideoLiveControl(List<IVideoBase> list);
        void SetGroups(Dictionary<Guid, Group> groups, Guid activeGroup);

        event Action<Group> CamEditClick;
        event Action GroupsEditClick;
        event Action<Group> GroupSelected;
        event Action ActivatedPlaybackTab;

        Dictionary<Guid, Group> EditGroups(Dictionary<Guid,Group> groups, Dictionary<dynamic, string> cameras);

        void AddPlaybackControl(IPlaybackView view);
        void AddListPlayBack(List<IVideoBase> list);
    }
}
