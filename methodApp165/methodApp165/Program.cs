using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp165
{
    class Program
    {
        static void Main(string[] args)
        {
            mathMethod math1 = new mathMethod();
            int userInput, userInput2;
            int result;
            Console.WriteLine("Please enter one number!");
            if (!int.TryParse(Console.ReadLine(), out userInput))
                throw new ArgumentException("No valid number input");

            Console.WriteLine("Please enter a second number! Not required to work");
            if (int.TryParse(Console.ReadLine(), out userInput2))
                result = math1.mathAdd(userInput, userInput2);
            else
                result = math1.mathAdd(userInput);

            Console.WriteLine("Your answer is: " + result);
            Console.ReadLine();
        }
    }
}
