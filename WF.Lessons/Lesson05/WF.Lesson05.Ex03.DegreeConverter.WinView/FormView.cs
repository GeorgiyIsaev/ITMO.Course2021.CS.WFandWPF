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

		#region ���������� IView

		/// <summary>
		/// ����� �������� ����������
		/// </summary>
		public void SetFarenheit(double Degree)
		{
			_farenheitBox.Text = Degree.ToString("N2"); 
		}

		/// <summary>
		/// ����� �������� �������
		/// </summary>
		public void SetCelsius(double Degree)
		{
			_celsiusBox.Text = Degree.ToString("N2"); 
		}

		/// <summary>
		/// ���� ������ �������� ��������
		/// </summary>
		public double InputDegree
		{
			get { return Convert.ToDouble(_inputBox.Text); }
		}

		/// <summary>
		/// ������� ����� �������� �� ����������
		/// </summary>
		public event EventHandler<EventArgs> FarenheitSetted;

		/// <summary>
		/// ������� ����� �������� �� �������
		/// </summary>
		public event EventHandler<EventArgs> CelsiusSetted;

		#endregion

		/// <summary>
		/// ��������� ������� ���� ����������, ��� ������ ��������������
		/// � ��������������� ������� Presenter-�
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