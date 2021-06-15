using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppScr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width -
                this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);

         //   this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width 
         //       - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);

          //  Size s = SystemInformation.PrimaryMonitorSize;
         //   this.Location = new Point(s.Width - this.Width, s.Height - s.Height); // это верхний правый угол
        }
    }
}
