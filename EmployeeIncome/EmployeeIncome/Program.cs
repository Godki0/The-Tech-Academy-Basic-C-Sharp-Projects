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
            Console.WriteLine("How much do you make per hour?");
            int p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + p1Rate);
            Console.WriteLine("How many hours do you work per week?");
            int p1WeekHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: " + p1WeekHours);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("How much do you make per hour?");
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + p2Rate);
            Console.WriteLine("How many hours do you work per week?");
            int p2WeekHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: " + p2WeekHours);
            Console.ReadLine();

            Console.WriteLine("What is your annual income?");
            int p1Annual = p1Rate * p1WeekHours * 52;
            Console.WriteLine("Annual salary of Person 1: " + p1Annual);
            Console.ReadLine();

            Console.WriteLine("What is your annual income?");
            int p2Annual = p2Rate * p2WeekHours * 52;
            Console.WriteLine("Annual salary of Person 2: " + p2Annual);
            Console.ReadLine();

            bool p1VsP2 = p1Annual >= p2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + p1VsP2);
            Console.ReadLine();
        }
    }
}
