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

        public ProgressBar TimeLine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Label CurrentPlaybackSpeedLabel { get { return this.playbackSpeedLabel; } set { this.playbackSpeedLabel = value; } }
        public string CameraName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public event Action Up;
        public event Action UpLeft;
        public event Action UpRight;
        public event Action Down;
        public event Action DownLeft;
        public event Action DownRight;
        public event Action ToRight;
        public event Action ToLeft;
        public event Action Home;
        public event Action<float> ZoomIn;
        public event Action<float> ZoomOut;
        public void SaveImage(byte[] img, string format)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowProgressBar()
        {
            throw new NotImplementedException();
        }

        public void HideProgressBar()
        {
            throw new NotImplementedException();
        }

        public void HidePtzControl()
        {
            throw new NotImplementedException();
        }

        public void ShowPtzControl()
        {
            throw new NotImplementedException();
        }

        public Task SetValueProgressBar(float value)
        {
            throw new NotImplementedException();
        }

        public event Action VolumeChanged;

        private void switchOrderButton_Click(object sender, EventArgs e)
        {
            ChangeDirectionButtonPressed();
        }

        private void slowDownButton_Click(object sender, EventArgs e)
        {
            SlowDownButtonPressed();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.ImageIndex == 14)
            playButton.ImageIndex = 15;
            else playButton.ImageIndex = 14;
            PlayButtonPressed();
        }

        private void fastUpButton_Click(object sender, EventArgs e)
        {
            SpeedUpButtonPressed();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            ResetSpeedButtonPressed();
        }

        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            if (fullscreenButton.ImageIndex == 21)
            {
                fullscreenButton.ImageIndex = 20;
                playBToolTip.SetToolTip(fullscreenButton, "Выйти из полноэкранного режима");
            }
            else
            {
                fullscreenButton.ImageIndex = 21;
                playBToolTip.SetToolTip(fullscreenButton, "Перейти в полноэкранный режим");
            }
        }

    }
}
