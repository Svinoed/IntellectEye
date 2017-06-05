namespace View
{
    partial class TEMPORARYSearchVideo
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTlabel = new System.Windows.Forms.Label();
            this.stopTlabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addVideoButton = new System.Windows.Forms.Button();
            this.camTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.camSearchTextBox = new System.Windows.Forms.TextBox();
            this.camListView = new System.Windows.Forms.ListView();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.camTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.camTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 161);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.startTimePicker, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.startTlabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.stopTlabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.endTimePicker, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.addVideoButton, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(175, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(106, 155);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(3, 16);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(100, 20);
            this.startTimePicker.TabIndex = 6;
            // 
            // startTlabel
            // 
            this.startTlabel.AutoSize = true;
            this.startTlabel.ForeColor = System.Drawing.Color.White;
            this.startTlabel.Location = new System.Drawing.Point(3, 0);
            this.startTlabel.Name = "startTlabel";
            this.startTlabel.Size = new System.Drawing.Size(71, 13);
            this.startTlabel.TabIndex = 2;
            this.startTlabel.Text = "Дата начала";
            // 
            // stopTlabel
            // 
            this.stopTlabel.AutoSize = true;
            this.stopTlabel.ForeColor = System.Drawing.Color.White;
            this.stopTlabel.Location = new System.Drawing.Point(3, 39);
            this.stopTlabel.Name = "stopTlabel";
            this.stopTlabel.Size = new System.Drawing.Size(66, 13);
            this.stopTlabel.TabIndex = 3;
            this.stopTlabel.Text = "Дата конца";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(3, 55);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(100, 20);
            this.endTimePicker.TabIndex = 7;
            // 
            // addVideoButton
            // 
            this.addVideoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addVideoButton.Location = new System.Drawing.Point(15, 129);
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.Size = new System.Drawing.Size(75, 23);
            this.addVideoButton.TabIndex = 8;
            this.addVideoButton.Text = "Выбрать";
            this.addVideoButton.UseVisualStyleBackColor = true;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // camTableLayoutPanel
            // 
            this.camTableLayoutPanel.ColumnCount = 1;
            this.camTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.camTableLayoutPanel.Controls.Add(this.camSearchTextBox, 0, 0);
            this.camTableLayoutPanel.Controls.Add(this.camListView, 0, 1);
            this.camTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.camTableLayoutPanel.Name = "camTableLayoutPanel";
            this.camTableLayoutPanel.RowCount = 2;
            this.camTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.camTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.camTableLayoutPanel.Size = new System.Drawing.Size(166, 155);
            this.camTableLayoutPanel.TabIndex = 0;
            // 
            // camSearchTextBox
            // 
            this.camSearchTextBox.BackColor = System.Drawing.Color.LightGray;
            this.camSearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camSearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.camSearchTextBox.Name = "camSearchTextBox";
            this.camSearchTextBox.Size = new System.Drawing.Size(160, 20);
            this.camSearchTextBox.TabIndex = 0;
            this.camSearchTextBox.TextChanged += new System.EventHandler(this.camSearchTextBox_TextChanged);
            // 
            // camListView
            // 
            this.camListView.BackColor = System.Drawing.Color.LightGray;
            this.camListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camListView.Location = new System.Drawing.Point(3, 29);
            this.camListView.Name = "camListView";
            this.camListView.Size = new System.Drawing.Size(160, 123);
            this.camListView.TabIndex = 1;
            this.camListView.UseCompatibleStateImageBehavior = false;
            // 
            // TEMPORARYSearchVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "TEMPORARYSearchVideo";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Поиск по архиву";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.camTableLayoutPanel.ResumeLayout(false);
            this.camTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel camTableLayoutPanel;
        private System.Windows.Forms.TextBox camSearchTextBox;
        private System.Windows.Forms.ListView camListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label stopTlabel;
        private System.Windows.Forms.Label startTlabel;
        private System.Windows.Forms.Button addVideoButton;
    }
}