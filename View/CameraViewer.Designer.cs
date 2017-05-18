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
            this.videoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.Controls.Add(this.panel2);
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(743, 458);
            this.videoPanel.TabIndex = 0;
            this.videoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(749, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 455);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 35);
            this.panel1.TabIndex = 1;
            // 
            // CameraViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoPanel);
            this.Name = "CameraViewer";
            this.Size = new System.Drawing.Size(857, 512);
            this.videoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
