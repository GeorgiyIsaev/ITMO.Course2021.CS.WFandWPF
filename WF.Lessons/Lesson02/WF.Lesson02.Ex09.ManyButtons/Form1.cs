using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Button b = sender as Button;
            Button b = (Button)sender;
         if(b!= null)   ShowForms((string)b.Tag);
        }

        private void ShowForms(string tag)
        {
            switch (tag)
            {
                case "1":
                    Form2 f1 = new Form2();
                    f1.Show();
                    break;
                case "2":
                    Form3 f3 = new Form3();
                    f3.Show();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COM");
        }
    }
}
