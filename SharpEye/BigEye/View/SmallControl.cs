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
    public partial class SmallControl : UserControl, ISmallView
    {
        public Panel VideoPanel { get { return videoPanel; } }
        public event Action FullScreen;

        public SmallControl()
        {
            InitializeComponent();
            this.Anchor = ((AnchorStyles) ((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right)));
        }

        private void _videoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ClearPanel()
        {
            videoPanel.Controls.Clear();
        }

        private void videoPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            this.videoPanel.BringToFront();
            foreach(Control c in videoPanel.Controls)
            {
                c.SendToBack();
            }
        }

        private void videoPanel_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Panel");
        }

        private void SmallControl_Click(object sender, EventArgs e)
        {
            FullScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullScreen();
        }

        private void videoPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Panel");
        }
    }
}
