using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;
using Contract;

namespace Presenter.Interfaces
{
    interface IVideoPresenter
    {
        ICameraModel Camera { set; get; } 
        IVideoView GetView();
    }
}
