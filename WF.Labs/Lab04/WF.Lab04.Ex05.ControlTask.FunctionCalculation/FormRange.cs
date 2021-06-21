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
    public partial class FormRange : Form
    {
        SinInterval s1 = new SinInterval();
        public FormRange(out SinInterval s)
        {         
            InitializeComponent();
                  s = s1;
            Button_Start.Enabled = false;
        }

        private void Button_Censel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            double a, b;
            if(Double.TryParse(TextBox_Begin.Text,out a) 
                && Double.TryParse(TextBox_End.Text,out b))
            {
                s1.BeginInterval = a;
                s1.EndInterval = b;
            }    
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            double a, b;
            if ((TextBox_Begin.Text != "" || TextBox_End.Text != "")
                && (Double.TryParse(TextBox_Begin.Text, out a)
                && Double.TryParse(TextBox_End.Text, out b)))
            {                
                    s1.BeginInterval = a;
                    s1.EndInterval = b;
                    Button_Start.Enabled = true;                
            }
            else
            {
                Button_Start.Enabled = false;
            }
        }
    }
}
