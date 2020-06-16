using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp166
{
    class Program
    {
        static void Main(string[] args)
        {
            methodMath math = new methodMath();
            int v1 = math.addMath(5,5);
            Console.WriteLine(v1);
            Console.ReadLine();
        }
    }
}
