using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

public class CustomControl : System.Windows.Forms.Control
{
	public delegate void MyEvent(String stringPassed);

	public event MyEvent InvokeMyEvent;
		///to invoke the event
		

	protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
	{
		e.Graphics.DrawString("Written with GDI+ on OnPaint event", new Font("Arial",12), new SolidBrush(Color.Red), 0, 0);
		
InvokeMyEvent("Pass this string to host");

	}
	public  string eatme
	{
		get
		{
			return System.DateTime.Now.ToString();
		}
	}

}
