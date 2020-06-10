using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how many siblings I have?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool sibNum = number == 3;

            while (!sibNum)
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("Go higher");
                        Console.WriteLine("Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Go lower");
                        Console.WriteLine("Try Again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 60:
                        Console.WriteLine("Are you crazy?");
                        Console.WriteLine("Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("That is correct!");
                        sibNum = true;
                        break;
                    default:
                        Console.WriteLine("Are you even trying?");
                        Console.WriteLine("Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
