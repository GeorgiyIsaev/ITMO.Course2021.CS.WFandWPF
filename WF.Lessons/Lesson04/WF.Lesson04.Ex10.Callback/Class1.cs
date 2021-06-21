using System;
using System.IO;

namespace Callback
{
	
	class Class1
	{		
		// ������� ����� � ������ ������.
		static FileStream fs;
		static byte[] fileBytes;
		[STAThread]
		static void Main(string[] args)
		{			
			// ��������� ���� � �����.
			fs = new FileStream("text.txt", FileMode.Open);
			fileBytes = new byte[fs.Length];
			// ���������  ����� Read ���������� � ��������� � �������� �allback
			// ������ WorkComplete
			fs.BeginRead(fileBytes, 0, (int)fs.Length, new AsyncCallback(WorkComplete), null);
		}
		/// <summary>
		/// �����, ���������� ������������� ��� ���������� ������ ������������� ������.
		/// </summary>
		/// <param name="ar">������ ���� IAsyncResult.</param>
		static void WorkComplete(IAsyncResult ar)
		{
			// ������ ��������� ������.
			fs.EndRead(ar);
			string textFromFile = System.Text.Encoding.Default.GetString(fileBytes);
			Console.Write(textFromFile);
		}
	}
}
