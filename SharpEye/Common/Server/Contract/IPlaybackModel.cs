using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    public interface IPlaybackModel : IVideoModel
    {
        void SetVideoFragmentForPlayback(DateTime startTime);

        void SetVideoStreamInPanelAtTime(ICameraModel camera, Panel videoPanel, DateTime initialTime);

        void SetVideoStreamInPanelFromFileAtTime(string filename, Panel panel, DateTime initialTime);

        void SetVideoStreamInPanelFromFolderAtTime(string pathToFolder, Panel panel, DateTime initialTime);

        event Action SpeedChanged;

        //void chooseCameraManually(Panel videoPanel); Тестовые функции,описание в модели SDK

        ICameraModel chooseCameraManually();
        double PlaybackSpeed { get; set; }
        ProgressBar TimeLine { get; set; }

        bool SkipGaps { get; set; }


        void Play();
        void SlowDown();
        void SpeedUp();
        void ChangeDirection();
        void ResetSpeed();
    }
}
