using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemos.Dialog
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e); // <== The `FormClosing` event is fired here.
            var msg = "Are you sure you want to close?";

            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var msg = "Are you sure you want to close?";

        //    if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // <== The `Load` event you were subscribing to is fired here.
            listBox1.Items.Add("Oranges");
            listBox1.Items.Add("Grapes");
            listBox1.Items.Add("Bananas");
            listBox1.Items.Add("Peaches");

            // Subscribing to the `Click` event here as an
            // alternative to relying on the Designer to do it.
            button1.Click += onButton1Clicked;
        }


        //private void Dialog_Load(object sender, EventArgs e)
        //{
        //    listBox1.Items.Add("Oranges");
        //    listBox1.Items.Add("Grapes");
        //    listBox1.Items.Add("Bananas");
        //    listBox1.Items.Add("Peaches");
        //}

        private void onButton1Clicked(object sender, EventArgs e)
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


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (listBox1.SelectedIndex == -1)
        //    {
        //        var msg = "Please select an item from the list box";
        //        MessageBox.Show(msg, this.Text);
        //        return;
        //    }
        //    label1.Text = listBox1.Text;
        //}

    }
}
