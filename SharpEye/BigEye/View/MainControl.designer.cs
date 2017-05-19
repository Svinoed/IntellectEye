﻿namespace View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.livePage = new System.Windows.Forms.TabPage();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cameraEditor = new System.Windows.Forms.Button();
            this.groupEditor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sequenceScreenplayEditor = new System.Windows.Forms.Button();
            this.playbackPage = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.livePage.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.playbackPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.livePage);
            this.tabControl.Controls.Add(this.playbackPage);
            this.tabControl.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(94, 30);
            this.tabControl.Location = new System.Drawing.Point(3, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(854, 459);
            this.tabControl.TabIndex = 1;
            // 
            // livePage
            // 
            this.livePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.livePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.livePage.Controls.Add(this.videoPanel);
            this.livePage.Controls.Add(this.groupPanel);
            this.livePage.Controls.Add(this.panel2);
            this.livePage.Controls.Add(this.menuPanel);
            this.livePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livePage.Location = new System.Drawing.Point(4, 34);
            this.livePage.Name = "livePage";
            this.livePage.Padding = new System.Windows.Forms.Padding(3);
            this.livePage.Size = new System.Drawing.Size(846, 421);
            this.livePage.TabIndex = 0;
            this.livePage.Text = "Наблюдение";
            // 
            // videoPanel
            // 
            this.videoPanel.Location = new System.Drawing.Point(1, 1);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(622, 414);
            this.videoPanel.TabIndex = 7;
            // 
            // groupPanel
            // 
            this.groupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel.Controls.Add(this.listView1);
            this.groupPanel.Location = new System.Drawing.Point(651, 44);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(175, 330);
            this.groupPanel.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(37, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(96, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Location = new System.Drawing.Point(651, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 35);
            this.panel2.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageIndex = 4;
            this.searchButton.ImageList = this.imageList1;
            this.searchButton.Location = new System.Drawing.Point(152, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 20);
            this.searchButton.TabIndex = 7;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchButton_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.add.png");
            this.imageList1.Images.SetKeyName(1, "2.minus.png");
            this.imageList1.Images.SetKeyName(2, "3.question.png");
            this.imageList1.Images.SetKeyName(3, "4.cog.png");
            this.imageList1.Images.SetKeyName(4, "5.magnify.png");
            this.imageList1.Images.SetKeyName(5, "6.magnify.add.png");
            this.imageList1.Images.SetKeyName(6, "7.play.png");
            this.imageList1.Images.SetKeyName(7, "8.pause.png");
            this.imageList1.Images.SetKeyName(8, "9.control.fastforward.variant.png");
            this.imageList1.Images.SetKeyName(9, "10.appbar.control.rewind.variant.png");
            this.imageList1.Images.SetKeyName(10, "11.down.png");
            this.imageList1.Images.SetKeyName(11, "12.up.png");
            this.imageList1.Images.SetKeyName(12, "13.left.png");
            this.imageList1.Images.SetKeyName(13, "14.right.png");
            this.imageList1.Images.SetKeyName(14, "15.expand.png");
            this.imageList1.Images.SetKeyName(15, "16.right.left.png");
            this.imageList1.Images.SetKeyName(16, "17.close.png");
            this.imageList1.Images.SetKeyName(17, "18.camera.png");
            this.imageList1.Images.SetKeyName(18, "19.list.check.png");
            this.imageList1.Images.SetKeyName(19, "20.film.list.png");
            this.imageList1.Images.SetKeyName(20, "21.gallery.png");
            this.imageList1.Images.SetKeyName(21, "22.save.png");
            this.imageList1.Images.SetKeyName(22, "23.journal.png");
            this.imageList1.Images.SetKeyName(23, "24.check.png");
            this.imageList1.Images.SetKeyName(24, "25.sound.0.png");
            this.imageList1.Images.SetKeyName(25, "26.sound.1.png");
            this.imageList1.Images.SetKeyName(26, "27.sound.2.png");
            this.imageList1.Images.SetKeyName(27, "28.sound.3.png");
            this.imageList1.Images.SetKeyName(28, "29.sound.mute.png");
            this.imageList1.Images.SetKeyName(29, "30.transform.rotate.clockwise.png");
            this.imageList1.Images.SetKeyName(30, "31.undo.curve.png");
            this.imageList1.Images.SetKeyName(31, "32..png");
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchTextBox.Location = new System.Drawing.Point(0, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(152, 26);
            this.searchTextBox.TabIndex = 5;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.cameraEditor);
            this.menuPanel.Controls.Add(this.groupEditor);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.sequenceScreenplayEditor);
            this.menuPanel.Location = new System.Drawing.Point(666, 378);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(175, 35);
            this.menuPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cameraEditor
            // 
            this.cameraEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraEditor.ImageIndex = 17;
            this.cameraEditor.ImageList = this.imageList1;
            this.cameraEditor.Location = new System.Drawing.Point(22, 2);
            this.cameraEditor.Name = "cameraEditor";
            this.cameraEditor.Size = new System.Drawing.Size(30, 30);
            this.cameraEditor.TabIndex = 1;
            this.cameraEditor.UseVisualStyleBackColor = true;
            this.cameraEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cameraEditor_MouseClick);
            // 
            // groupEditor
            // 
            this.groupEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupEditor.ImageIndex = 18;
            this.groupEditor.ImageList = this.imageList1;
            this.groupEditor.Location = new System.Drawing.Point(58, 3);
            this.groupEditor.Name = "groupEditor";
            this.groupEditor.Size = new System.Drawing.Size(30, 30);
            this.groupEditor.TabIndex = 2;
            this.groupEditor.UseVisualStyleBackColor = true;
            this.groupEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupEditor_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageIndex = 20;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(130, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sequenceScreenplayEditor
            // 
            this.sequenceScreenplayEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceScreenplayEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sequenceScreenplayEditor.ImageIndex = 19;
            this.sequenceScreenplayEditor.ImageList = this.imageList1;
            this.sequenceScreenplayEditor.Location = new System.Drawing.Point(94, 2);
            this.sequenceScreenplayEditor.Name = "sequenceScreenplayEditor";
            this.sequenceScreenplayEditor.Size = new System.Drawing.Size(30, 30);
            this.sequenceScreenplayEditor.TabIndex = 3;
            this.sequenceScreenplayEditor.UseVisualStyleBackColor = true;
            this.sequenceScreenplayEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sequenceScreenplayEditor_MouseClick);
            // 
            // playbackPage
            // 
            this.playbackPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playbackPage.Controls.Add(this.panel5);
            this.playbackPage.Controls.Add(this.panel4);
            this.playbackPage.Controls.Add(this.panel3);
            this.playbackPage.Location = new System.Drawing.Point(4, 34);
            this.playbackPage.Name = "playbackPage";
            this.playbackPage.Padding = new System.Windows.Forms.Padding(3);
            this.playbackPage.Size = new System.Drawing.Size(846, 421);
            this.playbackPage.TabIndex = 1;
            this.playbackPage.Text = "Воспроизведение";
            this.playbackPage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Location = new System.Drawing.Point(1, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(774, 77);
            this.panel5.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(768, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(781, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 408);
            this.panel4.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.ImageIndex = 1;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(12, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 28);
            this.button7.TabIndex = 12;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(12, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 28);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 332);
            this.panel3.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.ImageIndex = 8;
            this.button11.ImageList = this.imageList1;
            this.button11.Location = new System.Drawing.Point(413, 42);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 30);
            this.button11.TabIndex = 16;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.ImageIndex = 6;
            this.button10.ImageList = this.imageList1;
            this.button10.Location = new System.Drawing.Point(377, 43);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 15;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.yellowBtn);
            this.groupBox1.Controls.Add(this.redBtn);
            this.groupBox1.Controls.Add(this.logBtn);
            this.groupBox1.Location = new System.Drawing.Point(4, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowBtn.BackgroundImage")));
            this.yellowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBtn.Location = new System.Drawing.Point(78, 15);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(30, 30);
            this.yellowBtn.TabIndex = 2;
            this.yellowBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redBtn.BackgroundImage")));
            this.redBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redBtn.Location = new System.Drawing.Point(42, 15);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(30, 30);
            this.redBtn.TabIndex = 1;
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            this.logBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logBtn.ImageIndex = 22;
            this.logBtn.ImageList = this.imageList1;
            this.logBtn.Location = new System.Drawing.Point(6, 14);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(30, 30);
            this.logBtn.TabIndex = 0;
            this.logBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.settingBtn);
            this.panel1.Location = new System.Drawing.Point(737, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 30);
            this.panel1.TabIndex = 6;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ImageIndex = 2;
            this.helpBtn.ImageList = this.imageList1;
            this.helpBtn.Location = new System.Drawing.Point(53, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(30, 30);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ImageIndex = 3;
            this.settingBtn.ImageList = this.imageList1;
            this.settingBtn.Location = new System.Drawing.Point(84, 0);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(30, 30);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageIndex = 31;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(41, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageIndex = 16;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(741, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ImageIndex = 9;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(341, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.ImageIndex = 29;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(5, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.ImageIndex = 15;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(305, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(857, 512);
            this.tabControl.ResumeLayout(false);
            this.livePage.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.playbackPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
    }
}