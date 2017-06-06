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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.livePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.videoLivePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cameraEditorButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.screenPlayButton = new System.Windows.Forms.Button();
            this.groupEditorButton = new System.Windows.Forms.Button();
            this.sequenceScreenplayEditButton = new System.Windows.Forms.Button();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.listGroup = new System.Windows.Forms.ListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playbackPage = new System.Windows.Forms.TabPage();
            this.mainPlayBackTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoPlayBackPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.bookmarkForAllButton = new System.Windows.Forms.Button();
            this.playForAllButton = new System.Windows.Forms.Button();
            this.switchForAllButton = new System.Windows.Forms.Button();
            this.fustUpAllButton = new System.Windows.Forms.Button();
            this.redoAllBbutton = new System.Windows.Forms.Button();
            this.slowDownAllButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cleanAllButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.mainLiveTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.livePage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuTableLayoutPanel.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.playbackPage.SuspendLayout();
            this.mainPlayBackTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.logTableLayoutPanel.SuspendLayout();
            this.mainLiveTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.livePage);
            this.tabControl.Controls.Add(this.playbackPage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(94, 30);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 426);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // livePage
            // 
            this.livePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.livePage.Controls.Add(this.tableLayoutPanel2);
            this.livePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livePage.Location = new System.Drawing.Point(4, 34);
            this.livePage.Name = "livePage";
            this.livePage.Padding = new System.Windows.Forms.Padding(3);
            this.livePage.Size = new System.Drawing.Size(847, 388);
            this.livePage.TabIndex = 0;
            this.livePage.Text = "Наблюдение";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.videoLivePanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 382);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // videoLivePanel
            // 
            this.videoLivePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoLivePanel.Location = new System.Drawing.Point(3, 3);
            this.videoLivePanel.Name = "videoLivePanel";
            this.videoLivePanel.Size = new System.Drawing.Size(629, 376);
            this.videoLivePanel.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.menuTableLayoutPanel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(638, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 376);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // menuTableLayoutPanel
            // 
            this.menuTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.menuTableLayoutPanel.ColumnCount = 4;
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuTableLayoutPanel.Controls.Add(this.cameraEditorButton, 0, 0);
            this.menuTableLayoutPanel.Controls.Add(this.screenPlayButton, 3, 0);
            this.menuTableLayoutPanel.Controls.Add(this.groupEditorButton, 1, 0);
            this.menuTableLayoutPanel.Controls.Add(this.sequenceScreenplayEditButton, 2, 0);
            this.menuTableLayoutPanel.Location = new System.Drawing.Point(20, 333);
            this.menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            this.menuTableLayoutPanel.RowCount = 1;
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuTableLayoutPanel.Size = new System.Drawing.Size(160, 40);
            this.menuTableLayoutPanel.TabIndex = 0;
            // 
            // cameraEditorButton
            // 
            this.cameraEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraEditorButton.ImageIndex = 4;
            this.cameraEditorButton.ImageList = this.imageList1;
            this.cameraEditorButton.Location = new System.Drawing.Point(3, 3);
            this.cameraEditorButton.Name = "cameraEditorButton";
            this.cameraEditorButton.Size = new System.Drawing.Size(34, 34);
            this.cameraEditorButton.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.cameraEditorButton, "Редактор камер (в разработке)");
            this.cameraEditorButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.help.png");
            this.imageList1.Images.SetKeyName(1, "2.settings.png");
            this.imageList1.Images.SetKeyName(2, "3.search.png");
            this.imageList1.Images.SetKeyName(3, "4.searchCancel.png");
            this.imageList1.Images.SetKeyName(4, "5.camEditor.png");
            this.imageList1.Images.SetKeyName(5, "6.groupEditor.png");
            this.imageList1.Images.SetKeyName(6, "7.screenplayEditor.png");
            this.imageList1.Images.SetKeyName(7, "8.screenplay.png");
            this.imageList1.Images.SetKeyName(8, "9.jornal.png");
            this.imageList1.Images.SetKeyName(9, "10.error.png");
            this.imageList1.Images.SetKeyName(10, "11.warning.png");
            this.imageList1.Images.SetKeyName(11, "12.add.png");
            this.imageList1.Images.SetKeyName(12, "13.cleanScreen.png");
            this.imageList1.Images.SetKeyName(13, "14.reset.png");
            this.imageList1.Images.SetKeyName(14, "15.play.png");
            this.imageList1.Images.SetKeyName(15, "16.pause.png");
            this.imageList1.Images.SetKeyName(16, "17.bookmark.png");
            this.imageList1.Images.SetKeyName(17, "18.switch.png");
            this.imageList1.Images.SetKeyName(18, "19.slow.png");
            this.imageList1.Images.SetKeyName(19, "20.fast.png");
            this.imageList1.Images.SetKeyName(20, "21.playAgain.png");
            // 
            // screenPlayButton
            // 
            this.screenPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenPlayButton.ImageIndex = 7;
            this.screenPlayButton.ImageList = this.imageList1;
            this.screenPlayButton.Location = new System.Drawing.Point(123, 3);
            this.screenPlayButton.Name = "screenPlayButton";
            this.screenPlayButton.Size = new System.Drawing.Size(34, 34);
            this.screenPlayButton.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.screenPlayButton, "Запуск сценария (в разработке)");
            this.screenPlayButton.UseVisualStyleBackColor = true;
            // 
            // groupEditorButton
            // 
            this.groupEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupEditorButton.ImageIndex = 5;
            this.groupEditorButton.ImageList = this.imageList1;
            this.groupEditorButton.Location = new System.Drawing.Point(43, 3);
            this.groupEditorButton.Name = "groupEditorButton";
            this.groupEditorButton.Size = new System.Drawing.Size(34, 34);
            this.groupEditorButton.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.groupEditorButton, "Редактор групп");
            this.groupEditorButton.UseVisualStyleBackColor = true;
            this.groupEditorButton.Click += new System.EventHandler(this.groupEditor_Click);
            // 
            // sequenceScreenplayEditButton
            // 
            this.sequenceScreenplayEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceScreenplayEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sequenceScreenplayEditButton.ImageIndex = 6;
            this.sequenceScreenplayEditButton.ImageList = this.imageList1;
            this.sequenceScreenplayEditButton.Location = new System.Drawing.Point(83, 3);
            this.sequenceScreenplayEditButton.Name = "sequenceScreenplayEditButton";
            this.sequenceScreenplayEditButton.Size = new System.Drawing.Size(34, 34);
            this.sequenceScreenplayEditButton.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.sequenceScreenplayEditButton, "Редактор сценариев  (в разработке)");
            this.sequenceScreenplayEditButton.UseVisualStyleBackColor = true;
            // 
            // groupPanel
            // 
            this.groupPanel.Controls.Add(this.listGroup);
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.Location = new System.Drawing.Point(3, 35);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(194, 292);
            this.groupPanel.TabIndex = 3;
            // 
            // listGroup
            // 
            this.listGroup.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listGroup.BackColor = System.Drawing.Color.LightGray;
            this.listGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroup.HoverSelection = true;
            this.listGroup.Location = new System.Drawing.Point(0, 0);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(194, 292);
            this.listGroup.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.listGroup, "Список созданных групп");
            this.listGroup.UseCompatibleStateImageBehavior = false;
            this.listGroup.View = System.Windows.Forms.View.List;
            this.listGroup.Click += new System.EventHandler(this.listGroup_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.searchTextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 26);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.LightGray;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(153, 26);
            this.searchTextBox.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.searchTextBox, "Поиск по группам");
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(162, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "     ";
            // 
            // playbackPage
            // 
            this.playbackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.playbackPage.Controls.Add(this.mainPlayBackTableLayoutPanel);
            this.playbackPage.Location = new System.Drawing.Point(4, 34);
            this.playbackPage.Name = "playbackPage";
            this.playbackPage.Padding = new System.Windows.Forms.Padding(3);
            this.playbackPage.Size = new System.Drawing.Size(847, 388);
            this.playbackPage.TabIndex = 1;
            this.playbackPage.Text = "Воспроизведение";
            // 
            // mainPlayBackTableLayoutPanel
            // 
            this.mainPlayBackTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.mainPlayBackTableLayoutPanel.ColumnCount = 2;
            this.mainPlayBackTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.99591F));
            this.mainPlayBackTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.00409F));
            this.mainPlayBackTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainPlayBackTableLayoutPanel.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.mainPlayBackTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPlayBackTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPlayBackTableLayoutPanel.Name = "mainPlayBackTableLayoutPanel";
            this.mainPlayBackTableLayoutPanel.RowCount = 1;
            this.mainPlayBackTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPlayBackTableLayoutPanel.Size = new System.Drawing.Size(841, 382);
            this.mainPlayBackTableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.videoPlayBackPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // videoPlayBackPanel
            // 
            this.videoPlayBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayBackPanel.Location = new System.Drawing.Point(3, 3);
            this.videoPlayBackPanel.Name = "videoPlayBackPanel";
            this.videoPlayBackPanel.Size = new System.Drawing.Size(624, 368);
            this.videoPlayBackPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel6);
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 377);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(624, 1);
            this.panel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 9;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.Controls.Add(this.resetButton, 8, 0);
            this.tableLayoutPanel6.Controls.Add(this.bookmarkForAllButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.playForAllButton, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.switchForAllButton, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.fustUpAllButton, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.redoAllBbutton, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.slowDownAllButton, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, -35);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(624, 36);
            this.tableLayoutPanel6.TabIndex = 21;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.ImageIndex = 13;
            this.resetButton.ImageList = this.imageList1;
            this.resetButton.Location = new System.Drawing.Point(591, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(30, 30);
            this.resetButton.TabIndex = 18;
            this.mainToolTip.SetToolTip(this.resetButton, "Сброс всех настроек");
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // bookmarkForAllButton
            // 
            this.bookmarkForAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkForAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookmarkForAllButton.ImageIndex = 16;
            this.bookmarkForAllButton.ImageList = this.imageList1;
            this.bookmarkForAllButton.Location = new System.Drawing.Point(3, 3);
            this.bookmarkForAllButton.Name = "bookmarkForAllButton";
            this.bookmarkForAllButton.Size = new System.Drawing.Size(30, 30);
            this.bookmarkForAllButton.TabIndex = 20;
            this.mainToolTip.SetToolTip(this.bookmarkForAllButton, "Поставить метку на всех");
            this.bookmarkForAllButton.UseVisualStyleBackColor = true;
            // 
            // playForAllButton
            // 
            this.playForAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playForAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playForAllButton.ImageIndex = 14;
            this.playForAllButton.ImageList = this.imageList1;
            this.playForAllButton.Location = new System.Drawing.Point(297, 3);
            this.playForAllButton.Name = "playForAllButton";
            this.playForAllButton.Size = new System.Drawing.Size(30, 30);
            this.playForAllButton.TabIndex = 24;
            this.mainToolTip.SetToolTip(this.playForAllButton, "Воспроизвести/приостаносить все видео");
            this.playForAllButton.UseVisualStyleBackColor = true;
            this.playForAllButton.Click += new System.EventHandler(this.playForAllButton_Click);
            // 
            // switchForAllButton
            // 
            this.switchForAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchForAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchForAllButton.ImageIndex = 17;
            this.switchForAllButton.ImageList = this.imageList1;
            this.switchForAllButton.Location = new System.Drawing.Point(225, 3);
            this.switchForAllButton.Name = "switchForAllButton";
            this.switchForAllButton.Size = new System.Drawing.Size(30, 30);
            this.switchForAllButton.TabIndex = 27;
            this.mainToolTip.SetToolTip(this.switchForAllButton, "Сменить порядок воспроизведения всех видео");
            this.switchForAllButton.UseVisualStyleBackColor = true;
            // 
            // fustUpAllButton
            // 
            this.fustUpAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fustUpAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fustUpAllButton.ImageIndex = 19;
            this.fustUpAllButton.ImageList = this.imageList1;
            this.fustUpAllButton.Location = new System.Drawing.Point(333, 3);
            this.fustUpAllButton.Name = "fustUpAllButton";
            this.fustUpAllButton.Size = new System.Drawing.Size(30, 30);
            this.fustUpAllButton.TabIndex = 25;
            this.mainToolTip.SetToolTip(this.fustUpAllButton, "Ускорить все видео");
            this.fustUpAllButton.UseVisualStyleBackColor = true;
            // 
            // redoAllBbutton
            // 
            this.redoAllBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redoAllBbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoAllBbutton.ImageIndex = 20;
            this.redoAllBbutton.ImageList = this.imageList1;
            this.redoAllBbutton.Location = new System.Drawing.Point(369, 3);
            this.redoAllBbutton.Name = "redoAllBbutton";
            this.redoAllBbutton.Size = new System.Drawing.Size(30, 30);
            this.redoAllBbutton.TabIndex = 23;
            this.mainToolTip.SetToolTip(this.redoAllBbutton, "Повторять воспроизведение");
            this.redoAllBbutton.UseVisualStyleBackColor = true;
            // 
            // slowDownAllButton
            // 
            this.slowDownAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slowDownAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slowDownAllButton.ImageIndex = 18;
            this.slowDownAllButton.ImageList = this.imageList1;
            this.slowDownAllButton.Location = new System.Drawing.Point(261, 3);
            this.slowDownAllButton.Name = "slowDownAllButton";
            this.slowDownAllButton.Size = new System.Drawing.Size(30, 30);
            this.slowDownAllButton.TabIndex = 26;
            this.mainToolTip.SetToolTip(this.slowDownAllButton, "Замедлить все видео");
            this.slowDownAllButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(624, 16);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(641, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(196, 374);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.cleanAllButton, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.addNewButton, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(58, 331);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(80, 40);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // cleanAllButton
            // 
            this.cleanAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cleanAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cleanAllButton.ImageIndex = 12;
            this.cleanAllButton.ImageList = this.imageList1;
            this.cleanAllButton.Location = new System.Drawing.Point(43, 3);
            this.cleanAllButton.Name = "cleanAllButton";
            this.cleanAllButton.Size = new System.Drawing.Size(34, 34);
            this.cleanAllButton.TabIndex = 12;
            this.mainToolTip.SetToolTip(this.cleanAllButton, "Удалить видео из списка воспроизведения");
            this.cleanAllButton.UseVisualStyleBackColor = true;
            // 
            // addNewButton
            // 
            this.addNewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewButton.ImageIndex = 11;
            this.addNewButton.ImageList = this.imageList1;
            this.addNewButton.Location = new System.Drawing.Point(3, 3);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(34, 34);
            this.addNewButton.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.addNewButton, "Добавить видео к просмотру");
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(190, 322);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logTableLayoutPanel);
            this.logGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logGroupBox.ForeColor = System.Drawing.Color.White;
            this.logGroupBox.Location = new System.Drawing.Point(3, 435);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(855, 56);
            this.logGroupBox.TabIndex = 2;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Журнал";
            // 
            // logTableLayoutPanel
            // 
            this.logTableLayoutPanel.ColumnCount = 3;
            this.logTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.logTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.logTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.logTableLayoutPanel.Controls.Add(this.yellowBtn, 2, 0);
            this.logTableLayoutPanel.Controls.Add(this.logBtn, 0, 0);
            this.logTableLayoutPanel.Controls.Add(this.redBtn, 1, 0);
            this.logTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.logTableLayoutPanel.Name = "logTableLayoutPanel";
            this.logTableLayoutPanel.RowCount = 1;
            this.logTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logTableLayoutPanel.Size = new System.Drawing.Size(110, 37);
            this.logTableLayoutPanel.TabIndex = 8;
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBtn.ImageIndex = 10;
            this.yellowBtn.ImageList = this.imageList1;
            this.yellowBtn.Location = new System.Drawing.Point(75, 3);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(30, 30);
            this.yellowBtn.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.yellowBtn, "Предупреждающий сигнал (в разработке)");
            this.yellowBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            this.logBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logBtn.ImageIndex = 8;
            this.logBtn.ImageList = this.imageList1;
            this.logBtn.Location = new System.Drawing.Point(3, 3);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(30, 30);
            this.logBtn.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.logBtn, "Журнал  (в разработке)");
            this.logBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redBtn.ImageIndex = 9;
            this.redBtn.ImageList = this.imageList1;
            this.redBtn.Location = new System.Drawing.Point(39, 3);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(30, 30);
            this.redBtn.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.redBtn, "Сообщения об ошибке  (в разработке)");
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.ImageIndex = 0;
            this.helpBtn.ImageList = this.imageList1;
            this.helpBtn.Location = new System.Drawing.Point(3, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(28, 30);
            this.helpBtn.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.helpBtn, "Справка (в разработке)");
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.ImageIndex = 1;
            this.settingBtn.ImageList = this.imageList1;
            this.settingBtn.Location = new System.Drawing.Point(37, 3);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(28, 30);
            this.settingBtn.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.settingBtn, "Настройки (в разработке)");
            this.settingBtn.UseVisualStyleBackColor = true;
            // 
            // mainLiveTableLayoutPanel
            // 
            this.mainLiveTableLayoutPanel.ColumnCount = 1;
            this.mainLiveTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLiveTableLayoutPanel.Controls.Add(this.logGroupBox, 0, 1);
            this.mainLiveTableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.mainLiveTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLiveTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLiveTableLayoutPanel.Name = "mainLiveTableLayoutPanel";
            this.mainLiveTableLayoutPanel.RowCount = 2;
            this.mainLiveTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLiveTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLiveTableLayoutPanel.Size = new System.Drawing.Size(861, 494);
            this.mainLiveTableLayoutPanel.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.settingBtn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.helpBtn, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(784, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(68, 34);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // mainToolTip
            // 
            this.mainToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.mainToolTip.ForeColor = System.Drawing.Color.White;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.mainLiveTableLayoutPanel);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(861, 494);
            this.tabControl.ResumeLayout(false);
            this.livePage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuTableLayoutPanel.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.playbackPage.ResumeLayout(false);
            this.mainPlayBackTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            this.logTableLayoutPanel.ResumeLayout(false);
            this.mainLiveTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage livePage;
        private System.Windows.Forms.TabPage playbackPage;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button screenPlayButton;
        private System.Windows.Forms.Button sequenceScreenplayEditButton;
        private System.Windows.Forms.Button groupEditorButton;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button cameraEditorButton;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ListView listGroup;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel videoLivePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Panel videoPlayBackPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cleanAllButton;
        private System.Windows.Forms.Button bookmarkForAllButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel menuTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel mainLiveTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel logTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel mainPlayBackTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button fustUpAllButton;
        private System.Windows.Forms.Button playForAllButton;
        private System.Windows.Forms.Button redoAllBbutton;
        private System.Windows.Forms.Button slowDownAllButton;
        private System.Windows.Forms.Button switchForAllButton;
        private System.Windows.Forms.ToolTip mainToolTip;
    }
}
