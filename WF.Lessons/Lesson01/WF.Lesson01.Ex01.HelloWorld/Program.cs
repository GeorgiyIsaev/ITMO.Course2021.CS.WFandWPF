using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace FormWithButton
{
	public class Form1 : Form
	{
		/*Асоциативное отношение - кнопка принадлижит окнку*/
		public Button button1;

		public Form1()
		{
			/*Создание окна и кнопки через код!*/
			this.Text = "Привет Мир";
			button1 = new Button();
			button1.Size = new Size(40, 40);
			button1.Location = new Point(30, 30);
			button1.Text = "Click me";
			/*Необходимо явно указть что эл-т находится в этой форме*/
			this.Controls.Add(button1);

			/*Подписка на событие для кнопки*/
			button1.Click += new EventHandler(button1_Click);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello World");
		}

		[STAThread]
		static void Main()
		{			
			Application.EnableVisualStyles();
			/*Метод Ран вызвает конструктор нашего окна*/
			Application.Run(new Form1());
		}
	}
}