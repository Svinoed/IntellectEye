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
using VideoOS.Platform;
using VideoOS.Platform.Client;

namespace MiniEye.Views
{
    public partial class Preview : Form
    {
        ICameraData _Data;
        /// <summary>
        /// Действие при изменении формы
        /// </summary>
        public new event EventHandler OnResize;
        /// <summary>
        /// Действие при нажатии на кнопку изменения настроек
        /// </summary>
        public event Action OnSettingsChange;
        /// <summary>
        /// Действие при закрытии формы. Необходимо для освобождения ресурсов
        /// </summary>
        public event Action OnClose;
        public Panel _VideoPanel;

        public Preview(ICameraData data)
        {
            _Data = data;
            InitializeComponent();
            this.Text = data.CameraName;
            PreviewPlaceholder placeholder = new PreviewPlaceholder();
            placeholder.Dock = DockStyle.Fill;
            this._VideoPanel = placeholder._VideoPanel;
            this.Controls.Add(placeholder);
        }

        private void Preview_SizeChanged(object sender, EventArgs e)
        {
            //При вызове изменения размеров выполняется проверка на null
            OnResize?.Invoke(sender, e);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //При изменении настроек выполняется проверка на null
            OnSettingsChange?.Invoke();
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            //перед вызовом выполняется проверка на null
            OnClose?.Invoke();
        }
    }
}
