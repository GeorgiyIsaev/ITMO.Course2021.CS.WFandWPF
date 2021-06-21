using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactorialAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync();

            //Task t = DisplayResultAsync();
            //t.Wait();

            Console.ReadLine();
        }

        static async void DisplayResultAsync()
        {
            int num = 5;

            int result = await FactorialAsync(num);
            Thread.Sleep(3000);
            Console.WriteLine("Факториал числа {0} равен {1}", num, result);
        }

        //static async Task DisplayResultAsync()
        //{
        //    int num = 5;

        //    int result = await FactorialAsync(num);
        //    Thread.Sleep(3000);
        //    Console.WriteLine("Факториал числа {0} равен {1}", num, result);
        //}

        static Task<int> FactorialAsync(int x)
        {
            int result = 1;

            return Task.Run(() =>
            {
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            });
        }




    }
}
