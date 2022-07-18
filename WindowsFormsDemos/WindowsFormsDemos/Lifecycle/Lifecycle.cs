using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDemos.CustomDialog;

namespace WindowsFormsDemos
{
    public partial class Lifecycle : Form
    {
        public Lifecycle()
        {
            InitializeComponent();
        }

        //Loads data into form.
        private void Lifecycle_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Oranges");
            listBox1.Items.Add("Grapes");
            listBox1.Items.Add("Bananas");
            listBox1.Items.Add("Peaches");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmDialog f = new ConfirmDialog();
            f.ShowDialog();
            label1.Text = listBox1.Text;
        }
    }
}
