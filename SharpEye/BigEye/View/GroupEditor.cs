using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private ListViewItem _selectedGroupItem;
        private bool _isChangedCameraList;
        private bool _isChangedName;
        private bool _isChangedListGrup;
        public Dictionary<Guid, Group>  Result { get; set; }

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
            _groups = new Dictionary<Guid, Group> (groups); // клонируем коллекцию
            _cameras = cameras;
            groupNameTextBox.LostFocus += (s, e) => GroupRename(s, e);
            _isChangedCameraList = false;
            _isChangedName = false;
            _isChangedListGrup = false;
        }

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

        #region LoadCameras by shukur
        private void LoadCameras()
        {
            listCamera.Items.Clear();
            foreach (var c in _cameras)
            {
                if (!CameraContains(c, listCameraGroup.Items))
                {
                    ListViewItem item = new ListViewItem(c.Value);
                    item.Tag = c;
                    listCamera.Items.Add(item);
                }
            }
        }

        private bool CameraContains(KeyValuePair<dynamic, string> camera, ListViewItemCollection items)
        {
            foreach (ListViewItem c in items)
            {
                KeyValuePair<dynamic, string> keyValue = (KeyValuePair<dynamic, string>)c.Tag;

                if (keyValue.Equals(camera))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion

        #region Add and Delete group bu shukur
        private void addButton_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Name = GetNewName();
            ListViewItem item = new ListViewItem(group.Name);
            item.Tag = group;
            listGroup.Items.Add(item);
            _groups.Add(group.Id, group);
            Result = _groups;
        }

        private string GetNewName()
        {
            return GetActualName("Новая группа", "Новая группа");
        }
        private string GetActualName(string name, string oldName)
        {
            string newName = name;
            for (int i = 0; i < _groups.Values.Count; i++ )
            {
               if (_groups.Values.ElementAt(i).Name.Equals(name))
                {
                    newName = GetActualName(oldName + i, oldName);
                    return newName; 
                }
            } 
            return newName;
        }



        #endregion

        #region Filter by shukur

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter(listCamera, searchTextBox.Text);
        }

        private void Filter(ListView list, string filter)
        {
            list.Items.Clear();
            foreach (var c in _cameras)
            {
                if (c.Value.ToString().StartsWith(filter))
                {
                    ListViewItem item = new ListViewItem(c.Value);
                    item.Tag = c;
                    list.Items.Add(item);
                }
            }
        }
        #endregion

        /// <summary>
        /// Отображает выбранную группу и 
        /// корректирует список камер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // by shukur

            if (listGroup.SelectedItems.Count <= 0)
            {
                Debug.WriteLine("GroupEditorControl selectedItems count <=  0");
                return;
            }

            if (_isChangedCameraList | _isChangedName)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Сохранить изменения ?",
                    _selectedGroupItem.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);

                if(dialogResult == DialogResult.Yes)
                {
                    Save();
                }
            }
            _isChangedCameraList = false;
            ListViewItem item  = listGroup.SelectedItems[0];
            Group group = (Group) item.Tag;
            if (_selectedGroupItem == item)
            {
                return;
            }
            _selectedGroupItem = item;
            groupNameTextBox.Text = _selectedGroupItem.Text;
            listCameraGroup.Items.Clear();
            foreach (var c in group.Cameras)
            {
                ListViewItem itemCam = new ListViewItem(c.Value);
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
            HorizoltalItemsMovement(listCamera, listCameraGroup);
        }

        /// <summary>
        /// Добавляет камеру в группу и 
        /// удаляетт её из общего списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveLeft(object sender, EventArgs e)
        { 
            HorizoltalItemsMovement(listCameraGroup, listCamera);
        }

        private void MoveUp(object sender, EventArgs e)
        {
            VerticalItemsMovement(listCamera,-1);
            VerticalItemsMovement(listCameraGroup, -1);
        }

        private void VerticalItemsMovement(ListView listView, int step)
        {
            _isChangedCameraList = true;
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
            _isChangedCameraList = true;
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

        #region Save and cancel by shukur
        private void SaveBtnClick(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (_selectedGroupItem == null)
            {
                Debug.WriteLine("selectedGroup null");
                return;
            }
            Group changedGroup = (Group)_selectedGroupItem.Tag;
            if (_isChangedCameraList)
            {
                changedGroup.Cameras.Clear();
                foreach (ListViewItem item in listCameraGroup.Items)
                {
                    KeyValuePair<dynamic, string> keyValue = (KeyValuePair<dynamic, string>)item.Tag;
                    changedGroup.Cameras.Add(keyValue.Key, keyValue.Value);
                }
                _isChangedCameraList = false;
            }
         
            if (_isChangedName)
            {
                if (!_selectedGroupItem.Name.Equals(groupNameTextBox.Text))
                {
                    _selectedGroupItem.Text = groupNameTextBox.Text;
                    changedGroup.Name = groupNameTextBox.Text;
                    _isChangedName = false;
                }
            }
            Result = _groups;
        }
        #endregion

        private void GroupRename(object sender, EventArgs e)
        {
            if (!_selectedGroupItem.Text.Equals(groupNameTextBox.Text))
            {
                _isChangedName = true;
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Выдействительно хотите удалить группу " + _selectedGroupItem.Text + " ?",
                "Удалить ?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);

            if (result == DialogResult.Yes)
            {
                listGroup.Items.Remove(_selectedGroupItem);
                Group deletedGroup = (Group) _selectedGroupItem.Tag;
                _groups.Remove(deletedGroup.Id);
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {

            if (Result != null)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите отменить все изменения?",
                "Отменить", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    Result = null;
                    this.Close();
                }
            }     
        }
    }
}
