using System;
using System.IO;

namespace EndOperation
{

	class Class1
	{
	
		[STAThread]
		static void Main(string[] args)
		{	
			//—оздаем поток и открываем файл. 
			FileStream fs = new FileStream("text.txt", FileMode.Open);
			byte[] fileBytes = new byte[fs.Length];
			// «апуск метода Read в параллельном потоке.
			IAsyncResult ar = fs.BeginRead(fileBytes, 0, fileBytes.Length, null, null);
			for(int i = 0; i<10000000; i++)
			{
				// »митаци€ длительной работы основного
				// потока, независ€ща€ от выполнени€ асинхронного метода.
			}
			// ѕосле завершени€ работы основного потока
			// запускаем завершение выполнени€ параллельного 
			// метода Read.
			fs.EndRead(ar);
			Console.WriteLine(System.Text.Encoding.Default.GetString(fileBytes));
		}
	}
}
