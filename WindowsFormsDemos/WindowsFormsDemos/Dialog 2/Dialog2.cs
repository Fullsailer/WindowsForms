using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemos.Dialog_2
{
    public partial class Dialog2 : Form
    {
        public Dialog2()
        {
            InitializeComponent();
        }
        
        private void Dialog2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var msg = "Are you sure you want to close?";

            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Dialog2_Load(object sender, EventArgs e)
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
            else
            {
                label1.Text = listBox1.Text;
            }
        }

    }
}
