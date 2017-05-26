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
        void play();

        void speedUp();

        void slowDown();

        void changeDirection();

        void resetSpeed();

        void updateSpeed();

    }
}
