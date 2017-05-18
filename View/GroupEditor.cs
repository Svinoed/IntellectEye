using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class GroupEditor : Form
    {

        int controlButtonGroupBoxHeight = 41;
        public GroupEditor()
        {
            InitializeComponent();
            
            groupList.Width = splitContainer1.Panel1.Width;
            groupList.Height = splitContainer1.Panel1.Height- controlButtonGroupBoxHeight;
            controlButtonGroupBox.Location = new Point(splitContainer1.Location.X, splitContainer1.Height - controlButtonGroupBoxHeight);
            controlButtonGroupBox.Height = controlButtonGroupBoxHeight;
            controlButtonGroupBox.Width = splitContainer1.Panel1.Width;
            //splitContainer2.SplitterWidth = 50;
            treeView1.Dock = DockStyle.Fill;
            listBox1.Dock = DockStyle.Fill;
        }
        

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.groupList.Width = this.splitContainer1.Panel1.Width;
            controlButtonGroupBox.Width = splitContainer1.Panel1.Width;
        }
        
        private void GroupEditor_Resize(object sender, EventArgs e)
        {
            groupList.Height = splitContainer1.Panel1.Height - controlButtonGroupBoxHeight;
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
    }
}
