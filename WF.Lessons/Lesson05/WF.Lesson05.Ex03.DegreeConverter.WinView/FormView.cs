using System;
using System.Windows.Forms;
using DegreeConverter.Engine;

namespace DegreeConverter.WinView
{
	public partial class FormView : Form, IView
	{
		public FormView()
		{
			InitializeComponent();
		}

		#region Реализация IView

		/// <summary>
		/// Вывод градусов Фаренгейта
		/// </summary>
		public void SetFarenheit(double Degree)
		{
			_farenheitBox.Text = Degree.ToString("N2"); 
		}

		/// <summary>
		/// Вывод градусов Цельсия
		/// </summary>
		public void SetCelsius(double Degree)
		{
			_celsiusBox.Text = Degree.ToString("N2"); 
		}

		/// <summary>
		/// Ввод нового значения градусов
		/// </summary>
		public double InputDegree
		{
			get { return Convert.ToDouble(_inputBox.Text); }
		}

		/// <summary>
		/// Событие ввода значения по Фаренгейту
		/// </summary>
		public event EventHandler<EventArgs> FarenheitSetted;

		/// <summary>
		/// Событие ввода значения по цельсию
		/// </summary>
		public event EventHandler<EventArgs> CelsiusSetted;

		#endregion

		/// <summary>
		/// Обработка событий тоже примитивна, они просто пробрасываются
		/// в соответствующие события Presenter-а
		/// </summary>
		private void _celsiusButton_Click(object sender, EventArgs e)
		{
			if (CelsiusSetted != null)
				CelsiusSetted(this, EventArgs.Empty);
		}

		private void _farenheitButton_Click(object sender, EventArgs e)
		{
			if (FarenheitSetted != null)
				FarenheitSetted(this, EventArgs.Empty);
		}
	}
}