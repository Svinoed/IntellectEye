namespace View
{
    partial class SmallControl
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
            this._videoPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _videoPanel
            // 
            this._videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._videoPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this._videoPanel.Location = new System.Drawing.Point(0, 0);
            this._videoPanel.Name = "_videoPanel";
            this._videoPanel.Size = new System.Drawing.Size(228, 232);
            this._videoPanel.TabIndex = 0;
            this._videoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._videoPanel_Paint);
            // 
            // SmallControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._videoPanel);
            this.Name = "SmallControl";
            this.Size = new System.Drawing.Size(228, 232);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _videoPanel;
    }
}
