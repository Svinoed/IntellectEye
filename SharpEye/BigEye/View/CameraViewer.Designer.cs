namespace View
{
    partial class CameraViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraViewer));
            this.videoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomMinusButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.zoomPlusButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rightDownButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.leftDownButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.rightUpButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.leftUpButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitFullscreenButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(738, 458);
            this.videoPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.speedTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.zoomMinusButton);
            this.panel2.Controls.Add(this.zoomPlusButton);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(744, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 455);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Zoom";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(31, 127);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(49, 20);
            this.speedTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Скорость";
            // 
            // zoomMinusButton
            // 
            this.zoomMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomMinusButton.ImageIndex = 12;
            this.zoomMinusButton.ImageList = this.imageList1;
            this.zoomMinusButton.Location = new System.Drawing.Point(7, 162);
            this.zoomMinusButton.Name = "zoomMinusButton";
            this.zoomMinusButton.Size = new System.Drawing.Size(30, 30);
            this.zoomMinusButton.TabIndex = 29;
            this.zoomMinusButton.UseVisualStyleBackColor = true;
            this.zoomMinusButton.Click += new System.EventHandler(this.zoomMinusButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.help.png");
            this.imageList1.Images.SetKeyName(1, "2.settings.png");
            this.imageList1.Images.SetKeyName(2, "3.screen.png");
            this.imageList1.Images.SetKeyName(3, "4.searchCancel.png");
            this.imageList1.Images.SetKeyName(4, "5.left.png");
            this.imageList1.Images.SetKeyName(5, "6.down.png");
            this.imageList1.Images.SetKeyName(6, "7.right.png");
            this.imageList1.Images.SetKeyName(7, "8.up.png");
            this.imageList1.Images.SetKeyName(8, "9..png");
            this.imageList1.Images.SetKeyName(9, "10..png");
            this.imageList1.Images.SetKeyName(10, "11..png");
            this.imageList1.Images.SetKeyName(11, "12..png");
            this.imageList1.Images.SetKeyName(12, "13.minus.png");
            this.imageList1.Images.SetKeyName(13, "14.plus.png");
            this.imageList1.Images.SetKeyName(14, "15.play.png");
            this.imageList1.Images.SetKeyName(15, "16.pause.png");
            this.imageList1.Images.SetKeyName(16, "17.bookmark.png");
            this.imageList1.Images.SetKeyName(17, "18.switch.png");
            this.imageList1.Images.SetKeyName(18, "19.slow.png");
            this.imageList1.Images.SetKeyName(19, "20.fast.png");
            this.imageList1.Images.SetKeyName(20, "21.fullscreenExit.png");
            this.imageList1.Images.SetKeyName(21, "22.fullscreen.png");
            this.imageList1.Images.SetKeyName(22, "23.get.png");
            // 
            // zoomPlusButton
            // 
            this.zoomPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomPlusButton.ImageIndex = 13;
            this.zoomPlusButton.ImageList = this.imageList1;
            this.zoomPlusButton.Location = new System.Drawing.Point(77, 162);
            this.zoomPlusButton.Name = "zoomPlusButton";
            this.zoomPlusButton.Size = new System.Drawing.Size(30, 30);
            this.zoomPlusButton.TabIndex = 5;
            this.zoomPlusButton.UseVisualStyleBackColor = true;
            this.zoomPlusButton.Click += new System.EventHandler(this.zoomPlusButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.rightDownButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.downButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.leftDownButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rightButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightUpButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.upButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftUpButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 90);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // rightDownButton
            // 
            this.rightDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDownButton.ImageIndex = 9;
            this.rightDownButton.ImageList = this.imageList1;
            this.rightDownButton.Location = new System.Drawing.Point(63, 63);
            this.rightDownButton.Name = "rightDownButton";
            this.rightDownButton.Size = new System.Drawing.Size(24, 24);
            this.rightDownButton.TabIndex = 34;
            this.rightDownButton.UseVisualStyleBackColor = true;
            this.rightDownButton.Click += new System.EventHandler(this.rightDownButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downButton.ImageIndex = 5;
            this.downButton.ImageList = this.imageList1;
            this.downButton.Location = new System.Drawing.Point(33, 63);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(24, 24);
            this.downButton.TabIndex = 33;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // leftDownButton
            // 
            this.leftDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDownButton.ImageIndex = 10;
            this.leftDownButton.ImageList = this.imageList1;
            this.leftDownButton.Location = new System.Drawing.Point(3, 63);
            this.leftDownButton.Name = "leftDownButton";
            this.leftDownButton.Size = new System.Drawing.Size(24, 24);
            this.leftDownButton.TabIndex = 32;
            this.leftDownButton.UseVisualStyleBackColor = true;
            this.leftDownButton.Click += new System.EventHandler(this.leftDownButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightButton.ImageIndex = 6;
            this.rightButton.ImageList = this.imageList1;
            this.rightButton.Location = new System.Drawing.Point(63, 33);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(24, 24);
            this.rightButton.TabIndex = 31;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // rightUpButton
            // 
            this.rightUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightUpButton.ImageIndex = 8;
            this.rightUpButton.ImageList = this.imageList1;
            this.rightUpButton.Location = new System.Drawing.Point(63, 3);
            this.rightUpButton.Name = "rightUpButton";
            this.rightUpButton.Size = new System.Drawing.Size(24, 24);
            this.rightUpButton.TabIndex = 30;
            this.rightUpButton.UseVisualStyleBackColor = true;
            this.rightUpButton.Click += new System.EventHandler(this.rightUpButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upButton.ImageIndex = 7;
            this.upButton.ImageList = this.imageList1;
            this.upButton.Location = new System.Drawing.Point(33, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(24, 24);
            this.upButton.TabIndex = 29;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftUpButton
            // 
            this.leftUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftUpButton.ImageIndex = 11;
            this.leftUpButton.ImageList = this.imageList1;
            this.leftUpButton.Location = new System.Drawing.Point(3, 3);
            this.leftUpButton.Name = "leftUpButton";
            this.leftUpButton.Size = new System.Drawing.Size(24, 24);
            this.leftUpButton.TabIndex = 28;
            this.leftUpButton.UseVisualStyleBackColor = true;
            this.leftUpButton.Click += new System.EventHandler(this.leftUpButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftButton.ImageIndex = 4;
            this.leftButton.ImageList = this.imageList1;
            this.leftButton.Location = new System.Drawing.Point(3, 33);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(24, 24);
            this.leftButton.TabIndex = 26;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitFullscreenButton);
            this.panel1.Location = new System.Drawing.Point(3, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 35);
            this.panel1.TabIndex = 1;
            // 
            // exitFullscreenButton
            // 
            this.exitFullscreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitFullscreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitFullscreenButton.ImageIndex = 20;
            this.exitFullscreenButton.ImageList = this.imageList1;
            this.exitFullscreenButton.Location = new System.Drawing.Point(3, 3);
            this.exitFullscreenButton.Name = "exitFullscreenButton";
            this.exitFullscreenButton.Size = new System.Drawing.Size(30, 30);
            this.exitFullscreenButton.TabIndex = 32;
            this.exitFullscreenButton.UseVisualStyleBackColor = true;
            this.exitFullscreenButton.Click += new System.EventHandler(this.exitFullscreenButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.ImageIndex = 1;
            this.settingsButton.ImageList = this.imageList1;
            this.settingsButton.Location = new System.Drawing.Point(123, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(24, 24);
            this.settingsButton.TabIndex = 32;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.ImageIndex = 0;
            this.helpButton.ImageList = this.imageList1;
            this.helpButton.Location = new System.Drawing.Point(93, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 24);
            this.helpButton.TabIndex = 33;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // screenshotButton
            // 
            this.screenshotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenshotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenshotButton.ImageIndex = 2;
            this.screenshotButton.ImageList = this.imageList1;
            this.screenshotButton.Location = new System.Drawing.Point(33, 3);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(24, 24);
            this.screenshotButton.TabIndex = 34;
            this.screenshotButton.UseVisualStyleBackColor = true;
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookmarkButton.ImageIndex = 16;
            this.bookmarkButton.ImageList = this.imageList1;
            this.bookmarkButton.Location = new System.Drawing.Point(63, 3);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(24, 24);
            this.bookmarkButton.TabIndex = 35;
            this.bookmarkButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.screenshotButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookmarkButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(704, 464);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.ImageIndex = 3;
            this.resetButton.ImageList = this.imageList1;
            this.resetButton.Location = new System.Drawing.Point(3, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(24, 24);
            this.resetButton.TabIndex = 36;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // CameraViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoPanel);
            this.Name = "CameraViewer";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button rightDownButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftDownButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button rightUpButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftUpButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button zoomPlusButton;
        private System.Windows.Forms.Button zoomMinusButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.Button bookmarkButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitFullscreenButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
    }
}
