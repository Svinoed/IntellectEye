using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using VideoOS.Platform;
using System.ComponentModel.Composition;

namespace Model
{
    [Export(typeof(ICameraModel))]
    public class Camera : ICameraModel
    {
        public object Id { get; set; }
        public string Name { get; set; }
        public dynamic MicrophoneId { get; set; }
        public bool IsPtz { set; get; }

        public Camera(FQID id, string name)
        {
            Id = id;
            Name = name;
        }

        public Camera(FQID id, string name, FQID micId)
        {
            Id = id;
            Name = name;
            MicrophoneId = micId;
        } 
    }
}
