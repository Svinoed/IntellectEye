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
        void SetAudioStreamInPanelDefault(ICameraModel camera, Panel panel);//Нужно добавлять в панель или прикреплять к камере?
    }
}
