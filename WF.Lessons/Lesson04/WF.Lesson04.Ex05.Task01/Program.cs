using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Task task = new Task(Work);
            Task task = new Task(new Action(Work));
            task.Start();

            Task task1 = new Task(() => Work()); // Using a Lambda Expression to Invoke a Named Method

            task1.Start();

            Task task2 = new Task(delegate { Console.WriteLine("The time now is {0}", DateTime.Now); });
            task2.Start();


            Task task3 = new Task(() => { Console.WriteLine("The time now is {0}", DateTime.Now); }); //Using a Lambda Expression to Invoke an Anonymous Method
            task3.Start();

            Task task4 = Task.Run(() => { Console.WriteLine("Day of the year {0}", DateTime.Now.DayOfYear); });

            Console.WriteLine("Выполняется работа метода Main");
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (s != "q");

            task.Wait();

        }

        static void Work()
        {
            Console.WriteLine("Начало работы метода Work");
            // имитация работы метода
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Завершение работы метода Work");
        }

    }
}

