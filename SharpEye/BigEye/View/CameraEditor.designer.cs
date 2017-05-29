namespace View
{
    partial class CameraEditor
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
            this.camEditorMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.camPanel = new System.Windows.Forms.TableLayoutPanel();
            this.camList = new System.Windows.Forms.ListView();
            this.searchCamTextBox = new System.Windows.Forms.TextBox();
            this.camEditPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.camIDTextBox = new System.Windows.Forms.TextBox();
            this.camNameTextBox = new System.Windows.Forms.TextBox();
            this.camScreenplayCompoBox = new System.Windows.Forms.ComboBox();
            this.camDescriptTextBox = new System.Windows.Forms.TextBox();
            this.camEditorMainPanel.SuspendLayout();
            this.camPanel.SuspendLayout();
            this.camEditPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // camEditorMainPanel
            // 
            this.camEditorMainPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.camEditorMainPanel.ColumnCount = 2;
            this.camEditorMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.camEditorMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.camEditorMainPanel.Controls.Add(this.camPanel, 0, 0);
            this.camEditorMainPanel.Controls.Add(this.camEditPanel, 1, 0);
            this.camEditorMainPanel.Location = new System.Drawing.Point(12, 12);
            this.camEditorMainPanel.Name = "camEditorMainPanel";
            this.camEditorMainPanel.RowCount = 1;
            this.camEditorMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.camEditorMainPanel.Size = new System.Drawing.Size(460, 237);
            this.camEditorMainPanel.TabIndex = 0;
            // 
            // camPanel
            // 
            this.camPanel.ColumnCount = 1;
            this.camPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.camPanel.Controls.Add(this.camList, 0, 1);
            this.camPanel.Controls.Add(this.searchCamTextBox, 0, 0);
            this.camPanel.Location = new System.Drawing.Point(5, 5);
            this.camPanel.Name = "camPanel";
            this.camPanel.RowCount = 2;
            this.camPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.camPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.camPanel.Size = new System.Drawing.Size(194, 100);
            this.camPanel.TabIndex = 0;
            // 
            // camList
            // 
            this.camList.BackColor = System.Drawing.Color.LightGray;
            this.camList.Location = new System.Drawing.Point(3, 23);
            this.camList.Name = "camList";
            this.camList.Size = new System.Drawing.Size(121, 74);
            this.camList.TabIndex = 0;
            this.camList.UseCompatibleStateImageBehavior = false;
            // 
            // searchCamTextBox
            // 
            this.searchCamTextBox.BackColor = System.Drawing.Color.LightGray;
            this.searchCamTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchCamTextBox.Name = "searchCamTextBox";
            this.searchCamTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchCamTextBox.TabIndex = 1;
            // 
            // camEditPanel
            // 
            this.camEditPanel.ColumnCount = 1;
            this.camEditPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.camEditPanel.Controls.Add(this.buttonPanel, 0, 1);
            this.camEditPanel.Controls.Add(this.tableLayoutPanel, 0, 0);
            this.camEditPanel.Location = new System.Drawing.Point(207, 5);
            this.camEditPanel.Name = "camEditPanel";
            this.camEditPanel.RowCount = 2;
            this.camEditPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.85321F));
            this.camEditPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.14679F));
            this.camEditPanel.Size = new System.Drawing.Size(240, 218);
            this.camEditPanel.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.saveButton, 0, 0);
            this.buttonPanel.Controls.Add(this.cancelButton, 1, 0);
            this.buttonPanel.Location = new System.Drawing.Point(3, 163);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(200, 52);
            this.buttonPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(103, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.camIDTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.camNameTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.camScreenplayCompoBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.camDescriptTextBox, 1, 3);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(234, 138);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID камеры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сценарий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание";
            // 
            // camIDTextBox
            // 
            this.camIDTextBox.BackColor = System.Drawing.Color.LightGray;
            this.camIDTextBox.Location = new System.Drawing.Point(70, 3);
            this.camIDTextBox.Name = "camIDTextBox";
            this.camIDTextBox.Size = new System.Drawing.Size(160, 20);
            this.camIDTextBox.TabIndex = 4;
            // 
            // camNameTextBox
            // 
            this.camNameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.camNameTextBox.Location = new System.Drawing.Point(70, 33);
            this.camNameTextBox.Name = "camNameTextBox";
            this.camNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.camNameTextBox.TabIndex = 5;
            // 
            // camScreenplayCompoBox
            // 
            this.camScreenplayCompoBox.BackColor = System.Drawing.Color.LightGray;
            this.camScreenplayCompoBox.FormattingEnabled = true;
            this.camScreenplayCompoBox.Location = new System.Drawing.Point(70, 63);
            this.camScreenplayCompoBox.Name = "camScreenplayCompoBox";
            this.camScreenplayCompoBox.Size = new System.Drawing.Size(160, 21);
            this.camScreenplayCompoBox.TabIndex = 6;
            // 
            // camDescriptTextBox
            // 
            this.camDescriptTextBox.BackColor = System.Drawing.Color.LightGray;
            this.camDescriptTextBox.Location = new System.Drawing.Point(70, 93);
            this.camDescriptTextBox.Name = "camDescriptTextBox";
            this.camDescriptTextBox.Size = new System.Drawing.Size(160, 20);
            this.camDescriptTextBox.TabIndex = 7;
            // 
            // CameraEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.camEditorMainPanel);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "CameraEditor";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Редактор камер";
            this.camEditorMainPanel.ResumeLayout(false);
            this.camPanel.ResumeLayout(false);
            this.camPanel.PerformLayout();
            this.camEditPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel camEditorMainPanel;
        private System.Windows.Forms.TableLayoutPanel camPanel;
        private System.Windows.Forms.ListView camList;
        private System.Windows.Forms.TextBox searchCamTextBox;
        private System.Windows.Forms.TableLayoutPanel camEditPanel;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox camIDTextBox;
        private System.Windows.Forms.TextBox camNameTextBox;
        private System.Windows.Forms.ComboBox camScreenplayCompoBox;
        private System.Windows.Forms.TextBox camDescriptTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}