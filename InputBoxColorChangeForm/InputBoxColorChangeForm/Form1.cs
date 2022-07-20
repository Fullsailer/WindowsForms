using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputBoxColorChangeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();// Focuses on text box
            textBox1.BackColor = Color.Red;// Changes text box color to red

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.BackColor = Color.Green;

            listBox1.Focus();// Focuses on list box
            listBox1.BackColor = Color.Green; //Changes color to green when button is clicked

            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            listBox1.Items.Add(textBox1.Text); // Adds items from text box
            listBox1.ClearSelected();
            listBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.Items.Count > 0)
                                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
               

        }

    }
}
