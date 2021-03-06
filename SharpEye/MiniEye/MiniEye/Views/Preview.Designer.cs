﻿namespace MiniEye.Views
{
    partial class Preview
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
            this.settingsButton = new System.Windows.Forms.Button();
            this._VideoPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.BackgroundImage = global::MiniEye.Properties.Resources.Settings256;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.Location = new System.Drawing.Point(12, 120);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 30);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Visible = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // _VideoPanel
            // 
            this._VideoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._VideoPanel.Location = new System.Drawing.Point(0, 0);
            this._VideoPanel.Name = "_VideoPanel";
            this._VideoPanel.Size = new System.Drawing.Size(184, 162);
            this._VideoPanel.TabIndex = 3;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this._VideoPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Preview";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preview_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Preview_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Panel _VideoPanel;
    }
}