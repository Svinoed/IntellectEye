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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listGroup = new System.Windows.Forms.ListView();
            this.controlButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCameraGroup = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listCamera = new System.Windows.Forms.ListView();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.controlButtonGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listGroup);
            this.splitContainer1.Panel1.Controls.Add(this.controlButtonGroupBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(484, 262);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // listGroup
            // 
            this.listGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGroup.Location = new System.Drawing.Point(0, -2);
            this.listGroup.MultiSelect = false;
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(133, 223);
            this.listGroup.TabIndex = 2;
            this.listGroup.UseCompatibleStateImageBehavior = false;
            this.listGroup.View = System.Windows.Forms.View.List;
            this.listGroup.SelectedIndexChanged += new System.EventHandler(this.listGroup_SelectedIndexChanged);
            // 
            // controlButtonGroupBox
            // 
            this.controlButtonGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.controlButtonGroupBox.Controls.Add(this.delButton);
            this.controlButtonGroupBox.Controls.Add(this.addButton);
            this.controlButtonGroupBox.Location = new System.Drawing.Point(0, 220);
            this.controlButtonGroupBox.Name = "controlButtonGroupBox";
            this.controlButtonGroupBox.Size = new System.Drawing.Size(146, 42);
            this.controlButtonGroupBox.TabIndex = 1;
            this.controlButtonGroupBox.TabStop = false;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Gray;
            this.delButton.Image = ((System.Drawing.Image)(resources.GetObject("delButton.Image")));
            this.delButton.Location = new System.Drawing.Point(39, 7);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(30, 30);
            this.delButton.TabIndex = 1;
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gray;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(3, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 30);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(263, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "Отменить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(187, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moveDownBtn);
            this.groupBox1.Controls.Add(this.moveUpBtn);
            this.groupBox1.Controls.Add(this.moveLeftBtn);
            this.groupBox1.Controls.Add(this.moveRightBtn);
            this.groupBox1.Location = new System.Drawing.Point(146, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(42, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.BackColor = System.Drawing.Color.Gray;
            this.moveDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveDownBtn.Image")));
            this.moveDownBtn.Location = new System.Drawing.Point(6, 154);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(30, 30);
            this.moveDownBtn.TabIndex = 5;
            this.moveDownBtn.UseVisualStyleBackColor = false;
            this.moveDownBtn.Click += new System.EventHandler(this.MoveDown);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.BackColor = System.Drawing.Color.Gray;
            this.moveUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveUpBtn.Image")));
            this.moveUpBtn.Location = new System.Drawing.Point(6, 115);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(30, 30);
            this.moveUpBtn.TabIndex = 4;
            this.moveUpBtn.UseVisualStyleBackColor = false;
            this.moveUpBtn.Click += new System.EventHandler(this.MoveUp);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.BackColor = System.Drawing.Color.Gray;
            this.moveLeftBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveLeftBtn.Image")));
            this.moveLeftBtn.Location = new System.Drawing.Point(6, 55);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.moveLeftBtn.TabIndex = 3;
            this.moveLeftBtn.UseVisualStyleBackColor = false;
            this.moveLeftBtn.Click += new System.EventHandler(this.MoveLeft);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.BackColor = System.Drawing.Color.Gray;
            this.moveRightBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveRightBtn.Image")));
            this.moveRightBtn.Location = new System.Drawing.Point(6, 19);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(30, 30);
            this.moveRightBtn.TabIndex = 2;
            this.moveRightBtn.UseVisualStyleBackColor = false;
            this.moveRightBtn.Click += new System.EventHandler(this.MoveRight);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listCameraGroup);
            this.panel2.Location = new System.Drawing.Point(194, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 190);
            this.panel2.TabIndex = 3;
            // 
            // listCameraGroup
            // 
            this.listCameraGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCameraGroup.Location = new System.Drawing.Point(7, 3);
            this.listCameraGroup.Name = "listCameraGroup";
            this.listCameraGroup.Size = new System.Drawing.Size(121, 189);
            this.listCameraGroup.TabIndex = 0;
            this.listCameraGroup.UseCompatibleStateImageBehavior = false;
            this.listCameraGroup.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listCamera);
            this.panel1.Location = new System.Drawing.Point(9, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 171);
            this.panel1.TabIndex = 2;
            // 
            // listCamera
            // 
            this.listCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCamera.Location = new System.Drawing.Point(0, 7);
            this.listCamera.Name = "listCamera";
            this.listCamera.Size = new System.Drawing.Size(128, 161);
            this.listCamera.TabIndex = 0;
            this.listCamera.UseCompatibleStateImageBehavior = false;
            this.listCamera.View = System.Windows.Forms.View.List;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameTextBox.Location = new System.Drawing.Point(108, 5);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название группы";
            // 
            // GroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "GroupEditor";
            this.Text = "Редактор групп";
            this.Load += new System.EventHandler(this.GroupEditor_Load);
            this.Resize += new System.EventHandler(this.GroupEditor_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.controlButtonGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox controlButtonGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
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
    }
}