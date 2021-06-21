using System;
using System.IO;

namespace Callback
{
	
	class Class1
	{		
		// Создаем поток и массив байтов.
		static FileStream fs;
		static byte[] fileBytes;
		[STAThread]
		static void Main(string[] args)
		{			
			// Открываем файл в поток.
			fs = new FileStream("text.txt", FileMode.Open);
			fileBytes = new byte[fs.Length];
			// Запускаем  метод Read асинхронно с передачей в качестве Сallback
			// метода WorkComplete
			fs.BeginRead(fileBytes, 0, (int)fs.Length, new AsyncCallback(WorkComplete), null);
		}
		/// <summary>
		/// Метод, вызываемый автоматически при завершении работы параллельного потока.
		/// </summary>
		/// <param name="ar">Объект типа IAsyncResult.</param>
		static void WorkComplete(IAsyncResult ar)
		{
			// Запуск окончания метода.
			fs.EndRead(ar);
			string textFromFile = System.Text.Encoding.Default.GetString(fileBytes);
			Console.Write(textFromFile);
		}
	}
}
