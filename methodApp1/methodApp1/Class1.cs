using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp1
{
    public class Class1
    {
        public static void Addition()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result = 5 + userInput;
            Console.WriteLine("Your answer is : " + result);
            Console.ReadLine();
        }

        public static void Multiply()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result = 5 * userInput;
            Console.WriteLine("Your answer is : " + result);
            Console.ReadLine();
        }

        public static void Divide()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result = 5 / userInput;
            Console.WriteLine("Your answer is : " + result);
            Console.ReadLine();
        }
    }
}
