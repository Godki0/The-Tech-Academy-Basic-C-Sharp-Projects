﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritApp174
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            employee.FirstName = " Sample ";
            employee.LastName = " Student ";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
