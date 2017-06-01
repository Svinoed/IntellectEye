using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Interfaces;

namespace View
{
    public partial class MiniPlayBack : UserControl, IPlaybackView
    {
        public MiniPlayBack()
        {
            InitializeComponent();

        }

        public ProgressBar TimeLine { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public Label CurrentPlaybackSpeedLabel { get { return this.playbackSpeedLabel; } set { this.playbackSpeedLabel = value; } }
        public string CameraName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); }  }
        public Panel VideoPanel { get { return this.videoPanel; } set { this.videoPanel = value; }  }

        public event Action PlayButtonPressed;
        public event Action ChangeDirectionButtonPressed;
        public event Action SlowDownButtonPressed;
        public event Action SpeedUpButtonPressed;
        public event Action ResetSpeedButtonPressed;
        public event Action CameraSelected;
        public event Action CreatePrintScreen;
        public event Action CreateBookMarker;
        public event Action CreateComment;
        public event Action Back;
        public event Action VolumeChanged;
    }
}
