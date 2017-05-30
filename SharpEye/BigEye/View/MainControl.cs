﻿using System;
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
using System.Threading;

namespace View
{
    public partial class MainControl : UserControl, IMainView, ILogView
    {

        public bool ViewVisible { get { return this.Visible; } set { this.Visible = value; } }


        public event Action<Group> CamEditClick;
        public event Action GroupsEditClick;
        public event Action<Group> GroupSelected;

        private TableLayoutPanel _videoLiveTable;
        private Dictionary<Guid, Group> _groups;
        public MainControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DrawAll();
            //_videoLiveTable = new TableLayoutPanel();
            listGroup.View = System.Windows.Forms.View.List;
            _videoLiveTable = new TableLayoutPanel();
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
            listGroup.Dock = DockStyle.Fill;

            videoLivePanel.Anchor = (AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right);

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



        private void groupEditor_MouseClick(object sender, MouseEventArgs e)
        {

            groupEditor.BackColor = SystemColors.ButtonHighlight;//.ButtonShadow;
            //GroupEditor groupEditorWindow = new GroupEditor();
            //groupEditorWindow.Show();
        }

        private void cameraEditor_MouseClick(object sender, MouseEventArgs e)
        {
            CameraEditor cameraEditorWindow = new CameraEditor();
            cameraEditorWindow.Show();
        }

        private void sequenceScreenplayEditor_MouseClick(object sender, MouseEventArgs e)
        {
            //SequenceScreenplayEditor sequenceScreenplayEditorWindow = new SequenceScreenplayEditor();
            //sequenceScreenplayEditorWindow.Show();
        }

        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
        

        #region AddListVideoLiveControl by dima. Refactor shukur
        /// <summary>
        /// Добавляет список контролов для отображения видео
        /// </summary>
        /// <param name="list"></param>

        public void AddListVideoLiveControl(List<ISmallView> list)
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
            _videoLiveTable.Dock = DockStyle.Fill;
            _videoLiveTable.Controls.Clear();
            _videoLiveTable.RowCount = rows;
            _videoLiveTable.ColumnCount = columns;
            float height = 100 / rows;
            float width = 100 / columns;

            for (int i = 0; i < rows; i++)
            {
                _videoLiveTable.RowStyles.Add(new RowStyle(SizeType.Percent, height));
            }

            for (int i = 0; i < columns; i++)
            {
                _videoLiveTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, width));
            }

            foreach (var c in list)
            {
                UserControl smallControl = (UserControl)c;
                smallControl.Dock = DockStyle.Fill;
                _videoLiveTable.Controls.Add(smallControl);

            }

            videoLivePanel.Controls.Clear();
            videoLivePanel.Controls.Add(_videoLiveTable);

        }

        #endregion

        public Group EditGroup(Group group, Dictionary<dynamic, string> cameras)
        {
            throw new NotImplementedException();
        }

        #region this co by shukur

            #region EditGroups
            /// <summary>
            /// Вызвает окно редактирования групп и
            /// передает ей актуальный список камер и групп
            /// </summary>
            /// <param name="groups"></param>
            /// <param name="cameras"></param>
            /// <returns></returns>
            public Dictionary<Guid, Group> EditGroups(Dictionary<Guid, Group> groups, Dictionary<dynamic, string> cameras)
            {
                GroupEditor groupEditor = new GroupEditor(groups, cameras);
                groupEditor.ShowDialog();
                return groupEditor.EditedGrops;
            }

        private void groupEditor_Click(object sender, EventArgs e)
        {
            GroupsEditClick?.Invoke();
        }
        #endregion

        #region Set list group
        public void SetGroups(Dictionary<Guid, Group> groups, Guid activeGroup)
        {
            _groups = groups;
            listGroup.Items.Clear();
            foreach(var g in groups)
            {
                ListViewItem item = new ListViewItem(g.Value.Name);
                item.Tag = g.Value;
                listGroup.Items.Add(item);
            }
        }
        #endregion

        #region Playback

        public void AddPlaybackControl(IPlaybackView view)
        {
            throw new NotImplementedException();
        }

        public void AddListPlayBack(List<IPlaybackView> list)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion


        private void cameraEditor_Click(object sender, EventArgs e)
        {

        }
        

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            SearchVideo searchVideo = new SearchVideo();
            searchVideo.Show();
        }

        private void listGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listGroup_Click(object sender, EventArgs e)
        {
            if (GroupSelected != null)
            {
                if (listGroup.SelectedItems.Count > 0)
                {
                    Group g = (Group)listGroup.SelectedItems[0].Tag;
                    GroupSelected(g);
                }
            }
        }
    }
}
