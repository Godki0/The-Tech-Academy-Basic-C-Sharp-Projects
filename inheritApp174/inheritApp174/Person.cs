﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritApp174
{
    class Person
    {
        string FirstName;
        string LastName;
        public void SayName()
        {
            Console.WriteLine("Name:"+ FirstName + LastName);
        }
    }
}
