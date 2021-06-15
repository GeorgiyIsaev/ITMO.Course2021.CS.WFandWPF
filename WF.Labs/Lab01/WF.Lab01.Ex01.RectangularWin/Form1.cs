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
    public partial class Form1 : Form
    {
        nForm myF2;
        public Form1()
        {
            myF2 = new nForm();
            InitializeComponent();
        }

        private void Button_BorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Button_Resize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500, 100);
        }

        private void Button_Opacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Button_nForm_Click(object sender, EventArgs e)
        {
            myF2 = new nForm();
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            myF2.Show();
        }    
    }
}
