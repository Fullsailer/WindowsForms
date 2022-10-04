using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            try
            {
                listView1.Columns.Add("Name", 250);
                listView1.Columns.Add("Date modified", 150);
                listView1.Columns.Add("Size", 75, HorizontalAlignment.Right);
                ViewToolStripComboBox.SelectedIndex = 0;

                var docs = new TreeNode("Me Documents");
                docs.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                treeView1.Nodes.Add(docs);

                GetFolder(docs);
                docs.Expand();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var dir = new DirectoryInfo(e.Node.Tag.ToString());

            listView1.Items.Clear();
            SmallImageList.Images.RemoveByKey(".exe");
            LargeImageList.Images.RemoveByKey(".exe");
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                var lastWrite = file.LastWriteTime;
                item.SubItems.Add(lastWrite.ToShortDateString() + " " + lastWrite.ToShortTimeString());
                item.SubItems.Add(Math.Ceiling(file.Length / 1024.0) + " KB");
            }
        }
    }
}
