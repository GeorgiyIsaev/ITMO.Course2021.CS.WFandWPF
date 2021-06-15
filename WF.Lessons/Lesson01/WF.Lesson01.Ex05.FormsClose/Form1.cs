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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Formm.myF2.Show(); 
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myF3 = new Form3();
            myF3.Show();
        }
    }
}
