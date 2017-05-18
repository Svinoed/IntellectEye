namespace View
{
    partial class LoginControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInButton = new System.Windows.Forms.Button();
            this.RememberPassCheck = new System.Windows.Forms.CheckBox();
            this.AutoLoginCheck = new System.Windows.Forms.CheckBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(110, 215);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RememberPassCheck
            // 
            this.RememberPassCheck.AutoSize = true;
            this.RememberPassCheck.Location = new System.Drawing.Point(55, 192);
            this.RememberPassCheck.Name = "RememberPassCheck";
            this.RememberPassCheck.Size = new System.Drawing.Size(121, 17);
            this.RememberPassCheck.TabIndex = 1;
            this.RememberPassCheck.Text = "Запомнить пароль";
            this.RememberPassCheck.UseVisualStyleBackColor = true;
            this.RememberPassCheck.CheckedChanged += new System.EventHandler(this.RememberPassCheck_CheckedChanged);
            // 
            // AutoLoginCheck
            // 
            this.AutoLoginCheck.AutoSize = true;
            this.AutoLoginCheck.Location = new System.Drawing.Point(169, 192);
            this.AutoLoginCheck.Name = "AutoLoginCheck";
            this.AutoLoginCheck.Size = new System.Drawing.Size(73, 17);
            this.AutoLoginCheck.TabIndex = 2;
            this.AutoLoginCheck.Text = "Автовход";
            this.AutoLoginCheck.UseVisualStyleBackColor = true;
            this.AutoLoginCheck.CheckedChanged += new System.EventHandler(this.AutoLoginCheck_CheckedChanged);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(55, 35);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(186, 20);
            this.ServerTextBox.TabIndex = 3;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(55, 76);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(185, 20);
            this.UserTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(55, 115);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(187, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(52, 19);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(86, 13);
            this.AdressLabel.TabIndex = 6;
            this.AdressLabel.Text = "Адрес сервера:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(52, 60);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(83, 13);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Пользователь:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(52, 99);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(55, 146);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(0, 13);
            this.NotificationLabel.TabIndex = 9;

            this.SuspendLayout();
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.AutoLoginCheck);
            this.Controls.Add(this.RememberPassCheck);
            this.Controls.Add(this.LogInButton);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(320, 254);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.CheckBox RememberPassCheck;
        private System.Windows.Forms.CheckBox AutoLoginCheck;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NotificationLabel;

    }
}
