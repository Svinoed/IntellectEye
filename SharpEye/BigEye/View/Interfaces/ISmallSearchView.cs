using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Interfaces
{
    public interface ISmallSearchView
    {
        DateTimePicker StartTimePicker { get;}
        DateTimePicker EndTimePicker { get;}
        Dictionary<dynamic, string> Cameras { get; set; }
        ListView CamerasListView { get; }
        event Action GetCameras;
        event Action CreatePresenter;
    }
}
