using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int curAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + curAge);
            

            Console.WriteLine("Have you ever had a DUI? please enter 'true' or 'false' ");
            bool hadDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your answer is: " + hadDui);
            

            Console.WriteLine("How many speeding tickets do you have?");
            int curTicket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current speeding tickets are: " + curTicket);
            

            Console.WriteLine("Are you qualified for insurance?");
            bool olderThan15 = curAge >= 15;
            bool noDui = hadDui == false;
            bool threeOrLess = curTicket <= 3;
            Console.WriteLine(!(!olderThan15 || !noDui || !threeOrLess));
            Console.ReadLine();


        }
    }
}
