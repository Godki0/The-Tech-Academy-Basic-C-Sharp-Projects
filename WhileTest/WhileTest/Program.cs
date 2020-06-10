using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the tempature inside the house?");
            int numTemp = Convert.ToInt32(Console.ReadLine());
            bool tempGuess = numTemp == 75;

            do
            {
                switch (numTemp)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess again?");
                        numTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 85:
                        Console.WriteLine("You guessed 85. Try again.");
                        Console.WriteLine("Guess again?");
                        numTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 70:
                        Console.WriteLine("You guessed 70. Try again.");
                        Console.WriteLine("Guess again?");
                        numTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 75:
                        Console.WriteLine("You guessed the correct tempature in the house!");
                        tempGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are not correct");
                        Console.WriteLine("Guess again?");
                        numTemp = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!tempGuess);
            Console.ReadLine();
        }
    }
}
