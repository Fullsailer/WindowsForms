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

namespace WindowsFormsDemos.Dialog
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialog = new ConfirmDialog();

            if (dialog.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Oranges");
            listBox1.Items.Add("Grapes");
            listBox1.Items.Add("Bananas");
            listBox1.Items.Add("Peaches");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                var msg = "Please select an item from the list box";
                MessageBox.Show(msg, this.Text);
                return;
            }
            label1.Text = listBox1.Text;
        }

    }
}
