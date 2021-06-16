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
    public partial class Form2 : Form
    {
        private bool _close = false;
 
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public new void Close()
        {
            _close = true;
            base.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxClose.Checked ) return;
            // If Close() was called, close the window (instead of hiding it)
            if (_close) return;

            // Hide the window (instead of closing it)
            e.Cancel = true;
            Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
         //   MessageBox.Show("Форма закрыта");
        }
    }
}
