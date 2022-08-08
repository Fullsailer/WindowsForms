using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl1.SelectTab("tabPage2"); //Selects the tab to show at launch
            tabControl1.SelectedIndex = 2; // Zero indexed so 2 is actually tab 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tpage = new TabPage("Page");
            Label l1 = new Label();
            l1.Text = "Tab";
            tpage.Controls.Add(l1);
            tabControl1.TabPages.Add(tpage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                tabPage1.BackColor = Color.Green;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                tabPage2.BackColor = Color.Yellow;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                tabPage3.BackColor = Color.Blue;
            }
        }
    }
}
