using System;
using DegreeConverter.Engine;


public partial class _Default : System.Web.UI.Page, IView  
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Presenter presenter = new Presenter(this);
	}

	#region Реализация IView
	
	/// <summary>
	/// Вывод градусов Фаренгейта
	/// </summary>
	public void SetFarenheit(double Degree)
	{
		TextBox2.Text = Degree.ToString("N2");
	}

	/// <summary>
	/// Вывод градусов Цельсия
	/// </summary>
	public void SetCelsius(double Degree)
	{
		TextBox1.Text = Degree.ToString("N2");
	}

	/// <summary>
	/// Ввод нового значения градусов
	/// </summary>
	public double InputDegree
	{
		get { return Convert.ToDouble(TextBox3.Text); }
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
	/// Обработка нажатия на клавишу установки градусов цельсия
	/// </summary>
	protected void Button1_Click(object sender, EventArgs e)
	{
		if (CelsiusSetted != null)
			CelsiusSetted(this, EventArgs.Empty);
	}
	
	/// <summary>
	/// Обработка нажатия на клавишу установки градусов Фаренгейта
	/// </summary>
	protected void Button2_Click(object sender, EventArgs e)
	{
		if (FarenheitSetted != null)
			FarenheitSetted(this, EventArgs.Empty);
	}
}
