using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using VideoOS.Platform;
using System.Windows.Forms;

namespace Model
{
    class CameraManagerModel : ICameraManagerModel
    {
        private List<ICameraModel> _listCam;
        public List<ICameraModel> GetCameras()
        {
            List<Item> list = Configuration.Instance.GetItems();
            _listCam = new List<ICameraModel>();
            foreach (var i in list)
            {
                CheckChildren(i);
            }

            return _listCam;
        }

        private void CheckChildren(Item parent)
        {
            List<Item> itemsOnNextLevel = parent.GetChildren();
            if (itemsOnNextLevel != null)
            {
                foreach (Item item in itemsOnNextLevel)
                {
                    if (item.FQID.Kind == Kind.Camera && item.FQID.FolderType == FolderType.No)
                    {
                        _listCam.Add(c);
                    }
                    else
                    {
                        if (item.HasChildren != HasChildren.No)
                            CheckChildren(item);
                    }
                }
            }
        }

    }
}
