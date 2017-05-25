using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.Client;

namespace MiniEye.Views
{
    public partial class Preview : Form
    {
        ICameraData _Data;
        public new event EventHandler OnResize;
        public event Action OnSettingsChange; 

        public Preview(ICameraData data)
        {
            _Data = data;
            InitializeComponent();
            this.Text = data.CameraName;
        }

        private void Preview_SizeChanged(object sender, EventArgs e)
        {
            OnResize(sender, e);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OnSettingsChange();
        }
    }
}
