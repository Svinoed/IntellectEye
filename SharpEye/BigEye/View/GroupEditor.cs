using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Utils;
using static System.Windows.Forms.ListView;

namespace View
{
    public partial class GroupEditor : Form
    {
        // By shukur
        private Dictionary<Guid, Group> _groups;
        private Dictionary<dynamic, string> _cameras;
        private Group _selectedGroup;

        int controlButtonGroupBoxHeight = 41;

        public GroupEditor(Dictionary<Guid, Group> groups, Dictionary<dynamic, string> cameras)
        {
            InitializeComponent();
            
            listGroup.Width = splitContainer1.Panel1.Width;
            listGroup.Height = splitContainer1.Panel1.Height- controlButtonGroupBoxHeight;
            controlButtonGroupBox.Location = new Point(splitContainer1.Location.X, splitContainer1.Height - controlButtonGroupBoxHeight);
            controlButtonGroupBox.Height = controlButtonGroupBoxHeight;
            controlButtonGroupBox.Width = splitContainer1.Panel1.Width;
            //splitContainer2.SplitterWidth = 50;
            listCamera.Dock = DockStyle.Fill;

            // This code by shukur
            _groups = groups;
            _cameras = cameras;
        }


        #region LoadCameras by shukur
        private void LoadCameras()
        {
            
            foreach(var c in _cameras)
            {
                if (CameraContains(c, listCameraGroup.Items))
                {
                    ListViewItem item = new ListViewItem(c.Value);
                    item.Tag = c;
                    listCamera.Items.Add(item);
                }
            }
        }

        private bool CameraContains(KeyValuePair<dynamic, string> camera,  ListViewItemCollection items)
        {
            foreach (ListViewItem c in items)
            {
                KeyValuePair<dynamic, string> keyValue = (KeyValuePair<dynamic, string>) c.Tag;

                if (keyValue.Key == camera.Key) 
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.listGroup.Width = this.splitContainer1.Panel1.Width;
            controlButtonGroupBox.Width = splitContainer1.Panel1.Width;
        }
        
        private void GroupEditor_Resize(object sender, EventArgs e)
        {
            listGroup.Height = splitContainer1.Panel1.Height - controlButtonGroupBoxHeight;
            controlButtonGroupBox.Location = new Point(splitContainer1.Location.X, splitContainer1.Height - controlButtonGroupBoxHeight);
            controlButtonGroupBox.Height = controlButtonGroupBoxHeight;
            controlButtonGroupBox.Width = splitContainer1.Panel1.Width;
        }

        private void addButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Active = true;
            toolTip1.ToolTipTitle = "gbvvf";
            
        }

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Active = true;
            toolTip1.ToolTipTitle = "gbvvf";
        }

        #region Load by shukur
        /// <summary>
        /// Отображает список групп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupEditor_Load(object sender, EventArgs e)
        {
            foreach (var g in _groups)
            {
                ListViewItem item = new ListViewItem(g.Value.Name);
                item.Tag = g.Value;
                listGroup.Items.Add(item);
            }
        }
        #endregion

        private void addButton_Click(object sender, EventArgs e)
        {
            // by shukur
        }

        /// <summary>
        /// Отображает выбранную группу и 
        /// корректирует список камер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // by shukur
            ListViewItem item  = listGroup.SelectedItems[0];
            Group group = (Group) item.Tag;
            if (_selectedGroup == group)
            {
                return;
            }
            _selectedGroup = group;
            groupNameTextBox.Text = _selectedGroup.Name;
            foreach (var c in _selectedGroup.Cameras)
            {
                ListViewItem itemCam = new ListViewItem(c.Value); // Устанавливаем имя камеры
                itemCam.Tag = c;
                listCameraGroup.Items.Add(itemCam);
            }
            LoadCameras();

        }

        #region Move Camera by shukur
        /// <summary>
        /// Удаляет камеру из группы и
        /// добавляет её в общий список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveRight(object sender, EventArgs e)
        {
            HorizoltalItemsMovement(listCameraGroup, listCamera);
        }

        /// <summary>
        /// Добавляет камеру в группу и 
        /// удаляетт её из общего списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveLeft(object sender, EventArgs e)
        { 
            HorizoltalItemsMovement(listCamera, listCameraGroup);
        }

        private void MoveUp(object sender, EventArgs e)
        {
            VerticalItemsMovement(listCamera,-1);
            VerticalItemsMovement(listCameraGroup, -1);
        }

        private void VerticalItemsMovement(ListView listView, int step)
        {
       
            foreach (ListViewItem item in listView.SelectedItems)
            {
                if ((item.Index > 0 && step == -1) 
                    || (item.Index == listView.Items.Count && step == 1))
                {
                    int index = item.Index + step;
                    listView.Items.RemoveAt(item.Index);
                    listView.Items.Insert(index, item);
                }
            }
        }

        private void HorizoltalItemsMovement(ListView from, ListView to)
        {
            var items = from.SelectedItems;

            foreach (ListViewItem item in items)
            {
                KeyValuePair<dynamic, string> keyValue = (KeyValuePair<dynamic, string>)item.Tag;
                if (!CameraContains(keyValue, to.Items))
                {
                    from.Items.Remove(item);
                    to.Items.Add(item);
                }
            }
        }

        private void MoveDown(object sender, EventArgs e)
        {
            VerticalItemsMovement(listCamera, 1);
            VerticalItemsMovement(listCameraGroup, 1);
        }
        #endregion
    }
}
