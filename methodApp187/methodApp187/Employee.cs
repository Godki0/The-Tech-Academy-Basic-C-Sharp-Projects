﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp187
{
    public class Employee : Person
    {
        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.Id == employee1.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.Id != employee1.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> employees { get; set; }
    }
}
