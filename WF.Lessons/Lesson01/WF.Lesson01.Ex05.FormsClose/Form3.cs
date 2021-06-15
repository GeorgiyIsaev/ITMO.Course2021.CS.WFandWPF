using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsClose
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Formm.myF2.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formm.myF2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formm.mainForm.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formm.mainForm.Close();
        }
    }
}
