using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Utils;

namespace View.Interfaces
{
    public interface IMainView : IView
    {

        bool ViewVisible { get; set; }
        void AddVideoControl(IVideoView view);
        void AddListControl(List<ISmallView> list);
        void SetGroups(Dictionary<Guid, Group> groups, Guid activeGroup);

        event Action<Group> CamEditClick;
        event Action GroupsEditClick;

        Group EditGroup(Group group, Dictionary<dynamic, string> cameras);
        Dictionary<Guid, Group> EditGroups(Dictionary<Guid,Group> groups, Dictionary<dynamic, string> cameras);
       
    }
}
