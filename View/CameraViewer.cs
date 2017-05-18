using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CameraViewer : UserControl
    {
        public CameraViewer()
        {
            InitializeComponent();
            this.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            this.Dock = DockStyle.Fill;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
