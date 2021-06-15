using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value.Substring(0, 1).ToUpper() + value.Substring(1);
                }
                else
                {
                    firstName = string.Empty;
                }
            }
        }

        public override string ToString()
        {
            return firstName;
        }
    }
}
