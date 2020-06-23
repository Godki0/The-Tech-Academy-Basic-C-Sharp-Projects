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
            Employee employee = new Employee();
            employee.FirstName = "John";
            employee.LastName = "Berry";
            employee.Id = 1;
            employee.SayName();
            Console.ReadLine();
        }
    }
}
