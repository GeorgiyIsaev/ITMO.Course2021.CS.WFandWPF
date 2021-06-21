using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmploDemoAs
{
    class ProgramAsynch
    {
        delegate void SetIdDelegate(int id);
        delegate void SetNameDelegate(string name);

        static void Main(string[] args)
        {
            DateTime start = System.DateTime.Now;
            Employee empObj = new Employee();

            SetIdDelegate siDelegate = new SetIdDelegate(empObj.SetId);
            IAsyncResult siAR = siDelegate.BeginInvoke(50, null, null);
            SetNameDelegate snDelegate = new SetNameDelegate(empObj.SetName);
            IAsyncResult snAR = snDelegate.BeginInvoke("Иван Петров", null, null);
            siDelegate.EndInvoke(siAR);
            snDelegate.EndInvoke(snAR);

            DateTime end = System.DateTime.Now;
            TimeSpan duration = end.Subtract(start);
            Console.WriteLine("Выполнение заняло : {0} секунд", duration.Seconds);
          //  Console.ReadLine();
        }

    }
}
