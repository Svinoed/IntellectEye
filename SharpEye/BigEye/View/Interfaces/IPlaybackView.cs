using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Interfaces
{
    public interface IPlaybackView : IVideoView
    {
        ProgressBar TimeLine { get ; set; }
        Label CurrentPlaybackSpeedLabel { get; set; }

        event Action PlayButtonPressed;
        event Action ChangeDirectionButtonPressed;
        event Action SlowDownButtonPressed;
        event Action SpeedUpButtonPressed;
        event Action ResetSpeedButtonPressed;
    }
}
