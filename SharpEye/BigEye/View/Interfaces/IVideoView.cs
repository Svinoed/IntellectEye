using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using View.Interfaces;
using System.Windows.Forms;

namespace View.Interfaces
{
    public interface IVideoView : IView
    {
        string CameraName { set; get; }

        Panel VideoPanel { set; get; }

        event Action CameraSelected;
        event Action CreatePrintScreen;
        event Action CreateBookMarker;
        event Action CreateComment;
        event Action Back;
        // Продумывается
        event Action VolumeChanged;
    }
}