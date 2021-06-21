using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab04.Ex03.InteractionOfComponentsAndClass
{
    public partial class EditPersonForm : Form
    {
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }
        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        Person p;
        public EditPersonForm(Person p)
        {
            InitializeComponent();
            this.p = p;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Age = p.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }

    }
}
