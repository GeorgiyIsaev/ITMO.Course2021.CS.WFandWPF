using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Person myPerson = null;
        public Form1()
        {
            InitializeComponent();
            Text = "Текст конструктора по умолчанию";
            myPerson = new Person();
        }

        public Form1(string title, int height, int width)
        {
            InitializeComponent();

            Text = title;
            Width = width;
            Height = height;

            // Inherited method to center the form on the screen.
            CenterToScreen();
            myPerson = new Person();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Сегодня " + DateTime.Today.ToLongDateString());

            label1.Text = "Сегодня " + DateTime.Today.ToLongDateString();

            // this.Location.X = 100; 
            Point tmpLocation = this.Location;
            tmpLocation.X += 10;
            tmpLocation.Y += 10;
            this.Location = tmpLocation;

            this.Size = new System.Drawing.Size(800, 300);

            this.button1.FlatStyle = FlatStyle.Flat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] stringArray = new string[3];

            stringArray[0] = "Да";
            stringArray[1] = "Нет";
            stringArray[2] = "Возможно";

            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[3];

            for (int i = 0; i < 3; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = stringArray[i];
                radioButtons[i].Location = new System.Drawing.Point(10, 10 + i * 20);
                this.Controls.Add(radioButtons[i]);
            }

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(82, 29);
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(77, 23);
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Обработчик события Load";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // label2.Text = "Здравствуйте, " + yourName.Text; 
            label2.Text = "Здравствуйте, " + myPerson;

        }

        private void yourName_Leave(object sender, EventArgs e)
        {
            myPerson.FirstName = yourName.Text;
        }
    }
}
