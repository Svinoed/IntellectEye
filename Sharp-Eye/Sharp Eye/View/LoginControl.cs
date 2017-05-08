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
            this.AutoLoginCheck.Checked = Properties.Settings.Default.AutoLaunch;
            this.RememberPassCheck.Checked = Properties.Settings.Default.RememberPassword;
            if(Properties.Settings.Default.AutoLaunch)
            {
                this.Server = Properties.Settings.Default.ServerURL;
                this.UserName = Properties.Settings.Default.Username;
                this.Password = Properties.Settings.Default.ConnectionPassword;
                Login();
            }
        }

        public string Server { get { return _server; } set { this._server = value; } }
        public string UserName { get { return _userName; } set { this._userName = value; } }
        public string Password { get { return _password; } set { this._password = value; } }
        public bool RememberPassword { get { return _rememberPassword; } set { this._rememberPassword = value; } }
        public bool AutoLogin { get { return _autoLogin; } set { this._autoLogin = value; } }

        private string _server;
        private string _userName;
        private string _password;
        private bool _rememberPassword;
        private bool _autoLogin;
        public event Action Login;

        public void Close()
        {
            Properties.Settings.Default.Save();//Сохранение настроек при закрытии контрола или формы
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
            if (_rememberPassword)
                Properties.Settings.Default.ConnectionPassword = Password;
            if(_autoLogin)
            {
                Properties.Settings.Default.ServerURL = Server;
                Properties.Settings.Default.Username = UserName;
                Properties.Settings.Default.ConnectionPassword = Password;
            }
            Login();
        }

        public ILoginView GetView()
        {
            return this;
        }

        private void RememberPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberPassword = RememberPassCheck.Checked;
            _rememberPassword = RememberPassCheck.Checked;
        }

        private void AutoLoginCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoLaunch = AutoLoginCheck.Checked;
            _autoLogin = AutoLoginCheck.Checked;
        }


    }
}
