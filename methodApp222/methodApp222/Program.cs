using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp222
{
    class Program
    {
        private static DateTime x;
        private static DateTime y;

        static void Main(string[] args)
        {
            x = DateTime.Now;
            Console.WriteLine(x);
            Console.WriteLine("Please enter a number!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            y = x.AddHours(userInput);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
