using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Interfaces
{
    public interface ISmallView
    {
        Panel VideoPanel { get; }
        event Action FullScreen;
    }
}
