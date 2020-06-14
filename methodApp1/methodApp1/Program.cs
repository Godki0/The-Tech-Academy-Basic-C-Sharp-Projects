using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methodApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            Class1.Addition();
            Console.WriteLine("Please enter a number.");
            Class1.Multiply();
            Console.WriteLine("Please enter a number.");
            Class1.Divide();

        }   
    }
}
