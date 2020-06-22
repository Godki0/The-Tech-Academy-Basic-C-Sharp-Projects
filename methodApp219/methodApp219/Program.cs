using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace methodApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\burro\Logs\log1.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.WriteLine("Here is your number:" + userInput);
            Console.ReadLine();
        }
    }
}
