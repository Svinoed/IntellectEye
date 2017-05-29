using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.Windows.Forms;
using VideoOS.Platform.Client;
using VideoOS.Platform;
using VideoOS.Platform.UI;

namespace Model
{
    [Export(typeof(IAudioModel))]
    public class AudioModel : IAudioModel
    {
        private readonly AudioPlayerControl _audioPlayerControl;
        
        public AudioModel()
        {
            _audioPlayerControl = ClientControl.Instance.GenerateAudioPlayerControl();
            _audioPlayerControl.ConnectResponseEvent += ConnectResponseEvent;
        }

        public void SetAudioStreamInPanel(ICameraModel camera, Panel panel)
        { 
            panel.Controls.Add(_audioPlayerControl);
            _audioPlayerControl.MicrophoneFQID = (FQID)camera.MicrophoneId;
            _audioPlayerControl.Initialize();
            _audioPlayerControl.Connect();
        }

        public void Disconnect()
        {
            if (_audioPlayerControl.MicrophoneFQID != null)
            {
                _audioPlayerControl.Disconnect();
            }
            _audioPlayerControl.Close();
        }

        private void ConnectResponseEvent(object sender, ConnectResponseEventEventArgs e)
        {
          _audioPlayerControl.StartLive();
        }
    } 
}
