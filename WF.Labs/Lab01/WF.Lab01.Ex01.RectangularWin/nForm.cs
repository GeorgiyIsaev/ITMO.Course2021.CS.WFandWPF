using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab01.Ex01.RectangularWin
{
    public partial class nForm : Form
    {
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckBox_Exit.Checked || nclose) return;
            e.Cancel = true; Hide();
        }
        private bool nclose = false;
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public new void Close()
        {
            nclose = true;
            base.Close();
        }
    }
}
