using System;

namespace DegreeConverter.Engine
{
	public interface IView
	{
		/// <summary>
		/// ����� �������� ����������
		/// </summary>
		void SetFarenheit(double Degree);

		/// <summary>
		/// ����� �������� �������
		/// </summary>
		void SetCelsius(double Degree);

		/// <summary>
		/// ���� ������ �������� ��������
		/// </summary>
		double InputDegree { get; }

		/// <summary>
		/// ������� ����� �������� �� ����������
		/// </summary>
		event EventHandler<EventArgs> FarenheitSetted;

		/// <summary>
		/// ������� ����� �������� �� �������
		/// </summary>
		event EventHandler<EventArgs> CelsiusSetted;
	}
}