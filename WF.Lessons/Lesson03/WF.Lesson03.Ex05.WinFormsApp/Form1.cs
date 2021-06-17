using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ButtonLibrary;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        BeepButtonExclamation btn;

        public Form1()
        {
            btn = new BeepButtonExclamation();

            Controls.Add(btn);
            InitializeComponent();
        }

        private void beepButtonExclamation1_Click(object sender, EventArgs e)
        {
            btn.Text = "Start";
            beepButtonExclamation1.Text = "Beep";
            //   var but = (Button)sender;
           //   but.Text = "Fin";
        }
    }
}
