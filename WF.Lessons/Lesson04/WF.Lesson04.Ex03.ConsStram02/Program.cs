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
            for (int x = 1; x <= 10; ++x) {
            Console.WriteLine("Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                // Замедляем работу потока, позволяя другим потокам продолжить выполнение
                Thread.Sleep(100);
            }

        }

        static void Main(string[] args)
        {
            ThreadStart operation = new ThreadStart(SimpleWork);
            for (int x = 1; x <= 5; ++x)
            {
                // Создаем новый поток, но не запускаем его
                Thread theThread = new Thread(operation);
                // Запускаем задачу в новом потоке 
                theThread.Start();
            }

        }
    }
}
