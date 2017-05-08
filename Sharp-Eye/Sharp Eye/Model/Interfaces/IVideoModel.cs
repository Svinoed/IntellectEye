using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.Interfaces
{
    public interface IVideoModel
    {
        void SetVideoStreamInPanel(ICameraModel camera, Panel panel);
    }
}
