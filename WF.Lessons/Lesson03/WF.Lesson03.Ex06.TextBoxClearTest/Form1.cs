using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxClearTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = userControlTextClear1.TextB.ToString();
            MessageBox.Show(userControlTextClear1.TextM);
            
        }

        private void userControlTextClear1_ClearText(string stringPassed)
        {
            /*Необходимо добавить в событие ClearText для пользовательского контроль*/
            MessageBox.Show("Выполняется очистка (значение - " + stringPassed + ")", 
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void userControlTextClear1_ButText(int intPassed)
        {
            textBox1.Text = intPassed.ToString();
        }
    }
}
