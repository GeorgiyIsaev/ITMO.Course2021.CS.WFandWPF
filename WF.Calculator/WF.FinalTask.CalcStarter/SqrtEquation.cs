using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SqrtEquation : Form
    {
        public SqrtEquation()
        {
            InitializeComponent();
        }

        private void ButtonCloseSqrt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEqualSqrt_Click(object sender, EventArgs e)
        {
            if (TextBoxA.Text == "") TextBoxA.Text = "0";
            if (TextBoxB.Text == "") TextBoxB.Text = "0";
            if (TextBoxC.Text == "") TextBoxC.Text = "0";

            double a;
            Double.TryParse(TextBoxA.Text, out a); 
            double b;
            Double.TryParse(TextBoxB.Text, out b);
            double c;
            Double.TryParse(TextBoxC.Text, out c);


            int i = CalcRoots(a, b, c, out double x1, out double x2);

            if (i > 0)
            {
                ResultOut.Text = "Корни для уравнения:\n" +
                    $"{a}*x^2 + {b} * x + {c} = 0\n\n" + 
                    "РАВНЫ: x1 = " + x1 + ",  x2 = " + x2 + ";";
            }
            else if (i == 0)
            {
                ResultOut.Text = "Один корнь для уравнения:\n" +
                    $"{a}*x^2 + {b} * x + {c} = 0\n\n" +
                    "РАВЕН: x1 = " + x1 + ";";
              
            }
            else
            {
                ResultOut.Text = "Корней для уравнения:\n" +
                $"{a}*x^2 + {b} * x + {c} = 0   --> НЕТ!";   
            }
        }

        public static int CalcRoots(double a, double b, double c, out double x1, out double x2)
        {
            int i = 0;
            x1 = 0;
            x2 = 0;

            if (a == 0 && b == 0 && c!=0)
            {
                i = -1;
                return i;
            }

            double d = b * b - 4 * a * c;            
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                i = 1;
                return i;
            }
            else if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                i = 0;
                return i;
            }
            else
            {
                i = -1;
                return i;
            }
        }

        private void TextBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;
                errorProvider1.SetError(TextBoxA, string.Empty);

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(TextBoxA, "Можно вводить только цифры");
            }
            else
            {
                errorProvider1.SetError(TextBoxA, string.Empty);
            }
        }

        private void TextBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;
                errorProvider1.SetError(TextBoxB, string.Empty);

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(TextBoxB, "Можно вводить только цифры");
            }
            else
            {
                errorProvider1.SetError(TextBoxB, string.Empty);
            }
        }

        private void TextBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {        
            if ((e.KeyChar == '-') || (e.KeyChar == '.'))
            {
                e.Handled = false;   
                errorProvider1.SetError(TextBoxC, string.Empty);                 

            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;               
                errorProvider1.SetError(TextBoxC, "Можно вводить только цифры");
            }
            else
            {
                errorProvider1.SetError(TextBoxC, string.Empty);
            }   
        }
    }
}
