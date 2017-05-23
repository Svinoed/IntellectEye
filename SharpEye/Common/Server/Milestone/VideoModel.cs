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

        public VideoModel()
        {
        }

        public void SetVideoStreamInPanel(ICameraModel camera, Panel panel)
        {
            
            _imageViewer = ClientControl.Instance.GenerateImageViewerControl();
            _imageViewer.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(_imageViewer);
            _imageViewer.CameraFQID = camera.Id;
            _imageViewer.EnableVisibleHeader = true;
            _imageViewer.EnableVisibleLiveIndicator = EnvironmentManager.Instance.Mode == Mode.ClientLive;
            _imageViewer.EnableMousePtzEmbeddedHandler = true;
            _imageViewer.MaintainImageAspectRatio = true;
            _imageViewer.SetVideoQuality(0, 1);
            //_imageViewer.ImageOrPaintInfoChanged += ImageOrPaintChangedHandler;
            _imageViewer.EnableRecordedImageDisplayedEvent = true;
            _imageViewer.EnableVisibleTimeStamp = true;
            _imageViewer.Initialize();
            _imageViewer.Connect();
            _imageViewer.Selected = true;
            _imageViewer.EnableDigitalZoom = true;
           
        }
    }
}
