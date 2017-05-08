using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
    /// <summary>
    /// Определяет 
    /// </summary>

    interface IBookMarkerService
    {
        void CreateMarker(string id, DateTime dateTime);
    }
}
