using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemos
{
    public partial class MenuandToolbars : Form
    {
        public MenuandToolbars()
        {
            InitializeComponent();
        }

        private void MenuandToolbars_Load(object sender, EventArgs e)
        {

        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox("You cliked the New Button");
        }

        private void MessageBox(string v)
        {
            throw new NotImplementedException();
        }
    }
}
