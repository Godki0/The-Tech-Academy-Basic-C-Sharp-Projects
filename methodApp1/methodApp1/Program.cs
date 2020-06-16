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
            Class1 Math1 = new Class1();
            Console.WriteLine("Please enter a number.");
            int user = Convert.ToInt32(Console.ReadLine());
            int add = Math1.Addition(user);
            Console.WriteLine("Addition method demonstration: "+ add);

            Console.WriteLine("Please enter a number.");
            int user1 = Convert.ToInt32(Console.ReadLine());
            int multiply = Math1.Multiply(user1);
            Console.WriteLine("Multiplication method demonstration: " + multiply);

            Console.WriteLine("Please enter a number.");
            int user2 = Convert.ToInt32(Console.ReadLine());
            int divide = Math1.Divide(user2);
            Console.WriteLine("Division method demonstration: " + divide);
            Console.ReadLine();

        }   
    }
}
