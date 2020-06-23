using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp195
{
    class Program
    {
        enum DaysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Good morning! Will you please enter what day it is");
            string userDayInput = Console.ReadLine().ToLower();
            try
            {
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDayInput);
                Console.WriteLine("It looks lke it is gonna be a great: " + currentDay);
            }
            catch (Exception ex )
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
