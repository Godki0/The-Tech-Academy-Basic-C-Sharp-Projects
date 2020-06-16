using System;


namespace MathMethod164
{
    class MathMethod
    {
        public static int addMath(int x)
        {
            return x + x;
        }

        public static decimal addMath(decimal x)
        {
            return x * x;
        }

        public static int addMath(string x)
        {
            int myNum = Convert.ToInt32(x);
            return 10 + myNum;
        }
    }
}
