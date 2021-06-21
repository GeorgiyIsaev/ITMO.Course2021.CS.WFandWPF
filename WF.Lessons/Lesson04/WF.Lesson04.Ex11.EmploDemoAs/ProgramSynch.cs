using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmploDemoAs
{
    class ProgramSynch
    {
        delegate void SetIdDelegate(int id);
        delegate void SetNameDelegate(string name);

        static void Main(string[] args)
        {
            DateTime start = System.DateTime.Now;
            Employee empObj = new Employee();

            SetIdDelegate siDelegate = new SetIdDelegate(empObj.SetId);
            siDelegate(50);

            SetNameDelegate snDelegate = new SetNameDelegate(empObj.SetName);
            snDelegate("Иван Петров");

            DateTime end = System.DateTime.Now;
            TimeSpan duration = end.Subtract(start);
            Console.WriteLine("Выполнение заняло : {0} секунд", duration.Seconds);

        }
    }
}
