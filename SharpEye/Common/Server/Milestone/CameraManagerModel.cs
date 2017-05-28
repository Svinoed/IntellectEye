using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using VideoOS.Platform;
using System.Windows.Forms;
using System.ComponentModel.Composition;

namespace Model
{
    [Export(typeof(ICameraManagerModel))]
    public class CameraManagerModel : ICameraManagerModel
    {
        private List<ICameraModel> _listCam;

        public ICameraModel GetCamera(dynamic id)
        {
            FQID fqid = (FQID) id;
            foreach (var c in _listCam) {
                FQID camId = (FQID) c.Id;
                if (camId.Equals(fqid))
                {
                    return c;
                }
            }
            return null;
        }

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
                        ICameraModel c;
                        FQID relatedFQID = GetRelatedMicrophone(item.GetRelated());
                        if (relatedFQID != null)
                        {
                            c = new Camera(item.FQID, item.Name, relatedFQID);
                        }
                        else
                        {
                            c = new Camera(item.FQID, item.Name);
                        }

                        c.IsPtz = item.Properties.ContainsKey("PTZ") 
                                && string.Compare(item.Properties["PTZ"], "Yes", true) == 0;

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

        private FQID GetRelatedMicrophone(List<Item> relatedItems)
        {
            foreach (Item item in relatedItems)
            {
                if (item.FQID.Kind == Kind.Microphone)
                {
                    return item.FQID;
                }
            }

            return null;
        }

    }
}
