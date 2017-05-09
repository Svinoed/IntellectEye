using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface ICameraModel
    {
        dynamic Id { set; get; }
        string Name { set; get; }
    }
}
