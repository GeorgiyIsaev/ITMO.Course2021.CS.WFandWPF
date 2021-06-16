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
    public partial class Form1 : Form
    {
        Form2 myF2;
        public Form1()
        {
            myF2 = new Form2();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (myF2 == null)
            //{
            //    myF2 = new Form2();
            //}

            //myF2.Show();
            //myF2.Activate();

            try
            {
                myF2.Show();
                myF2.Activate();

            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new Form2();
                myF2.Text = "Повторное создание формы";
                myF2.Show();
                myF2.Activate();
               // MessageBox.Show("Ошибка: " + ex.Message);
            }

            //catch (NullReferenceException ex)
            //{
            //    MessageBox.Show("Ошибка: " + ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myF2 = new Form2();
            myF2.Show();
            //myF2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsClass.myF3.Show(); // будет иссключение ObjectDisposedException - обращение к удаленному объекту+
            // если вызывать после метода ShowDialog() окно откроется и исключения не будет, 
            // потому что диалоговые окна при закрытии остаются в памяти
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsClass.myF3.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormsClass.myF3.Hide();
        }

    }
}
