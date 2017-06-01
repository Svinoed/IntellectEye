namespace View
{
    partial class MiniPlayBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniPlayBack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.flowPanelZoom = new System.Windows.Forms.Panel();
            this.zoomPlusButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.zoomMinusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.rightDownButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.leftDownButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.rightUpButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.leftUpButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.switchOrderButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.slowDownButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.fastUpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fullscreenButton = new System.Windows.Forms.Button();
            this.commentButton = new System.Windows.Forms.Button();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.playbackSpeedLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowPanelZoom.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoPanel);
            this.panel1.Controls.Add(this.flowPanelZoom);
            this.panel1.Controls.Add(this.flowPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 307);
            this.panel1.TabIndex = 0;
            // 
            // videoPanel
            // 
            this.videoPanel.Location = new System.Drawing.Point(6, 6);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(455, 242);
            this.videoPanel.TabIndex = 27;
            // 
            // flowPanelZoom
            // 
            this.flowPanelZoom.Controls.Add(this.playbackSpeedLabel);
            this.flowPanelZoom.Controls.Add(this.zoomPlusButton);
            this.flowPanelZoom.Controls.Add(this.zoomMinusButton);
            this.flowPanelZoom.Controls.Add(this.label1);
            this.flowPanelZoom.Controls.Add(this.tableLayoutPanel2);
            this.flowPanelZoom.Controls.Add(this.label2);
            this.flowPanelZoom.Location = new System.Drawing.Point(467, 3);
            this.flowPanelZoom.Name = "flowPanelZoom";
            this.flowPanelZoom.Size = new System.Drawing.Size(92, 248);
            this.flowPanelZoom.TabIndex = 26;
            // 
            // zoomPlusButton
            // 
            this.zoomPlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomPlusButton.ImageIndex = 13;
            this.zoomPlusButton.ImageList = this.imageList1;
            this.zoomPlusButton.Location = new System.Drawing.Point(62, 143);
            this.zoomPlusButton.Name = "zoomPlusButton";
            this.zoomPlusButton.Size = new System.Drawing.Size(30, 30);
            this.zoomPlusButton.TabIndex = 26;
            this.zoomPlusButton.UseVisualStyleBackColor = true;
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
            this.imageList1.Images.SetKeyName(23, "24.comment.png");
            this.imageList1.Images.SetKeyName(24, "25.playAgain.png");
            // 
            // zoomMinusButton
            // 
            this.zoomMinusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomMinusButton.ImageIndex = 12;
            this.zoomMinusButton.ImageList = this.imageList1;
            this.zoomMinusButton.Location = new System.Drawing.Point(3, 143);
            this.zoomMinusButton.Name = "zoomMinusButton";
            this.zoomMinusButton.Size = new System.Drawing.Size(30, 30);
            this.zoomMinusButton.TabIndex = 27;
            this.zoomMinusButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Скорость";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightDownButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.downButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.leftDownButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rightButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightUpButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.upButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftUpButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 90);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.ImageIndex = 3;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(33, 33);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 24);
            this.button8.TabIndex = 26;
            this.button8.UseVisualStyleBackColor = true;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Zoom";
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.tableLayoutPanel4);
            this.flowPanel.Controls.Add(this.tableLayoutPanel3);
            this.flowPanel.Controls.Add(this.tableLayoutPanel1);
            this.flowPanel.Controls.Add(this.progressBar1);
            this.flowPanel.Location = new System.Drawing.Point(0, 254);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(562, 53);
            this.flowPanel.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Controls.Add(this.resetButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.helpButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.settingsButton, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(469, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(90, 30);
            this.tableLayoutPanel4.TabIndex = 27;
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
            this.resetButton.TabIndex = 21;
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.ImageIndex = 0;
            this.helpButton.ImageList = this.imageList1;
            this.helpButton.Location = new System.Drawing.Point(33, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 24);
            this.helpButton.TabIndex = 26;
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.ImageIndex = 1;
            this.settingsButton.ImageList = this.imageList1;
            this.settingsButton.Location = new System.Drawing.Point(63, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(24, 24);
            this.settingsButton.TabIndex = 27;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.switchOrderButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.redoButton, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.slowDownButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.playButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.fastUpButton, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(213, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // switchOrderButton
            // 
            this.switchOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchOrderButton.ImageIndex = 17;
            this.switchOrderButton.ImageList = this.imageList1;
            this.switchOrderButton.Location = new System.Drawing.Point(3, 3);
            this.switchOrderButton.Name = "switchOrderButton";
            this.switchOrderButton.Size = new System.Drawing.Size(24, 24);
            this.switchOrderButton.TabIndex = 19;
            this.switchOrderButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            this.redoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoButton.ImageIndex = 24;
            this.redoButton.ImageList = this.imageList1;
            this.redoButton.Location = new System.Drawing.Point(123, 3);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(24, 24);
            this.redoButton.TabIndex = 29;
            this.redoButton.UseVisualStyleBackColor = true;
            // 
            // slowDownButton
            // 
            this.slowDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slowDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slowDownButton.ImageIndex = 18;
            this.slowDownButton.ImageList = this.imageList1;
            this.slowDownButton.Location = new System.Drawing.Point(33, 3);
            this.slowDownButton.Name = "slowDownButton";
            this.slowDownButton.Size = new System.Drawing.Size(24, 24);
            this.slowDownButton.TabIndex = 17;
            this.slowDownButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.ImageIndex = 14;
            this.playButton.ImageList = this.imageList1;
            this.playButton.Location = new System.Drawing.Point(63, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(24, 24);
            this.playButton.TabIndex = 16;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // fastUpButton
            // 
            this.fastUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fastUpButton.ImageIndex = 19;
            this.fastUpButton.ImageList = this.imageList1;
            this.fastUpButton.Location = new System.Drawing.Point(93, 3);
            this.fastUpButton.Name = "fastUpButton";
            this.fastUpButton.Size = new System.Drawing.Size(24, 24);
            this.fastUpButton.TabIndex = 18;
            this.fastUpButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.fullscreenButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.commentButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.screenshotButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bookmarkButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullscreenButton.ImageIndex = 21;
            this.fullscreenButton.ImageList = this.imageList1;
            this.fullscreenButton.Location = new System.Drawing.Point(3, 3);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(24, 24);
            this.fullscreenButton.TabIndex = 20;
            this.fullscreenButton.UseVisualStyleBackColor = true;
            // 
            // commentButton
            // 
            this.commentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.commentButton.ImageIndex = 23;
            this.commentButton.ImageList = this.imageList1;
            this.commentButton.Location = new System.Drawing.Point(123, 3);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(24, 24);
            this.commentButton.TabIndex = 28;
            this.commentButton.UseVisualStyleBackColor = true;
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
            this.screenshotButton.TabIndex = 23;
            this.screenshotButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportButton.ImageIndex = 22;
            this.exportButton.ImageList = this.imageList1;
            this.exportButton.Location = new System.Drawing.Point(63, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(24, 24);
            this.exportButton.TabIndex = 25;
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookmarkButton.ImageIndex = 16;
            this.bookmarkButton.ImageList = this.imageList1;
            this.bookmarkButton.Location = new System.Drawing.Point(93, 3);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(24, 24);
            this.bookmarkButton.TabIndex = 22;
            this.bookmarkButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // playbackSpeedLabel
            // 
            this.playbackSpeedLabel.AutoSize = true;
            this.playbackSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playbackSpeedLabel.Location = new System.Drawing.Point(16, 117);
            this.playbackSpeedLabel.Name = "playbackSpeedLabel";
            this.playbackSpeedLabel.Size = new System.Drawing.Size(10, 13);
            this.playbackSpeedLabel.TabIndex = 34;
            this.playbackSpeedLabel.Text = " ";
            // 
            // MiniPlayBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Name = "MiniPlayBack";
            this.Size = new System.Drawing.Size(565, 310);
            this.panel1.ResumeLayout(false);
            this.flowPanelZoom.ResumeLayout(false);
            this.flowPanelZoom.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel flowPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button switchOrderButton;
        private System.Windows.Forms.Button fastUpButton;
        private System.Windows.Forms.Button slowDownButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.Button bookmarkButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button fullscreenButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel flowPanelZoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button rightDownButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftDownButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button rightUpButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftUpButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button zoomPlusButton;
        private System.Windows.Forms.Button zoomMinusButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Label playbackSpeedLabel;
    }
}
