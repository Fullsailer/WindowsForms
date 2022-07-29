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

        public static DocForm CreateForm()
        {
            var form = new DocForm();
            form.Text = "New Document " + ++_counter;
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();

            return form;
        }
    }
}
