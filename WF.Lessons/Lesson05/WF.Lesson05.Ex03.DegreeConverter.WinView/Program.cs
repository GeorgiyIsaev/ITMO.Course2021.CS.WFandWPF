using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DegreeConverter.Engine;

namespace DegreeConverter.WinView
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			FormView view = new FormView();
			Presenter presenter = new Presenter(view);
			Application.Run(view);
		}
	}
}