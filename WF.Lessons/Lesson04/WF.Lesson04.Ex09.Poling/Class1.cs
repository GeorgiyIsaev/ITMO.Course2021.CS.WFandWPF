using System;
using System.IO;

namespace Pooling
{	
	class Class1
	{		
		[STAThread]
		static void Main(string[] args)
		{
			FileStream fs = new FileStream("text.txt", FileMode.Open);
			byte[] fileBytes = new byte[fs.Length];
			Console.Write("���������� ������ Read ����������.");
			// ������ ������ Read ����������. 
			IAsyncResult ar = fs.BeginRead(fileBytes, 0, fileBytes.Length, null, null);			
			// �������� �� ���������� ������������ ������.
			while(!ar.IsCompleted)
			{
				// �� ����� ������ ����� �� ����� ��������� �������
				Console.Write("������� ����");
			}
			Console.WriteLine();
			string textFromFile = System.Text.Encoding.Default.GetString(fileBytes);
			Console.WriteLine(textFromFile);
		}
	}
}
