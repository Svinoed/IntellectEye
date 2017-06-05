using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Interfaces;

namespace View
{
    public partial class TEMPORARYSearchVideo : Form, ISmallSearchView
    {
        private Dictionary<dynamic, string> _cameras;

        public Dictionary<dynamic, string> Cameras
        {
            get { return _cameras; }
            set
            {
                this._cameras = value;
                foreach (var c in _cameras)
                {
                    ListViewItem cur = new ListViewItem(c.Value);
                    cur.Tag = c.Key;
                    this.camListView.Items.Add(cur);
                }
                this.Show();
            }
        }

        public DateTimePicker StartTimePicker { get { return this.startTimePicker; } }

        public DateTimePicker EndTimePicker { get { return this.endTimePicker; } }

        public ListView CamerasListView { get { return this.camListView; } }

        public event Action GetCameras;
        public event Action CreatePresenter;
        public TEMPORARYSearchVideo()
        {
            InitializeComponent();
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            CreatePresenter();
        }

        private void camSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            camListView.Items.Clear();
            foreach (var c in _cameras)
            {
                if (c.Value.ToString().StartsWith(camSearchTextBox.Text))
                {
                    ListViewItem item = new ListViewItem(c.Value);
                    item.Tag = c.Key;
                    camListView.Items.Add(item);
                }
            }
        }
        private void GetCameraList()
        {
            //GetCameras?.Invoke();
        }

        
    }
}
