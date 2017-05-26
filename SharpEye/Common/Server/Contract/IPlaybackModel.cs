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
        void SetAndEnableTimeline(Panel timeLinePanel);

        void SetVideoStreamInPanelFromFile(string filename, Panel panel);

        void SetVideoStreamInPanelFromFolder(string pathToFolder, Panel panel);

        event Action SpeedChanged;

        //void chooseCameraManually(Panel videoPanel); Тестовые функции,описание в модели SDK

        ICameraModel chooseCameraManually();
        double PlaybackSpeed { get; set; }

        bool SkipGaps { get; set; }

        void Play();
        void SlowDown();
        void SpeedUp();
        void ChangeDirection();
        void ResetSpeed();
    }
}
