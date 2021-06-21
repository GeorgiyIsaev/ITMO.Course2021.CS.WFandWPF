using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                textBox3.Text = "Ошибка типов";
                textBox1.Text = textBox2.Text = "";
                return;
            }

            int res = await Subb(a, b);
            textBox3.Text = res.ToString();
        }

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
           { 
            Thread.Sleep(5000);
            return a - b;
           }
            );
        }
    }
}
