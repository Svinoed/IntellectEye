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
        public Panel VideoPanel { get { return _videoPanel; } }
        public event Action FullScreen;

        public SmallControl()
        {
            InitializeComponent();
            this.Anchor = ((AnchorStyles) ((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right)));
        }

        private void _videoPanel_Paint(object sender, PaintEventArgs e)
        {
            if (FullScreen != null)
            {
                FullScreen();
            }
        }

        public void ClearPanel()
        {
            _videoPanel.Controls.Clear();
        }
    }
}
