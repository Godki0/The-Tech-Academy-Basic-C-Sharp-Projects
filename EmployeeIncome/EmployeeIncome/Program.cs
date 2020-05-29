using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            int p1Rate = 43;
            Console.WriteLine("Hourly Rate: " + p1Rate);
            int p1WeekHours = 45;
            Console.WriteLine("Hours worked per week: " + p1WeekHours);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            int p2Rate = 22;
            Console.WriteLine("Hourly Rate: " + p2Rate);
            int p2WeekHours = 60;
            Console.WriteLine("Hours worked per week: " + p2WeekHours);
            Console.ReadLine();

            int p1Annual = 92880;
            Console.WriteLine("Annual salary of Person 1: " + p1Annual);
            Console.ReadLine();

            int p2Annual = 63360;
            Console.WriteLine("Annual salary of Person 2: " + p2Annual);
            Console.ReadLine();

            bool p1VsP2 = p1Annual >= p2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + p1VsP2);
            Console.ReadLine();
        }
    }
}
