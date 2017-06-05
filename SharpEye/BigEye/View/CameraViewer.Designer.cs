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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rightDownButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.downButton = new System.Windows.Forms.Button();
            this.leftDownButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.rightUpButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.leftUpButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomPlusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zoomMinusButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitFullscreenButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(551, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 297);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(134, 297);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.rightDownButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.downButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.leftDownButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rightButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightUpButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.resetButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.upButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftUpButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 3);
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.speedTextBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(38, 99);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(57, 42);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Скорость";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(3, 16);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(49, 20);
            this.speedTextBox.TabIndex = 31;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Controls.Add(this.zoomPlusButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.zoomMinusButton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(17, 147);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(100, 30);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // zoomPlusButton
            // 
            this.zoomPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomPlusButton.ImageIndex = 13;
            this.zoomPlusButton.ImageList = this.imageList1;
            this.zoomPlusButton.Location = new System.Drawing.Point(73, 3);
            this.zoomPlusButton.Name = "zoomPlusButton";
            this.zoomPlusButton.Size = new System.Drawing.Size(24, 24);
            this.zoomPlusButton.TabIndex = 5;
            this.zoomPlusButton.UseVisualStyleBackColor = true;
            this.zoomPlusButton.Click += new System.EventHandler(this.zoomPlusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Zoom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomMinusButton
            // 
            this.zoomMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomMinusButton.ImageIndex = 12;
            this.zoomMinusButton.ImageList = this.imageList1;
            this.zoomMinusButton.Location = new System.Drawing.Point(3, 3);
            this.zoomMinusButton.Name = "zoomMinusButton";
            this.zoomMinusButton.Size = new System.Drawing.Size(24, 24);
            this.zoomMinusButton.TabIndex = 29;
            this.zoomMinusButton.UseVisualStyleBackColor = true;
            this.zoomMinusButton.Click += new System.EventHandler(this.zoomMinusButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 35);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitFullscreenButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookmarkButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.screenshotButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 30);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.ImageIndex = 1;
            this.settingsButton.ImageList = this.imageList1;
            this.settingsButton.Location = new System.Drawing.Point(658, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(24, 24);
            this.settingsButton.TabIndex = 32;
            this.settingsButton.UseVisualStyleBackColor = true;
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
            this.exitFullscreenButton.Size = new System.Drawing.Size(24, 24);
            this.exitFullscreenButton.TabIndex = 32;
            this.exitFullscreenButton.UseVisualStyleBackColor = true;
            this.exitFullscreenButton.Click += new System.EventHandler(this.exitFullscreenButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.ImageIndex = 0;
            this.helpButton.ImageList = this.imageList1;
            this.helpButton.Location = new System.Drawing.Point(628, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 24);
            this.helpButton.TabIndex = 33;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookmarkButton.ImageIndex = 16;
            this.bookmarkButton.ImageList = this.imageList1;
            this.bookmarkButton.Location = new System.Drawing.Point(598, 3);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(24, 24);
            this.bookmarkButton.TabIndex = 35;
            this.bookmarkButton.UseVisualStyleBackColor = true;
            // 
            // screenshotButton
            // 
            this.screenshotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenshotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenshotButton.ImageIndex = 2;
            this.screenshotButton.ImageList = this.imageList1;
            this.screenshotButton.Location = new System.Drawing.Point(568, 3);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(24, 24);
            this.screenshotButton.TabIndex = 34;
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.ImageIndex = 3;
            this.resetButton.ImageList = this.imageList1;
            this.resetButton.Location = new System.Drawing.Point(33, 33);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(24, 24);
            this.resetButton.TabIndex = 36;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.videoPanel);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(685, 332);
            this.mainPanel.TabIndex = 2;
            // 
            // videoPanel
            // 
            this.videoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(551, 297);
            this.videoPanel.TabIndex = 2;
            // 
            // CameraViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.mainPanel);
            this.Name = "CameraViewer";
            this.Size = new System.Drawing.Size(685, 332);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel videoPanel;
    }
}
