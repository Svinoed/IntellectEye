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
            this.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)
                           | AnchorStyles.Left) | AnchorStyles.Right;
        }

        public void ClearPanel()
        {
            videoPanel.Controls.Clear();
        }

    }
}
