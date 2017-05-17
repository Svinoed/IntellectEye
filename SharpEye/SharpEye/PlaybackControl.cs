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
    public partial class PlaybackControl : UserControl, IPlaybackView
    {
        public PlaybackControl()
        {
            InitializeComponent();
            _videoPanel = this.videoPanel;
            _timeLinePanel = this.timeLinePanel;
            _currentPlaybackSpeedLabel = this.speedLabel;
        }

        private Panel _videoPanel;
        private Panel _timeLinePanel;
        private Label _currentPlaybackSpeedLabel;


        public string CameraName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Panel VideoPanel { get {return _videoPanel; } set { this._videoPanel = value; } }
        public Panel TimeLinePanel { get { return _timeLinePanel; } set { _timeLinePanel = value; } }
        public Label CurrentPlaybackSpeedLabel { get { return _currentPlaybackSpeedLabel; } set { this._currentPlaybackSpeedLabel = value; } }

        public event Action CameraSelected;
        public event Action CreatePrintScreen;
        public event Action CreateBookMarker;
        public event Action CreateComment;
        public event Action VolumeChanged;
        public event Action PlayButtonPressed;
        public event Action ChangeDirectionButtonPressed;
        public event Action SlowDownButtonPressed;
        public event Action SpeedUpButtonPressed;
        public event Action ResetSpeedButtonPressed;

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayButtonPressed();
        }

        private void SpeedUpButton_Click(object sender, EventArgs e)
        {
            SpeedUpButtonPressed();
        }

        private void SlowDownButton_Click(object sender, EventArgs e)
        {
            SlowDownButtonPressed();
        }

        private void ChangeDirectionButton_Click(object sender, EventArgs e)
        {
            ChangeDirectionButtonPressed();
        }

        private void SpeedResetButton_Click(object sender, EventArgs e)
        {
            ResetSpeedButtonPressed();
        }

        private void SaveVideoButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MakeScreenshotButton_Click(object sender, EventArgs e)
        {
            CreatePrintScreen();
        }

        private void SaveBookmarkButton_Click(object sender, EventArgs e)
        {
            CreateBookMarker();
        }
    }
}
