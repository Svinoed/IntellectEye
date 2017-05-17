namespace View
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.livePage = new System.Windows.Forms.TabPage();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sequenceScreenplayEditor = new System.Windows.Forms.Button();
            this.groupEditor = new System.Windows.Forms.Button();
            this.cameraEditor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playbackPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.livePage.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.livePage);
            this.tabControl1.Controls.Add(this.playbackPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // livePage
            // 
            this.livePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.livePage.Controls.Add(this.menuPanel);
            this.livePage.Controls.Add(this.searchTextBox);
            this.livePage.Controls.Add(this.groupPanel);
            this.livePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livePage.Location = new System.Drawing.Point(4, 25);
            this.livePage.Name = "livePage";
            this.livePage.Padding = new System.Windows.Forms.Padding(3);
            this.livePage.Size = new System.Drawing.Size(846, 416);
            this.livePage.TabIndex = 0;
            this.livePage.Text = "Наблюдение";
            this.livePage.UseVisualStyleBackColor = true;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.sequenceScreenplayEditor);
            this.menuPanel.Controls.Add(this.groupEditor);
            this.menuPanel.Controls.Add(this.cameraEditor);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Location = new System.Drawing.Point(725, 356);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(119, 50);
            this.menuPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(90, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sequenceScreenplayEditor
            // 
            this.sequenceScreenplayEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceScreenplayEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sequenceScreenplayEditor.BackgroundImage")));
            this.sequenceScreenplayEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sequenceScreenplayEditor.Location = new System.Drawing.Point(62, 24);
            this.sequenceScreenplayEditor.Name = "sequenceScreenplayEditor";
            this.sequenceScreenplayEditor.Size = new System.Drawing.Size(26, 22);
            this.sequenceScreenplayEditor.TabIndex = 3;
            this.sequenceScreenplayEditor.UseVisualStyleBackColor = true;
            this.sequenceScreenplayEditor.Click += new System.EventHandler(this.sequenceScreenplayEditor_Click);
            // 
            // groupEditor
            // 
            this.groupEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupEditor.BackgroundImage")));
            this.groupEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupEditor.Location = new System.Drawing.Point(33, 24);
            this.groupEditor.Name = "groupEditor";
            this.groupEditor.Size = new System.Drawing.Size(26, 22);
            this.groupEditor.TabIndex = 2;
            this.groupEditor.UseVisualStyleBackColor = true;
            this.groupEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupEditor_MouseClick);
            // 
            // cameraEditor
            // 
            this.cameraEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cameraEditor.BackgroundImage")));
            this.cameraEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraEditor.Location = new System.Drawing.Point(4, 24);
            this.cameraEditor.Name = "cameraEditor";
            this.cameraEditor.Size = new System.Drawing.Size(26, 22);
            this.cameraEditor.TabIndex = 1;
            this.cameraEditor.UseVisualStyleBackColor = true;
            this.cameraEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cameraEditor_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchTextBox.Location = new System.Drawing.Point(725, -2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(119, 26);
            this.searchTextBox.TabIndex = 5;
            // 
            // groupPanel
            // 
            this.groupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel.Controls.Add(this.listView1);
            this.groupPanel.Location = new System.Drawing.Point(725, 21);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(121, 332);
            this.groupPanel.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // playbackPage
            // 
            this.playbackPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playbackPage.Location = new System.Drawing.Point(4, 25);
            this.playbackPage.Name = "playbackPage";
            this.playbackPage.Padding = new System.Windows.Forms.Padding(3);
            this.playbackPage.Size = new System.Drawing.Size(846, 416);
            this.playbackPage.TabIndex = 1;
            this.playbackPage.Text = "Воспроизведение";
            this.playbackPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.yellowBtn);
            this.groupBox1.Controls.Add(this.redBtn);
            this.groupBox1.Controls.Add(this.logBtn);
            this.groupBox1.Location = new System.Drawing.Point(4, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowBtn.BackgroundImage")));
            this.yellowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBtn.Location = new System.Drawing.Point(72, 15);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(24, 24);
            this.yellowBtn.TabIndex = 2;
            this.yellowBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redBtn.BackgroundImage")));
            this.redBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redBtn.Location = new System.Drawing.Point(42, 15);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(24, 24);
            this.redBtn.TabIndex = 1;
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            this.logBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logBtn.BackgroundImage")));
            this.logBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logBtn.Location = new System.Drawing.Point(12, 15);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(24, 24);
            this.logBtn.TabIndex = 0;
            this.logBtn.UseVisualStyleBackColor = true;
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingBtn.BackgroundImage")));
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.Location = new System.Drawing.Point(89, 2);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(26, 22);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.UseVisualStyleBackColor = true;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpBtn.BackgroundImage")));
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBtn.Location = new System.Drawing.Point(57, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(26, 22);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.settingBtn);
            this.panel1.Location = new System.Drawing.Point(737, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 27);
            this.panel1.TabIndex = 6;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(857, 512);
            this.tabControl1.ResumeLayout(false);
            this.livePage.ResumeLayout(false);
            this.livePage.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage livePage;
        private System.Windows.Forms.TabPage playbackPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sequenceScreenplayEditor;
        private System.Windows.Forms.Button groupEditor;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button cameraEditor;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
    }
}
