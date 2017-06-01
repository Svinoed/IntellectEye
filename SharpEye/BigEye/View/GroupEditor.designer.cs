namespace View
{
    partial class GroupEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupEditor));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.listCameraGroup = new System.Windows.Forms.ListView();
            this.listCamera = new System.Windows.Forms.ListView();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listGroup = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchGroup = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.LightGray;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(130, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.BackColor = System.Drawing.Color.Gray;
            this.moveDownBtn.ImageIndex = 1;
            this.moveDownBtn.ImageList = this.imageList1;
            this.moveDownBtn.Location = new System.Drawing.Point(3, 123);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(24, 24);
            this.moveDownBtn.TabIndex = 5;
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.MoveDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.leftArrow.png");
            this.imageList1.Images.SetKeyName(1, "2.downArrow.png");
            this.imageList1.Images.SetKeyName(2, "3.rightArrow.png");
            this.imageList1.Images.SetKeyName(3, "4.upArrow.png");
            this.imageList1.Images.SetKeyName(4, "5.add.png");
            this.imageList1.Images.SetKeyName(5, "6.delete.png");
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.BackColor = System.Drawing.Color.Gray;
            this.moveUpBtn.ImageIndex = 3;
            this.moveUpBtn.ImageList = this.imageList1;
            this.moveUpBtn.Location = new System.Drawing.Point(3, 93);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(24, 24);
            this.moveUpBtn.TabIndex = 4;
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.MoveUp);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.BackColor = System.Drawing.Color.Gray;
            this.moveLeftBtn.ImageIndex = 0;
            this.moveLeftBtn.ImageList = this.imageList1;
            this.moveLeftBtn.Location = new System.Drawing.Point(3, 33);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(24, 24);
            this.moveLeftBtn.TabIndex = 3;
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.MoveLeft);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.ImageIndex = 2;
            this.moveRightBtn.ImageList = this.imageList1;
            this.moveRightBtn.Location = new System.Drawing.Point(3, 3);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(24, 24);
            this.moveRightBtn.TabIndex = 2;
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.MoveRight);
            // 
            // listCameraGroup
            // 
            this.listCameraGroup.BackColor = System.Drawing.Color.LightGray;
            this.listCameraGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCameraGroup.Location = new System.Drawing.Point(3, 16);
            this.listCameraGroup.Name = "listCameraGroup";
            this.listCameraGroup.Size = new System.Drawing.Size(130, 151);
            this.listCameraGroup.TabIndex = 0;
            this.listCameraGroup.UseCompatibleStateImageBehavior = false;
            this.listCameraGroup.View = System.Windows.Forms.View.List;
            // 
            // listCamera
            // 
            this.listCamera.BackColor = System.Drawing.Color.LightGray;
            this.listCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCamera.Location = new System.Drawing.Point(3, 42);
            this.listCamera.Name = "listCamera";
            this.listCamera.Size = new System.Drawing.Size(130, 161);
            this.listCamera.TabIndex = 0;
            this.listCamera.UseCompatibleStateImageBehavior = false;
            this.listCamera.View = System.Windows.Forms.View.List;
            // 
            // delButton
            // 
            this.delButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delButton.ImageIndex = 5;
            this.delButton.ImageList = this.imageList1;
            this.delButton.Location = new System.Drawing.Point(43, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(30, 30);
            this.delButton.TabIndex = 1;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gray;
            this.addButton.ImageIndex = 4;
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 30);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "Отменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CancelClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.groupNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupNameTextBox.Location = new System.Drawing.Point(105, 3);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название группы";
            // 
            // listGroup
            // 
            this.listGroup.BackColor = System.Drawing.Color.LightGray;
            this.listGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroup.Location = new System.Drawing.Point(3, 29);
            this.listGroup.MultiSelect = false;
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(138, 176);
            this.listGroup.TabIndex = 2;
            this.listGroup.UseCompatibleStateImageBehavior = false;
            this.listGroup.View = System.Windows.Forms.View.List;
            this.listGroup.SelectedIndexChanged += new System.EventHandler(this.listGroup_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 262);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listGroup, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.searchGroup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 254);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchGroup
            // 
            this.searchGroup.BackColor = System.Drawing.Color.LightGray;
            this.searchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroup.Location = new System.Drawing.Point(3, 3);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(138, 20);
            this.searchGroup.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.delButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(80, 40);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(155, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(325, 254);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupNameTextBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(319, 25);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(319, 176);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Controls.Add(this.moveDownBtn, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.moveRightBtn, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.moveUpBtn, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.moveLeftBtn, 0, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(145, 13);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(29, 150);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.listCamera, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.searchTextBox, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(136, 170);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Доступные камеры";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.listCameraGroup, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(180, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(136, 170);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выбранные камеры";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 216);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(319, 35);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // GroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "GroupEditor";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Редактор групп";
            this.Load += new System.EventHandler(this.GroupEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.Button moveRightBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView listCameraGroup;
        private System.Windows.Forms.ListView listGroup;
        private System.Windows.Forms.ListView listCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox searchGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label3;
    }
}