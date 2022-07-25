using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int _counter = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Uncomment this code to load the Form with a new childForm already loaded. 
            //var childForm = new ChildForm();
            //childForm.MdiParent = this;
            //childForm.Text = "New Document " + ++_counter;
            //childForm.Show();
        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.MdiParent = this;
            //childForm.Text = "New Document " + ++_counter;
            childForm.Show();
        }
    }
}
