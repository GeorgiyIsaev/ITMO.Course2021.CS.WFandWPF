using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void SimpleWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
               
        }
        
        static void Main(string[] args)
        {
          // Создаем новый поток 
            Thread theThread = new Thread(new ThreadStart(SimpleWork));
            theThread.IsBackground = true;
            // Запускаем задачу в новом потоке 
                theThread.Start();
            // моделирование работы основного потока
             string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (s != "q");            
        }
     }
}


