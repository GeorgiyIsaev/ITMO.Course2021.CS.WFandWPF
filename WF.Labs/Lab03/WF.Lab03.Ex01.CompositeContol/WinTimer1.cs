using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab03.Ex01.CompositeContol
{
    public partial class WinTimer1 : Form
    {
        public WinTimer1()
        {
            InitializeComponent();             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                userControlTimer1.TimeEnabled = false;
            }
            else
            {
                userControlTimer1.TimeEnabled = true;
            }

        }
    }
}
