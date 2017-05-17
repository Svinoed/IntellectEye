using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IPrintScreenModel
    {
        bool CreateScreen(DateTime dateTime, ICameraModel camera, string directory, string fileName);
    }
}
