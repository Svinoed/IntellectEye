using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Interfaces;
using View.Utils;

namespace View
{
    public partial class MainControl : UserControl, IMainView, ILogView
    {
        private string _camera;

        public string Camera { get { return this._camera; } set { this._camera = value; } }
        public event Action CameraSelected;
        public event Action<string> CamEditClick;
        public event Action GropsEditClick;

        public bool ViewVisible { get => this.Visible; set =>  this.Visible = value; }
        
        public MainControl()
        {
            InitializeComponent();
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.Dock = DockStyle.Fill;
            tabControl1.Location = this.Location;
            panel1.Location = new Point(tabControl1.Width-panel1.Width, tabControl1.Location.Y);
        }

        // Это Диме
        public void AddListControl(List<ISmallView> list)
        {
            throw new NotImplementedException();
        }


        #region DrawGroupBox
        // Задем свой стиль для журнала
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        #endregion


        public void AddMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void AddVideoControl(IVideoView view)
        {
            // для одной камеры
            Panel panel = view.VideoPanel;
            panel.Dock = DockStyle.Fill;
            livePage.Controls.Add(panel);
        }

        public void SetCameraList(string[] cameras)
        {
            //string[] temp = { "K1", "K2" }; 
            //cameraComboBox.Items.AddRange(cameras);
        }

        private void cameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Camera = cameraComboBox.SelectedItem.ToString();
            if(CameraSelected != null)
            {
                CameraSelected();
            }
        }

        private void groupEditor_MouseClick(object sender, MouseEventArgs e)
        {
            //GroupEditor groupEditorWindow = new GroupEditor();
            //groupEditorWindow.Show();
        }

        private void cameraEditor_MouseClick(object sender, MouseEventArgs e)
        {
            ///CameraEditor cameraEditorWindow = new CameraEditor();
            //cameraEditorWindow.Show();
        }

        private void sequenceScreenplayEditor_Click(object sender, EventArgs e)
        {
            //SequenceScreenplayEditor sequenceScreenplayEditorWindow = new SequenceScreenplayEditor();
            //sequenceScreenplayEditorWindow.Show();
        }

        public Group EditGroup(Group group, Dictionary<dynamic, string> cameras)
        {
            throw new NotImplementedException();
        }

        public List<Group> EditGroups(List<Group> groups, Dictionary<dynamic, string> camerass)
        {
            throw new NotImplementedException();
        }
    }
}
