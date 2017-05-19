namespace MiniEye.Views
{
    partial class CameraSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CameraNameTextBox = new System.Windows.Forms.TextBox();
            this.ServerAddressTextBox = new System.Windows.Forms.TextBox();
            this.AuthTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DefaultCameraComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CheckConnectionButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя камеры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес сервера:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип авторизации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Камера по умолчанию:";
            // 
            // CameraNameTextBox
            // 
            this.CameraNameTextBox.Location = new System.Drawing.Point(141, 12);
            this.CameraNameTextBox.Name = "CameraNameTextBox";
            this.CameraNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.CameraNameTextBox.TabIndex = 6;
            this.CameraNameTextBox.TextChanged += new System.EventHandler(this.CameraNameTextBox_TextChanged);
            // 
            // ServerAddressTextBox
            // 
            this.ServerAddressTextBox.Location = new System.Drawing.Point(141, 38);
            this.ServerAddressTextBox.Name = "ServerAddressTextBox";
            this.ServerAddressTextBox.Size = new System.Drawing.Size(156, 20);
            this.ServerAddressTextBox.TabIndex = 7;
            this.ServerAddressTextBox.TextChanged += new System.EventHandler(this.ServerAddressTextBox_TextChanged);
            // 
            // AuthTypeComboBox
            // 
            this.AuthTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthTypeComboBox.FormattingEnabled = true;
            this.AuthTypeComboBox.Location = new System.Drawing.Point(141, 62);
            this.AuthTypeComboBox.Name = "AuthTypeComboBox";
            this.AuthTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.AuthTypeComboBox.TabIndex = 8;
            this.AuthTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthTypeComboBox_SelectedIndexChanged);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(141, 89);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(156, 20);
            this.LoginTextBox.TabIndex = 9;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(141, 115);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(156, 20);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // DefaultCameraComboBox
            // 
            this.DefaultCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultCameraComboBox.FormattingEnabled = true;
            this.DefaultCameraComboBox.Location = new System.Drawing.Point(141, 141);
            this.DefaultCameraComboBox.Name = "DefaultCameraComboBox";
            this.DefaultCameraComboBox.Size = new System.Drawing.Size(156, 21);
            this.DefaultCameraComboBox.TabIndex = 11;
            this.DefaultCameraComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultCameraComboBox_SelectedIndexChanged);
            this.DefaultCameraComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DefaultCameraComboBox_MouseClick);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(141, 169);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 12;
            this.ApplyButton.Text = "Сохранить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(222, 169);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CheckConnectionButton
            // 
            this.CheckConnectionButton.Location = new System.Drawing.Point(15, 169);
            this.CheckConnectionButton.Name = "CheckConnectionButton";
            this.CheckConnectionButton.Size = new System.Drawing.Size(120, 23);
            this.CheckConnectionButton.TabIndex = 14;
            this.CheckConnectionButton.Text = "Соединение";
            this.CheckConnectionButton.UseVisualStyleBackColor = true;
            this.CheckConnectionButton.Click += new System.EventHandler(this.CheckConnectionButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 201);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(314, 22);
            this.statusStrip.TabIndex = 15;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // CameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 223);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.CheckConnectionButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.DefaultCameraComboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AuthTypeComboBox);
            this.Controls.Add(this.ServerAddressTextBox);
            this.Controls.Add(this.CameraNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CameraSettings";
            this.Text = "Настройки камеры";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CameraNameTextBox;
        private System.Windows.Forms.TextBox ServerAddressTextBox;
        private System.Windows.Forms.ComboBox AuthTypeComboBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox DefaultCameraComboBox;
        private System.Windows.Forms.Button ApplyButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CheckConnectionButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}