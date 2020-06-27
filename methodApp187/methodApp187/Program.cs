using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp187
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee();
            Employee Jerry = new Employee();
            John.FirstName = "John ";
            John.LastName = "Berry ";
            John.Id = 1;
            Jerry.FirstName = "Jerry ";
            Jerry.LastName = "Bright ";
            Jerry.Id = 2;
            John.SayName();
            Jerry.SayName();
            Console.WriteLine(John);
            Console.WriteLine(John.Id);
            Console.WriteLine(John == Jerry);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
