using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Task<string> task = Task.Run<string>(() => DateTime.Now.DayOfWeek.ToString());
            
            Console.WriteLine(task.Result);

            Task<int> task1 = new Task<int>(() => Factorial(5));
            task1.Start();

            Console.WriteLine("Факториал числа 5 равен {0}", task1.Result);

            Task<Book> task2 = new Task<Book>(() =>
            {
                return new Book { Title = "Book", Author = "Autor" };
            });
            task2.Start();

            Book b = task2.Result;
            Console.WriteLine("Название книги: {0}, автор: {1}", b.Title, b.Author);

            Console.ReadLine();
        }


        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }


}
