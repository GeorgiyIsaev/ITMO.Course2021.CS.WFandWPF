﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.Lab04.Ex03.InteractionOfComponentsAndClass
{
    class Persson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }

    }
}
