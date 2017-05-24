using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CameraEditor : Form
    {
        public CameraEditor()
        {
            InitializeComponent();
            camEditorMainPanel.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            camEditorMainPanel.Dock = DockStyle.Fill;
            camPanel.Dock= DockStyle.Fill;
            camList.Dock = DockStyle.Fill;
        }
    }
}
