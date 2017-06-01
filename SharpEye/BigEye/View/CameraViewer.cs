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
        public Panel VideoPanel { get { return videoPanel; } }
       
        #region Move fields
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
        #endregion

        public event Action VolumeChanged;

        private readonly SaveFileDialog _saveFileDialog;
        private ProgressBar _progressBar;
        private Form _progressForm;

        public CameraViewer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _saveFileDialog = new SaveFileDialog();
        }

        public void SaveImage(byte[] img, string format)
        {
            this.Invoke((MethodInvoker) delegate
            {
                _saveFileDialog.Filter = "Image files (*" + format + ")" + "|*" + format;
                screenshotButton.Enabled = true;
                if (_saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = _saveFileDialog.FileName;
                File.WriteAllBytes(fileName, img);
                MessageBox.Show("Файл сохранен!");
            });

        }

        public void ShowMessage(string message)
        {
            this.Invoke((MethodInvoker) delegate
            {
                screenshotButton.Enabled = true;
                MessageBox.Show(message);
            });
        }

        public void ShowProgressBar()
        {
            //_progressBar = new ProgressBar
            //{
            //    Minimum = 0,
            //    Maximum = 100,
            //    Style = ProgressBarStyle.Blocks
            //};
            //_progressForm = new Form();
            //_progressForm.Controls.Add(_progressBar);
            //_progressForm.ShowDialog();
        }

        public void HideProgressBar()
        {
            //_progressForm.Invoke((MethodInvoker) delegate 
            //{
            //    _progressForm.Close();
            //});
        }

        private void SetPtzControl(bool value)
        {
            upButton.Enabled = value;
            leftUpButton.Enabled = value;
            rightUpButton.Enabled = value;

            leftButton.Enabled = value;
            rightButton.Enabled = value;

            downButton.Enabled = value;
            leftDownButton.Enabled = value;
            rightDownButton.Enabled = value;

            resetButton.Enabled = value;
        }

        public void HidePtzControl()
        {
            SetPtzControl(false);
        }

        public void ShowPtzControl()
        {
            SetPtzControl(true);
        }

        public async Task SetValueProgressBar(float value)
        {
            //await Task.Run(() =>
            //{
            // _progressBar.Invoke((MethodInvoker) delegate
            //  {
            //    _progressBar.Value = (int) (value * 100);
            //  });
            //});
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
            screenshotButton.Enabled = false;
            CreatePrintScreen?.Invoke();
        }
    }
}
