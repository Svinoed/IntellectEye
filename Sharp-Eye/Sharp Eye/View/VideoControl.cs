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
    public partial class VideoControl : UserControl, IVideoView
    {
        private Panel _panel; 

        public string CameraName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public Panel VideoPanel { get { return _panel; } set { _panel = value; } }

        public event Action CameraSelected;
        public event Action CreatePrintScreen;
        public event Action CreateBookMarker;
        public event Action CreateComment;
        public event Action VolumeChanged;

        public VideoControl()
        {
            InitializeComponent();
            _panel = new Panel();
        }

        private void VideoControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
