using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
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

        private readonly SaveFileDialog _saveFileDialog;
        private readonly ProgressBar _progressBar;

        public CameraViewer()
        {
            InitializeComponent();
            //this.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            this.Dock = DockStyle.Fill;
            _saveFileDialog = new SaveFileDialog();
            _progressBar = new ProgressBar();
            _progressBar.Minimum = 0;
            _progressBar.Maximum = 100;
            //_progressBar.Style = ProgressBarStyle.Marquee;
            //_progressBar.PerformStep();
        }

        public void SaveImage(byte[] img, string format)
        {
            _saveFileDialog.Filter = "Image files (*" + format + ")" + "|*" + format;
            if (_saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = _saveFileDialog.FileName;
            File.WriteAllBytes(fileName, img);
            MessageBox.Show("Сохранен");
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowProgressBar()
        {
            
        }

        public void HideProgressBar()
        {
            _progressBar.Hide();
        }

        public void SetValueProgressBar(float value)
        {
            _progressBar.Value = (int) (value * 100);
        }

        #region Move
        private void upButton_Click(object sender, EventArgs e)
        {
            Up?.Invoke();
        }

        private void rightUpButton_Click(object sender, EventArgs e)
        {
            UpRight?.Invoke();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            Down?.Invoke();
        }

        private void leftUpButton_Click(object sender, EventArgs e)
        {
            UpLeft?.Invoke();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            ToRight?.Invoke();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            ToLeft?.Invoke();
        }

        private void leftDownButton_Click(object sender, EventArgs e)
        {
            DownLeft?.Invoke();
        }

        private void rightDownButton_Click(object sender, EventArgs e)
        {
            DownRight?.Invoke();
        }

        private void zoomMinusButton_Click(object sender, EventArgs e)
        {
            ZoomOut?.Invoke(0.1f);
        }

        private void zoomPlusButton_Click(object sender, EventArgs e)
        {
            ZoomIn?.Invoke(0.1f);
        }

        private void exitFullscreenButton_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Home?.Invoke();
        }
        #endregion

        private void screenshotButton_Click(object sender, EventArgs e)
        {
            CreatePrintScreen?.Invoke();
        }
    }
}
