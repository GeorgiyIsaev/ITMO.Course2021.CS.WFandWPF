using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EmploDemoAs
{
    class Employee
    {
        private int id;
        private string name;

        public void SetId(int idnumber)
        {
            Console.WriteLine("Вызывается SetId, id задаётся {0}", idnumber);
            Console.WriteLine("В SetId задержка 5 секунд");
            Thread.Sleep(5000);
            id = idnumber;
            Console.WriteLine("Вызов SetId завершён");
        }
        public void SetName(string namestr)
        {
            Console.WriteLine("Вызывается SetName, name задаётся {0}", namestr);
            Console.WriteLine("В SetName задержка 5 секунд");
            Thread.Sleep(5000);
            name = namestr;
            Console.WriteLine("Вызов SetName завершён");
        }
        public int GetId() { return id; }
        public string GetName() { return name; }

    }
}
