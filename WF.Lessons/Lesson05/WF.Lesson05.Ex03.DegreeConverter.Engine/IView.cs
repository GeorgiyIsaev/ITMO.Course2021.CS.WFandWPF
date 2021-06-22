using System;

namespace DegreeConverter.Engine
{
	public interface IView
	{
		/// <summary>
		/// Вывод градусов Фаренгейта
		/// </summary>
		void SetFarenheit(double Degree);

		/// <summary>
		/// Вывод градусов Цельсия
		/// </summary>
		void SetCelsius(double Degree);

		/// <summary>
		/// Ввод нового значения градусов
		/// </summary>
		double InputDegree { get; }

		/// <summary>
		/// Событие ввода значения по Фаренгейту
		/// </summary>
		event EventHandler<EventArgs> FarenheitSetted;

		/// <summary>
		/// Событие ввода значения по цельсию
		/// </summary>
		event EventHandler<EventArgs> CelsiusSetted;
	}
}