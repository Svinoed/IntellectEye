using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Presenter.Interfaces
{
    interface IPlaybackPresenter : IVideoPresenter
    {
        void PickCameraFromFile(string filename);

        void PickCameraFromFolder(string folderPath);
        void Play();

        void SpeedUp();

        void SlowDown();

        void ChangeDirection();

        void ResetSpeed();

        void UpdateSpeed();

        DateTime InitialTime { get; set; }
    }
}
