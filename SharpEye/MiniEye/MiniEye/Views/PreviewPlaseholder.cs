using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEye.Views
{
    public partial class PreviewPlaseholder : UserControl
    {
        public Panel _VideoPanel { get { return this.panel; } }
        public PreviewPlaseholder()
        {
            InitializeComponent();
        }
    }
}
