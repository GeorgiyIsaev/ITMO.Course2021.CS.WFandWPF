using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditPerson
{
  public  class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //string firstName;
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}

        //string lastName;
        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}

        //int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value;}
        //}

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }
    }
}
