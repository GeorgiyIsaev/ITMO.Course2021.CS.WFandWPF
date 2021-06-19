using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab03.Ex04.Task01.LabelValid
{
    public partial class TextBoxValid : UserControl
    {
        public TextBoxValid()
        {
            InitializeComponent();
        }

        public string TextA
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string TextB
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }




        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Не заполнено имя");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Не заполнен возраст");
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                    errorProvider2.SetError(textBox2, string.Empty);
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider2.SetError(textBox2, "Возраст должен быть числом");
                    MessageBox.Show("Возраст должен быть числом");
                }
            }
        }
    }
}
