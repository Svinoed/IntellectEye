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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.logInButton = new System.Windows.Forms.Button();
            this.RememberPassCheck = new System.Windows.Forms.CheckBox();
            this.AutoLoginCheck = new System.Windows.Forms.CheckBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.hideShowPassword = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logProgressBar = new System.Windows.Forms.ProgressBar();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(3, 3);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(69, 23);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Войти";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RememberPassCheck
            // 
            this.RememberPassCheck.AutoSize = true;
            this.RememberPassCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RememberPassCheck.ForeColor = System.Drawing.Color.White;
            this.RememberPassCheck.Location = new System.Drawing.Point(6, 130);
            this.RememberPassCheck.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.RememberPassCheck.Name = "RememberPassCheck";
            this.RememberPassCheck.Size = new System.Drawing.Size(118, 17);
            this.RememberPassCheck.TabIndex = 1;
            this.RememberPassCheck.Text = "Запомнить пароль";
            this.RememberPassCheck.UseVisualStyleBackColor = true;
            this.RememberPassCheck.CheckedChanged += new System.EventHandler(this.RememberPassCheck_CheckedChanged);
            // 
            // AutoLoginCheck
            // 
            this.AutoLoginCheck.AutoSize = true;
            this.AutoLoginCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoLoginCheck.ForeColor = System.Drawing.Color.White;
            this.AutoLoginCheck.Location = new System.Drawing.Point(6, 153);
            this.AutoLoginCheck.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.AutoLoginCheck.Name = "AutoLoginCheck";
            this.AutoLoginCheck.Size = new System.Drawing.Size(70, 17);
            this.AutoLoginCheck.TabIndex = 2;
            this.AutoLoginCheck.Text = "Автовход";
            this.AutoLoginCheck.UseVisualStyleBackColor = true;
            this.AutoLoginCheck.CheckedChanged += new System.EventHandler(this.AutoLoginCheck_CheckedChanged);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.BackColor = System.Drawing.Color.LightGray;
            this.ServerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerTextBox.Location = new System.Drawing.Point(6, 16);
            this.ServerTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ServerTextBox.TabIndex = 3;
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.LightGray;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextBox.Location = new System.Drawing.Point(6, 55);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(200, 20);
            this.UserTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(171, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.ForeColor = System.Drawing.Color.White;
            this.AdressLabel.Location = new System.Drawing.Point(6, 0);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(86, 13);
            this.AdressLabel.TabIndex = 6;
            this.AdressLabel.Text = "Адрес сервера:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(6, 39);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(83, 13);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Пользователь:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 78);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.ForeColor = System.Drawing.Color.White;
            this.notificationLabel.Location = new System.Drawing.Point(3, 241);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(0, 13);
            this.notificationLabel.TabIndex = 9;
            // 
            // hideShowPassword
            // 
            this.hideShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hideShowPassword.FlatAppearance.BorderSize = 0;
            this.hideShowPassword.ImageIndex = 0;
            this.hideShowPassword.ImageList = this.imageList1;
            this.hideShowPassword.Location = new System.Drawing.Point(180, 3);
            this.hideShowPassword.Name = "hideShowPassword";
            this.hideShowPassword.Size = new System.Drawing.Size(20, 20);
            this.hideShowPassword.TabIndex = 10;
            this.hideShowPassword.UseVisualStyleBackColor = true;
            this.hideShowPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.passwordVisibility.png");
            this.imageList1.Images.SetKeyName(1, "2.passwordVisibilityOff.png");
            this.imageList1.Images.SetKeyName(2, "ic_visibility_white_24dp_2x.png");
            this.imageList1.Images.SetKeyName(3, "ic_visibility_off_white_24dp_2x.png");
            // 
            // logProgressBar
            // 
            this.logProgressBar.Location = new System.Drawing.Point(3, 187);
            this.logProgressBar.Name = "logProgressBar";
            this.logProgressBar.Size = new System.Drawing.Size(358, 15);
            this.logProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.logProgressBar.TabIndex = 11;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(78, 3);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(69, 23);
            this.cancelbutton.TabIndex = 12;
            this.cancelbutton.Text = "Отменить";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.notificationLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.logProgressBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 303);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.AdressLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.UserTextBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.AutoLoginCheck, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.ServerTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.UserLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.RememberPassCheck, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.PasswordLabel, 0, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(217, 178);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.PasswordTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.hideShowPassword, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 94);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(203, 30);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Controls.Add(this.cancelbutton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.logInButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(107, 208);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(239, 259);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(364, 303);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.CheckBox RememberPassCheck;
        private System.Windows.Forms.CheckBox AutoLoginCheck;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Button hideShowPassword;
        private System.Windows.Forms.ProgressBar logProgressBar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
