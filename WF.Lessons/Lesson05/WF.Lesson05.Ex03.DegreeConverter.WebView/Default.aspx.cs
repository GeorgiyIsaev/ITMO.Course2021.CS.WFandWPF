using System;
using DegreeConverter.Engine;


public partial class _Default : System.Web.UI.Page, IView  
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Presenter presenter = new Presenter(this);
	}

	#region ���������� IView
	
	/// <summary>
	/// ����� �������� ����������
	/// </summary>
	public void SetFarenheit(double Degree)
	{
		TextBox2.Text = Degree.ToString("N2");
	}

	/// <summary>
	/// ����� �������� �������
	/// </summary>
	public void SetCelsius(double Degree)
	{
		TextBox1.Text = Degree.ToString("N2");
	}

	/// <summary>
	/// ���� ������ �������� ��������
	/// </summary>
	public double InputDegree
	{
		get { return Convert.ToDouble(TextBox3.Text); }
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
	/// ��������� ������� �� ������� ��������� �������� �������
	/// </summary>
	protected void Button1_Click(object sender, EventArgs e)
	{
		if (CelsiusSetted != null)
			CelsiusSetted(this, EventArgs.Empty);
	}
	
	/// <summary>
	/// ��������� ������� �� ������� ��������� �������� ����������
	/// </summary>
	protected void Button2_Click(object sender, EventArgs e)
	{
		if (FarenheitSetted != null)
			FarenheitSetted(this, EventArgs.Empty);
	}
}
