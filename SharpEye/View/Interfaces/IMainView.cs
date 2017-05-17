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
        // Временно
        string Camera { set; get; }
        event Action CameraSelected;
        void SetCameraList(string[] cameras);

        bool ViewVisible { get; set; }
        void AddVideoControl(IVideoView view);
        void AddListControl(List<ISmallView> list);

        event Action<string> CamEditClick;
        event Action GropsEditClick;

        Group EditGroup(Group group);
        List<Group> EditGroups(List<Group> groups);
       
    }
}
