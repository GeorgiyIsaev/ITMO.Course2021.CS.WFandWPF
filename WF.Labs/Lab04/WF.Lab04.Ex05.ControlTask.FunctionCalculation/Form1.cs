using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.Lab04.Ex05.ControlTask.FunctionCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinInterval s = new SinInterval();
            FormRange formRange = new FormRange(out s);
            //formRange.Show(this);
            if (formRange.ShowDialog() == DialogResult.OK)
            {
                label2.Text = $"Левая граница: {s.BeginInterval} - Провая граница{s.EndInterval}";
            }
        }


    }
}
