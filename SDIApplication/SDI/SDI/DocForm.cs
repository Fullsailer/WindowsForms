using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        private static int _counter = 0;

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.DocumentTextBox.LoadFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            dialog.AddExtension = true;
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.DocumentTextBox.SaveFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Redo();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.SelectAll();
        }

        public static DocForm CreateForm()
        {
            var form = new DocForm();
            form.Text = "New Document " + ++_counter;
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();

            return form;
        }


        //***TO DO ***//
        //Fix Window Dropdown Menu to show a list of open forms in the drop down. This is based on the Visual Basic Code and needs refactoring. 
        //private void windowToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        //{
        //    if (windowToolStripMenuItem.DropDownItems.Count > 0)
        //    {
        //        windowToolStripMenuItem.DropDownItems.Clear();
        //    }

        //    windowToolStripMenuItem.DropDown = new ToolStripDropDown()
        //        foreach (OpenFileDialog fileDialog in Application.OpenForms)
        //    {
        //        childItem as new ToolStripMenuItem()
        //            childItem.Text = openForm.Text;
        //        childItem.Tag = openForm;
        //            windowToolStripMenuItem.DropDownItems.Add(childItem)
        //            childItem.Click, WindowMenutItemClick;
        //    }
        //}
        //private void windowToolStripMenuItem(object sender, EventArgs e)
        //{
        //    MenuItem = object(sender, ToolStripMenuItem)
        //        form = object(MenuItem.Tag, From)
        //        form.Activate();
        //}
    }
}
