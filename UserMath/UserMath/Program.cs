using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userMulti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Your number times fifty = " + userMulti * 50);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int userAdd = Convert.ToInt32(Console.ReadLine());
            int twentyFive = 25;
            int total = userAdd + twentyFive;
            Console.WriteLine(" Your number plus twenty-five = " + total.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int userDivide = Convert.ToInt32(Console.ReadLine());
            double twelveP = 12.5;
            double result = userDivide / twelveP;
            Console.WriteLine(" Your number divided by twelve = " + result.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int userIn = Convert.ToInt32(Console.ReadLine());
            bool userGreat = userIn > 50;
            Console.WriteLine("Your number is greater than fifty: " + userGreat);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int userRemain = Convert.ToInt32(Console.ReadLine());
            int userSeven = 7;
            int equal = userRemain % userSeven;
            Console.WriteLine(" Your number divided by seven has a remainder of: " + equal.ToString());
            Console.ReadLine();
        }
    }
}
