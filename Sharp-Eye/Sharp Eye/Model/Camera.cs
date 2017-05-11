using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using VideoOS.Platform;

namespace Model
{
    class Camera : ICameraModel
    {
        private dynamic _id;
        private string _name;
        private dynamic _micId = null;
        public object Id { get { return this._id; } set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }
        public dynamic MicrophoneId { get => this._micId; set => this._micId = value; }

        public Camera(FQID id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public Camera(FQID id, string name, FQID micId)
        {
            this._id = id;
            this._name = name;
            this._micId = micId;
        } 
    }
}
