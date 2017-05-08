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
        private Object _id;
        private string _name;
        public object Id { get { return this._id; } set { this._id = value; } }
        public string Name { get { return this._name; } set { this._name = value; } }

        public Camera(FQID id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
}
