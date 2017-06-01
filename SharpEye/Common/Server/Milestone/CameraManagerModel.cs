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
            FQID fqid = id;
            return _listCam.Find(c => c.Id == fqid);
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
                        FQID relatedFQID = GetRelatedMic(item.GetRelated());
                        if (relatedFQID != null)
                        {
                            c = new Camera(item.FQID, item.Name, relatedFQID);
                        }
                        else
                        {
                            c = new Camera(item.FQID, item.Name);
                        }
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

        private FQID GetRelatedMic(List<Item> relatedItems)
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
