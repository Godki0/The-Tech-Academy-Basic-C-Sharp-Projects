using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp190
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employee1 = new Employee<int>();
            employee.things.Add("john");
            employee.things.Add("Marry");
            employee1.things.Add(1);
            employee1.things.Add(2);

            foreach (string employ in employee.things)
            {
                Console.WriteLine(employ);
            }
            foreach (int employ1 in employee1.things)
            {
                Console.WriteLine(employ1);
            }
            Console.ReadLine();
        }
    }
}
