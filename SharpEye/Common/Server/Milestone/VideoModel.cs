using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using VideoOS.Platform.Client;
using VideoOS.Platform;
using VideoOS.Platform.Messaging;
using System.Diagnostics;
using System.Drawing;
using VideoOS.Platform.UI;
using System.ComponentModel.Composition;

namespace Model
{
    [Export(typeof(IVideoModel))]
    public class VideoModel : IVideoModel
    {
        ImageViewerControl _imageViewer;

        public void Disconnect()
        {
            try
            {
                if (_imageViewer.CameraFQID != null && _imageViewer != null) 
                {
                    _imageViewer.Disconnect();
                    _imageViewer.Close();
                }
            }
            catch(NullReferenceException e)
            {
                Debug.WriteLine(_imageViewer.CameraFQID.ToString() + " " + e.Message);
            }
            
        }

        public void PTZDefault()
        {

           _imageViewer.PtzCenter(0, 0, 0, 0, 0);
        }

        public void SetVideoStreamInPanel(ICameraModel camera, Panel panel)
        {
            SetVideoStreamInPanel(camera, panel, null);
        }
        public void SetVideoStreamInPanel(ICameraModel camera, Panel panel, EventHandler handler)
        {
             panel.Controls.Clear();
            _imageViewer = ClientControl.Instance.GenerateImageViewerControl();
            _imageViewer.Dock = DockStyle.Fill;
             panel.Controls.Add(_imageViewer);
            _imageViewer.CameraFQID = camera.Id;
            _imageViewer.EnableVisibleHeader = false;
            _imageViewer.EnableVisibleLiveIndicator = EnvironmentManager.Instance.Mode == Mode.ClientLive;
            _imageViewer.EnableMousePtzEmbeddedHandler = false;
            _imageViewer.MaintainImageAspectRatio = false;
            _imageViewer.SetVideoQuality(0, 1);
          //_imageViewer.ImageOrPaintInfoChanged += ImageOrPaintChangedHandler;
            _imageViewer.EnableRecordedImageDisplayedEvent = false;
            _imageViewer.EnableVisibleTimeStamp = false;
            _imageViewer.Initialize();
            _imageViewer.Connect();
            _imageViewer.Selected = false;
            _imageViewer.EnableMouseControlledPtz = false;
            if (handler != null)
            {
                _imageViewer.DoubleClickEvent += handler;
            }
        }
    }
}
