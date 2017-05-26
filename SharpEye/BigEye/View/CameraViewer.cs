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
    public partial class CameraViewer : UserControl, IVideoView
    {
        public Panel VideoPanel { get { return videoPanel; } set { videoPanel = value; } }
        public event Action ToRight;
        public event Action ToLeft;
        public event Action CreatePrintScreen;
        public event Action CreateBookMarker;
        public event Action CreateComment;
        public event Action Back;
        public event Action Up;
        public event Action UpLeft;
        public event Action UpRight;
        public event Action Down;
        public event Action DownLeft;
        public event Action DownRight;
        public event Action Home;
        public event Action<float> ZoomIn;
        public event Action<float> ZoomOut;
        public event Action VolumeChanged;
        public CameraViewer()
        {
            InitializeComponent();
            //this.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            this.Dock = DockStyle.Fill;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (Up != null)
            {
                Up();
            }
        }

        private void rightUpButton_Click(object sender, EventArgs e)
        {
            if (UpRight != null)
            {
                UpRight();
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (Down != null)
            {
                Down();
            }
        }

        private void leftUpButton_Click(object sender, EventArgs e)
        {
            if (UpLeft != null)
            {
                UpLeft();
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (ToRight != null)
            {
                ToRight();
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (ToLeft != null)
            {
                ToLeft();
            }
        }

        private void leftDownButton_Click(object sender, EventArgs e)
        {
            if (DownLeft != null)
            {
                DownLeft();
            }
        }

        private void rightDownButton_Click(object sender, EventArgs e)
        {
            if (DownRight != null)
            {
                DownRight();
            }
        }

        private void zoomMinusButton_Click(object sender, EventArgs e)
        {
            if (ZoomOut != null)
            {
                ZoomOut(0.1f);
            }
        }

        private void zoomPlusButton_Click(object sender, EventArgs e)
        {
            if (ZoomIn != null)
            {
                ZoomIn(0.1f);
            }
        }

        private void exitFullscreenButton_Click(object sender, EventArgs e)
        {
            if (Back != null)
            {
                Back();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (Home != null) {
                Home();
            }
        }
    }
}
