﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp200
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 10.5m;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
