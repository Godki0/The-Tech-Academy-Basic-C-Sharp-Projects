using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methodApp166
{
    class Program
    {
        static void Main(string[] args)
        {
            methodMath doMath = new methodMath();
            int y = 10;
            int z;
            doMath.addMath(5, out y);
            Console.WriteLine("Y is just printed: {0} ", y);
            Console.ReadLine();
        }
        public class methodMath
        {
            public void addMath(int x, out int y)
            {
                int z = x * 10;
                y = 10;
            }
        }
    }
}
