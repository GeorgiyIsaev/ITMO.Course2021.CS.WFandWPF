using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSingleton
{
    public partial class Form1 : Form
    {
        Form2 mf;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          mf = Form2.metf2;
 
              mf.Show();
              mf.Activate();
        }
    }
}
