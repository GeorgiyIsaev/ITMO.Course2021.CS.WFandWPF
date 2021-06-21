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
			Console.Write("Выполнение метода Read асинхронно.");
			// Запуск метода Read асинхронно. 
			IAsyncResult ar = fs.BeginRead(fileBytes, 0, fileBytes.Length, null, null);			
			// Проверка на выполнение асинхронного метода.
			while(!ar.IsCompleted)
			{
				// Во время чтения файла на экран выводится надпись
				Console.Write("Процесс идет");
			}
			Console.WriteLine();
			string textFromFile = System.Text.Encoding.Default.GetString(fileBytes);
			Console.WriteLine(textFromFile);
		}
	}
}
