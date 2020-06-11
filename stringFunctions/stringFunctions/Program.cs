using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Braydon";
            //string quote = "The man said, \"Hello\", Braydon. \n Hello on a new line. \n \t Hello on a tab.";
            //string filename = @"C:\user\bur"; // @ sign stats all after has no escape sequence. 

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper(); // name.ToLower();

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Braydon");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
