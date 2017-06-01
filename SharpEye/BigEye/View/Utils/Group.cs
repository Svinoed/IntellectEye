using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utils
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<dynamic, string> Cameras { get; set; }

        public Group()
        {
            Init();
        }

        public Group(string name)
        {
            Init();
            this.Name = name;
        }

        private void Init()
        {
            this.Id = Guid.NewGuid();
            this.Cameras = new Dictionary<dynamic, string>();
        }
        
    }
}
