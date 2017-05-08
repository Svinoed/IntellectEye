using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public class Class1
    {
        static void Main()
        {
            Form f = new Form();
            f.Height = 600;
            f.Width = 900;
            ActiveXComponent ax = new ActiveXComponent();
            ax.Dock = DockStyle.Fill;
            f.Controls.Add(ax);
            Application.Run(f);
        }
    }
}
