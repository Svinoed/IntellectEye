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

        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberPassword { get; set; }
        public bool AutoLogin { get; set; }

        public event Action Login;
        public event Action Cancel;

        public LoginControl()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            logProgressBar.ForeColor = Color.Aqua;
            logInButton.Enabled = true;
            notificationLabel.ForeColor = Color.Red;
            notificationLabel.Text = "";
        }

        public void ShowConError(string message)
        {
            this.BeginInvoke((Action) delegate
            {
                logInButton.Enabled = true;
                this.notificationLabel.Text = message;
            });
        }

        public void StartProgress()
        {
            this.BeginInvoke((Action) delegate
            {
                logInButton.Enabled = false;
                logProgressBar.Style = ProgressBarStyle.Marquee;
                logProgressBar.MarqueeAnimationSpeed = 30;
            });
        }

        public void StopProgress()
        {

          this.BeginInvoke((Action) delegate
            {
                logInButton.Enabled = true;
                logProgressBar.Style = ProgressBarStyle.Continuous;
                logProgressBar.MarqueeAnimationSpeed = 0;
            });
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            notificationLabel.Text = "";
            Server = ServerTextBox.Text;
            UserName = UserTextBox.Text;
            Password = PasswordTextBox.Text;
            Login?.Invoke();
        }


        public ILoginView GetView()
        {
            return this;
        }

        private void RememberPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            RememberPassword = RememberPassCheck.Checked;
        }

        private void AutoLoginCheck_CheckedChanged(object sender, EventArgs e)
        { 
            AutoLogin = AutoLoginCheck.Checked;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                PasswordTextBox.PasswordChar = '\0';
                hideShowPassword.ImageIndex = 1;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                hideShowPassword.ImageIndex = 0;
            }
        }

        private void ServerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                UserTextBox.Select();
        }

        private void UserTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                PasswordTextBox.Select();
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                logInButton.PerformClick();
        }

        // Комментарий для тестового коммита
    }
}