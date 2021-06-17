using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxClear
{
    public partial class UserControlTextClear : UserControl
    {
        public UserControlTextClear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButText(1);
            TextB = 1; 
        }

        [
         Category("My"),
         Description("Передает значение поля")
        ]
        public string TextM

        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public int TextB { get; set; }

        [
        Category("My"),
        Description("Изменяет цвет кнопки.")
        ]
        public System.Drawing.Color ButtonColor
        {
            get { return button1.BackColor; }
            set { button1.BackColor = value;}
        }



        public delegate void MyEvent(int intPassed);
        [
        Category("Очистка"),
        Description("Реагирует на очистку поля.")
        ]
        public event MyEvent ButText;

        private void button2_Click(object sender, EventArgs e)
        {
            ButText(2);
            TextB = 2;
        }
    }
}
