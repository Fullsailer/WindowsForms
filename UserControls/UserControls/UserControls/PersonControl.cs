using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private Person _person;

        public Person Person
        {
            get
            {
                _person.FirstName = FirstNametextBox.Text;
                _person.LastName = LastNametextBox.Text;
                _person.Age = Convert.ToInt32(AgetextBox.Text);
                return _person;
            }
            set
            {
                FirstNametextBox.Text = value.FirstName;
                LastNametextBox.Text = value.LastName;
                AgetextBox.Text = value.Age.ToString();
                _person = value;
            }
        }
    }
}
