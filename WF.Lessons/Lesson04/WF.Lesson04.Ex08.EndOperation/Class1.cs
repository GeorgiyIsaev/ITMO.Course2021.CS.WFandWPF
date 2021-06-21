using System;
using System.IO;

namespace EndOperation
{

	class Class1
	{
	
		[STAThread]
		static void Main(string[] args)
		{	
			//������� ����� � ��������� ����. 
			FileStream fs = new FileStream("text.txt", FileMode.Open);
			byte[] fileBytes = new byte[fs.Length];
			// ������ ������ Read � ������������ ������.
			IAsyncResult ar = fs.BeginRead(fileBytes, 0, fileBytes.Length, null, null);
			for(int i = 0; i<10000000; i++)
			{
				// �������� ���������� ������ ���������
				// ������, ����������� �� ���������� ������������ ������.
			}
			// ����� ���������� ������ ��������� ������
			// ��������� ���������� ���������� ������������� 
			// ������ Read.
			fs.EndRead(ar);
			Console.WriteLine(System.Text.Encoding.Default.GetString(fileBytes));
		}
	}
}
