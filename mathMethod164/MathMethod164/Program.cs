using System;


namespace MathMethod164
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = MathMethod.addMath(5);
            decimal v2 = MathMethod.addMath(5.8m);
            int v3 = MathMethod.addMath("13");
            Console.WriteLine("Will add numbers together:" + v1);
            Console.WriteLine("Number is times together:" + v2);
            Console.WriteLine("Number is times together:" + v3);
            Console.ReadLine();
        }
    }
}
