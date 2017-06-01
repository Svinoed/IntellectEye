using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;

namespace Presenter.Interfaces
{
    public interface ISmallVideoPresenter
    {
        ICameraModel Camera { get; set; }
        event Action<ICameraModel> FullScreen;
        ISmallView GetView();
    }
}
