namespace View
{
    partial class PlaybackControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoPanel = new System.Windows.Forms.Panel();
            this.SaveVideoButton = new System.Windows.Forms.Button();
            this.MakeScreenshotButton = new System.Windows.Forms.Button();
            this.SaveBookmarkButton = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ChangeDirectionButton = new System.Windows.Forms.Button();
            this.SlowDownButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SpeedUpButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.timeLinePanel = new System.Windows.Forms.Panel();
            this.SpeedResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoPanel.Location = new System.Drawing.Point(2, 2);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(510, 230);
            this.videoPanel.TabIndex = 0;
            // 
            // SaveVideoButton
            // 
            this.SaveVideoButton.Location = new System.Drawing.Point(474, 253);
            this.SaveVideoButton.Name = "SaveVideoButton";
            this.SaveVideoButton.Size = new System.Drawing.Size(38, 25);
            this.SaveVideoButton.TabIndex = 2;
            this.SaveVideoButton.Text = "Vid";
            this.SaveVideoButton.UseVisualStyleBackColor = true;
            this.SaveVideoButton.Click += new System.EventHandler(this.SaveVideoButton_Click);
            // 
            // MakeScreenshotButton
            // 
            this.MakeScreenshotButton.Location = new System.Drawing.Point(474, 284);
            this.MakeScreenshotButton.Name = "MakeScreenshotButton";
            this.MakeScreenshotButton.Size = new System.Drawing.Size(39, 25);
            this.MakeScreenshotButton.TabIndex = 3;
            this.MakeScreenshotButton.Text = "Scr";
            this.MakeScreenshotButton.UseVisualStyleBackColor = true;
            this.MakeScreenshotButton.Click += new System.EventHandler(this.MakeScreenshotButton_Click);
            // 
            // SaveBookmarkButton
            // 
            this.SaveBookmarkButton.Location = new System.Drawing.Point(474, 319);
            this.SaveBookmarkButton.Name = "SaveBookmarkButton";
            this.SaveBookmarkButton.Size = new System.Drawing.Size(38, 24);
            this.SaveBookmarkButton.TabIndex = 4;
            this.SaveBookmarkButton.Text = "BkMr";
            this.SaveBookmarkButton.UseVisualStyleBackColor = true;
            this.SaveBookmarkButton.Click += new System.EventHandler(this.SaveBookmarkButton_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(32, 292);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(130, 45);
            this.VolumeTrackBar.SmallChange = 2;
            this.VolumeTrackBar.TabIndex = 5;
            this.VolumeTrackBar.Value = 50;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 341);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(127, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(400, 324);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 7;
            this.speedLabel.Text = "Speed";
            // 
            // ChangeDirectionButton
            // 
            this.ChangeDirectionButton.Location = new System.Drawing.Point(177, 312);
            this.ChangeDirectionButton.Name = "ChangeDirectionButton";
            this.ChangeDirectionButton.Size = new System.Drawing.Size(45, 39);
            this.ChangeDirectionButton.TabIndex = 8;
            this.ChangeDirectionButton.Text = "ChDir";
            this.ChangeDirectionButton.UseVisualStyleBackColor = true;
            this.ChangeDirectionButton.Click += new System.EventHandler(this.ChangeDirectionButton_Click);
            // 
            // SlowDownButton
            // 
            this.SlowDownButton.Location = new System.Drawing.Point(228, 312);
            this.SlowDownButton.Name = "SlowDownButton";
            this.SlowDownButton.Size = new System.Drawing.Size(49, 39);
            this.SlowDownButton.TabIndex = 9;
            this.SlowDownButton.Text = "Slow";
            this.SlowDownButton.UseVisualStyleBackColor = true;
            this.SlowDownButton.Click += new System.EventHandler(this.SlowDownButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(283, 311);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(49, 39);
            this.PlayButton.TabIndex = 10;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.Location = new System.Drawing.Point(338, 311);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(49, 39);
            this.SpeedUpButton.TabIndex = 11;
            this.SpeedUpButton.Text = "Speed";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            this.SpeedUpButton.Click += new System.EventHandler(this.SpeedUpButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(2, 392);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(40, 34);
            this.ReturnButton.TabIndex = 12;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // timeLinePanel
            // 
            this.timeLinePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timeLinePanel.Location = new System.Drawing.Point(35, 241);
            this.timeLinePanel.Name = "timeLinePanel";
            this.timeLinePanel.Size = new System.Drawing.Size(433, 45);
            this.timeLinePanel.TabIndex = 13;
            // 
            // SpeedResetButton
            // 
            this.SpeedResetButton.Location = new System.Drawing.Point(437, 320);
            this.SpeedResetButton.Name = "SpeedResetButton";
            this.SpeedResetButton.Size = new System.Drawing.Size(31, 23);
            this.SpeedResetButton.TabIndex = 14;
            this.SpeedResetButton.Text = "rstspd";
            this.SpeedResetButton.UseVisualStyleBackColor = true;
            this.SpeedResetButton.Click += new System.EventHandler(this.SpeedResetButton_Click);
            // 
            // PlaybackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpeedResetButton);
            this.Controls.Add(this.timeLinePanel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SpeedUpButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SlowDownButton);
            this.Controls.Add(this.ChangeDirectionButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.SaveBookmarkButton);
            this.Controls.Add(this.MakeScreenshotButton);
            this.Controls.Add(this.SaveVideoButton);
            this.Controls.Add(this.videoPanel);
            this.Name = "PlaybackControl";
            this.Size = new System.Drawing.Size(563, 429);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Button SaveVideoButton;
        private System.Windows.Forms.Button MakeScreenshotButton;
        private System.Windows.Forms.Button SaveBookmarkButton;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button ChangeDirectionButton;
        private System.Windows.Forms.Button SlowDownButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SpeedUpButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel timeLinePanel;
        private System.Windows.Forms.Button SpeedResetButton;
    }
}
