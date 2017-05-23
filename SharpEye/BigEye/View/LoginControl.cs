using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Interfaces;

namespace View
{
    /// <summary>
    /// Объект этого клаксса взаимодействует с пользоватлем. 
    /// Выполняет проверку введенных значений пользователем, 
    /// выводит сообщение в случае возникновения ошибки и т.д. 
    /// </summary>

    public partial class LoginControl : UserControl, ILoginView
    {
        public LoginControl()
        {
            InitializeComponent();

            this.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            PasswordTextBox.PasswordChar = '*';
            progressBar1.ForeColor = Color.Aqua;

            /* //Для круглой кнопки
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(1, 1, button1.Width, button1.Height);
            Region rgn = new Region(path);
            button1.Region = rgn;
            */
        }

        public string Server { get; set; } 
        public string UserName { get; set; } 
        public string Password { get; set; }
        public bool RememberPassword { get; set; }
        public bool AutoLogin { get; set; }

        public event Action Login;

        public void Close()
        {
            //Properties.Settings.Default.Save();//Сохранение настроек при закрытии контрола или формы
            throw new NotImplementedException();
        }

        public void ShowConError(string message)
        {
            this.NotificationLabel.Text = message;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Server = ServerTextBox.Text;
            UserName = UserTextBox.Text;
            Password = PasswordTextBox.Text;

            Login();
        }


        public ILoginView GetView()
        {
            return this;
        }

        private void RememberPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.RememberPassword = RememberPassCheck.Checked;
            RememberPassword = RememberPassCheck.Checked;
        }

        private void AutoLoginCheck_CheckedChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.AutoLaunch = AutoLoginCheck.Checked;
            AutoLogin = AutoLoginCheck.Checked;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                PasswordTextBox.PasswordChar = '\0';
                button1.ImageIndex = 1;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                button1.ImageIndex = 0;
            }
        }
    }
}