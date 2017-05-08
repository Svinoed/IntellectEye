using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    interface IPrintScreenService
    {
        void CreatePrintScreen(DateTime dateTime, string fileName);
    }
}
