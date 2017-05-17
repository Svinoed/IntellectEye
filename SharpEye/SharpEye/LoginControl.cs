using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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

        private void ServerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                UserTextBox.Select();
            }
        }

        private void UserTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                PasswordTextBox.Select();
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                LogInButton.PerformClick();
            }
        }
    }
}
