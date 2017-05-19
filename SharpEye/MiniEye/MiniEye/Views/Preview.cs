using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEye.Views
{
    public partial class Preview : Form
    {
        ICameraData _Data;
        public Preview(ICameraData data)
        {
            _Data = data;
            InitializeComponent();
            UpdataFromModel();
        }
        /// <summary>
        /// Установить новые настройки для подключения 
        /// </summary>
        public void SetSettings(ICameraData data)
        {
            _Data = data;
            UpdataFromModel();

        }
        /// <summary>
        /// Обновление графического интерфейса из модели и переподключение
        /// </summary>
        private void UpdataFromModel()
        {
            this.Text = _Data.CameraName;
        }
        /// <summary>
        /// Установить картинку в окне
        /// </summary>
        public void SetPicture(Bitmap picture)
        {

            if (picture.Width != pictureBox.Width || picture.Height != pictureBox.Height)
                pictureBox.Image = new Bitmap(picture, pictureBox.Size);
            else
                pictureBox.Image = picture;
        }
    }
}
