using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utils
{
    public class Group
    {
        public string Name { get; set; }
        public List<string> Cameras { get; set; }

        public Group()
        {
            Cameras = new List<string>();
        }

    }
}
