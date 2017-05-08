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
            List<Item> itemsOnNextLevel = parent.GetChildren(); // This causes the configuration Items to be loaded.
            if (itemsOnNextLevel != null)
            {
                foreach (Item item in itemsOnNextLevel)
                {
                    // If we find the camera we want, remember it and return with no further checks
                    // It must have Kind == Camera and it must not be a folder (It seems that camera folders have Kind == Camera)
                    if (item.FQID.Kind == Kind.Camera && item.FQID.FolderType == FolderType.No)
                    {
                        // Does the name match the camera name we are looking for? Here we accept a non-perfect match
                        Camera c = new Camera(item.FQID, item.Name);
                        _listCam.Add(c);
                    }
                    else
                    {
                        // We have not found our camera, so check the next level of Items in case this Item has children.
                        if (item.HasChildren != HasChildren.No)
                            CheckChildren(item);
                    }
                }
            }
        }

    }
}
