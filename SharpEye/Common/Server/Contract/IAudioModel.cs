using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    public interface IAudioModel
    {
        void SetAudioStreamInPanel(ICameraModel camera, Panel panel);
        void Disconnect();
    }
}
