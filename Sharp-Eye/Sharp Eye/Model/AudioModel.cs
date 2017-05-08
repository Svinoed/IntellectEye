using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using System.Windows.Forms;
using VideoOS.Platform.Client;
using VideoOS.Platform;
using VideoOS.Platform.UI;

namespace Model
{
    class AudioModel : IAudioModel
    {
        //Нужно ли оно здесь?
        private AudioPlayerControl _audioPlayerControl;
        private Item _relatedMicrophone;
        //
        public AudioModel()
        {

        }
        public void SetAudioStreamInPanelDefault(ICameraModel camera, Panel panel)
        { 
            _relatedMicrophone = null;
            Item CameraItem = new Item((FQID)camera.Id, camera.Name);
            List<Item> related = CameraItem.GetRelated();
            if (related != null)
            {
                foreach (Item item in related)
                {
                    MessageBox.Show(item.Name);
                    if (item.FQID.Kind == Kind.Microphone)
                    {
                        //checkBoxAudio.Enabled = true;   //Чеки для mute checkbox
                        //checkBoxAudio.Checked = true;
                        _relatedMicrophone = item;
                        _audioPlayerControl.MicrophoneFQID = item.FQID;
                        MessageBox.Show(item.Name);
                        _audioPlayerControl.Initialize();
                        _audioPlayerControl.Connect();
                        if (EnvironmentManager.Instance.Mode == Mode.ClientLive) //Не совсем понимаю, что делает эта проверка, кажется проверяет идёт ли Live или запись
                        {
                            _audioPlayerControl.StartLive();
                            panel.Controls.Add(_audioPlayerControl);//Допустим, что этот контрол будет жить на той же форме
                        }
                        else
                        {
                            _audioPlayerControl.Disconnect();
                            throw new NotImplementedException();
                            //Вывести ошибку, не тот режим работы, куда выводить, как определять режим записи?
                        }
                    }
                }
            }
            else
            {
                throw new NotImplementedException();//Вывести, что у камеры нет микрофонов, куда выводить?
            }
        }
    }
}
