using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab03.Ex04.Task01.LabelValid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (TBValidForm.TextA != "" && TBValidForm.TextB != "")
            {
                string item = TBValidForm.TextA + " (" + TBValidForm.TextB + ")";
                ListBox_NameAndAge.Items.Add(item);
                TBValidForm.TextA = "";
                TBValidForm.TextB = "";
            }
            else
            {
                MessageBox.Show("Данные не в ведены!");
            }
        }
    }
}
