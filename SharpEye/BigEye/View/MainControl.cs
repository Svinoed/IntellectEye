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

        public bool ViewVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public event Action CameraSelected;
        public event Action<string> CamEditClick;
        public event Action GropsEditClick;

        private TableLayoutPanel _videoTable;

        public MainControl()
        {
            InitializeComponent();
            DrawAll();
            _videoTable = new TableLayoutPanel();
        }


        #region DrawAll
        private void DrawAll()
        {
            this.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);
            this.Dock = DockStyle.Fill;
            tabControl.Location = this.Location;

            panel1.Location = new Point(tabControl.Width - panel1.Width, tabControl.Location.Y);
            panel1.Height = tabControl.ItemSize.Height;

            searchTextBox.Multiline = false;
            searchTextBox.Anchor = AnchorStyles.Left;
            searchTextBox.WordWrap = false;

            panel2.Height = 35;
            panel2.Width = 180;
            //panel2.Location = new Point(livePage.Width - panel2.Width, 0);

            groupPanel.Width = 180;
            groupPanel.Location = new Point(panel2.Location.X, panel2.Location.Y + panel2.Height);
            listView1.Dock = DockStyle.Fill;


            panel3.Location = new Point(tabControl.Width - panel1.Width, tabControl.Location.Y);
        }

        #endregion

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

        #region InterfacesImplementation
        public void AddVideoControl(IVideoView view)
        {
            // для одной камеры
            Panel panel = view.VideoPanel;
            panel.Dock = DockStyle.Fill;
            livePage.Controls.Add(panel);
        }

        public void AddList(List<ISmallView> viewList)
        {
        }

        public void SetCameraList(string[] cameras)
        {
            //string[] temp = { "K1", "K2" }; 
            //cameraComboBox.Items.AddRange(cameras);
        }
#endregion

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

            //groupEditor.BackColor = SystemColors.ButtonHighlight;//.ButtonShadow;
            //GroupEditor groupEditorWindow = new GroupEditor();
            //groupEditorWindow.Show();
        }

        private void cameraEditor_MouseClick(object sender, MouseEventArgs e)
        {
            //CameraEditor cameraEditorWindow = new CameraEditor();
            //cameraEditorWindow.Show();
        }

        private void sequenceScreenplayEditor_MouseClick(object sender, MouseEventArgs e)
        {
            //SequenceScreenplayEditor sequenceScreenplayEditorWindow = new SequenceScreenplayEditor();
            //sequenceScreenplayEditorWindow.Show();
        }

        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Для смены картинки. Не забыть поменять индексы, для итоговой подборки иконок!!!
            if (searchButton.ImageIndex == 4)
                searchButton.ImageIndex = 16;
            else searchButton.ImageIndex = 4;

            //Вызов метода поиска по листу

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void AddListControl(List<ISmallView> list)
        {
            int size = list.Count;
            //валидация
            if (list == null && size == 0)
            {
                return;
            }
            
            int sqrt = (int)Math.Sqrt(size);
            //число столбцов и колонок рассчитывается на основе квадратного корня из размера входящего списка
            int columns;
            if (sqrt * sqrt == size)
            {
                columns = sqrt;
            }
            else
            {
                columns = sqrt + 1;
            }

            int rows;
            if ((columns - 1) * columns >= size)
            {
                rows = columns - 1;
            }
            else
            {
                rows = columns;
            }

            //строится и настраивается таблица
            _videoTable.Dock = DockStyle.Fill;
            _videoTable.Controls.Clear();
            _videoTable.RowCount = rows;
            _videoTable.ColumnCount = columns;
     
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    float height = 100 / rows;
                    float width = 100 / columns;
                    int cell = j + i * columns;

                    _videoTable.RowStyles[cell].SizeType = SizeType.Percent;
                    _videoTable.RowStyles[cell].Height = height;
                    _videoTable.ColumnStyles[cell].SizeType = SizeType.Percent;
                    _videoTable.ColumnStyles[cell].Width = width;

                    if (cell <= size)
                    {
                        UserControl smallControl = (UserControl)list.ElementAt(cell);
                        smallControl.Dock = DockStyle.Fill;
                        _videoTable.Controls.Add(smallControl);
                    }
                }
            }

            videoLivePanel.Controls.Clear();
            videoLivePanel.Controls.Add(_videoTable);
        }

        public Group EditGroup(Group group, Dictionary<dynamic, string> cameras)
        {
            throw new NotImplementedException();
        }

        public List<Group> EditGroups(List<Group> groups, Dictionary<dynamic, string> cameras)
        {
            throw new NotImplementedException();
        }
    }
}
