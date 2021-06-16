using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample_Delegate
{
    public partial class Form1 : Form
    {
        FormatNumbers.FormatSingle formatText;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TextBox2.Text = formatText(Convert.ToSingle(TextBox1.Text));
        }

        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.percentRadioButton.Checked)
            {
                formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnPercentage);
            }
        }

        private void dollarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dollarRadioButton.Checked)
            {
                formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnDollars);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnPercentage);
        }
    }
    public class FormatNumbers
    {
        public delegate string FormatSingle(float number);

        public static string returnDollars(float number)
        {
            return string.Format("{0:C}", number);
        }

        public static string returnPercentage(float number)
        {
            return string.Format("{0:P}", number);
        }
    }
}
