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
            this.videoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(738, 458);
            this.videoPanel.TabIndex = 0;
            this.videoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(744, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 455);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(3, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 35);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.button26, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button25, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button24, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button23, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button22, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button21, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button20, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button18, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 90);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button26.ImageIndex = 9;
            this.button26.ImageList = this.imageList1;
            this.button26.Location = new System.Drawing.Point(63, 63);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(24, 24);
            this.button26.TabIndex = 34;
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.ImageIndex = 5;
            this.button25.ImageList = this.imageList1;
            this.button25.Location = new System.Drawing.Point(33, 63);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(24, 24);
            this.button25.TabIndex = 33;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.ImageIndex = 10;
            this.button24.ImageList = this.imageList1;
            this.button24.Location = new System.Drawing.Point(3, 63);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(24, 24);
            this.button24.TabIndex = 32;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button23.ImageIndex = 6;
            this.button23.ImageList = this.imageList1;
            this.button23.Location = new System.Drawing.Point(63, 33);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(24, 24);
            this.button23.TabIndex = 31;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.ImageIndex = 8;
            this.button22.ImageList = this.imageList1;
            this.button22.Location = new System.Drawing.Point(63, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(24, 24);
            this.button22.TabIndex = 30;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button21.ImageIndex = 7;
            this.button21.ImageList = this.imageList1;
            this.button21.Location = new System.Drawing.Point(33, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(24, 24);
            this.button21.TabIndex = 29;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.ImageIndex = 11;
            this.button20.ImageList = this.imageList1;
            this.button20.Location = new System.Drawing.Point(3, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(24, 24);
            this.button20.TabIndex = 28;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.ImageIndex = 4;
            this.button18.ImageList = this.imageList1;
            this.button18.Location = new System.Drawing.Point(3, 33);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(24, 24);
            this.button18.TabIndex = 26;
            this.button18.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageIndex = 13;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(77, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.ImageIndex = 12;
            this.button12.ImageList = this.imageList1;
            this.button12.Location = new System.Drawing.Point(7, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 29;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Скорость";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(123, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(93, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ImageIndex = 2;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(33, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 34;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ImageIndex = 16;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(63, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 35;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(704, 464);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.ImageIndex = 3;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 36;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.ImageIndex = 20;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 32;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Zoom";
            // 
            // CameraViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoPanel);
            this.Name = "CameraViewer";
            this.Size = new System.Drawing.Size(857, 512);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
    }
}
