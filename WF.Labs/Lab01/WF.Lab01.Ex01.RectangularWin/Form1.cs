﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Ex01.RectangularWin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
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
    }
}
