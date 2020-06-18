using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp169
{
    class Program
    {
        static void Main(string[] args)
        {

            methodMath doMath = new methodMath();
            Console.WriteLine("Enter a number to be divided by 2!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            doMath.addMath(userInput, out int y);
            Console.WriteLine("Your number divided by 2: {0} ", y);

            Console.WriteLine("Here is a example of a output parameter");
            doMath.twoNum(out int a, out int b);
            Console.WriteLine(a * b);
            

            int v1 = overloadMath.overMath(5);
            decimal v2 = overloadMath.overMath(5.8m);
            double v3 = overloadMath.overMath(100, 40);
            Console.WriteLine("Will add numbers together:" + v1);
            Console.WriteLine("Number is times together:" + v2);
            Console.WriteLine("Number is divided together:" + v3);
            Console.ReadLine();
        }  

        public class methodMath
        {
            public void addMath(int x, out int y)
            {
                y = x / 2;

            }

            public void twoNum(out int a, out int b)
            {
                a = 10;
                b = 20;
                
            }
        }

        public static class overloadMath
        {
            public static int overMath(int x)
            {
                return x + x;
            }

            public static decimal overMath(decimal x)
            {
                return x * x;
            }

            public static double overMath(double x, double y)
            {
                return x / y;
            }
        }
    }
}
