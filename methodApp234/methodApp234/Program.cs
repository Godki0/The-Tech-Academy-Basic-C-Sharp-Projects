using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp234
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age");
                int.TryParse(Console.ReadLine(), out int userInput);
                if (userInput <= 0)
                {
                   Console.WriteLine("Can't enter a negative or zero number");
                    Console.ReadLine();
                }
                else
                {
                    int x = 2020 - userInput;
                    Console.WriteLine("Your year you were born is: " + x);
                    Console.ReadLine();
                }
            }
            catch (ZeroOrNegativeException)
            {
                Console.WriteLine("Error you entered in zero or a negative number");
                Console.ReadLine();
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Error has happened. Please Contact System Administrator.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            
        }
    }
}
