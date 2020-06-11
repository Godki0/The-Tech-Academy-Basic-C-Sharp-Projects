using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOne = "Hey there, ";
            string sTwo = "how are you? ";
            string sThree = "My name is Braydon ";

            sOne = sOne.ToUpper();


            Console.WriteLine(sOne + sTwo + sThree);
            Console.ReadLine();
            

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Braydon");
            sb.Append("\nit is very nice to meet you!");
            sb.Append("\nPlease don't be shy.");
            sb.Append("\nTell me more about yourself?");
            sb.Append("\nWell thank you for your time!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
