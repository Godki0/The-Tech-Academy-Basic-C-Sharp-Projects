using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
            }
            else if (packWeight < 50)
            {
                Console.WriteLine("Your package weight is: " + packWeight);
            }
           
            
            Console.WriteLine("Please enter the package width:");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your package width is: " + packWidth);


            Console.WriteLine("Please enter the package height:");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your package height is: " + packHeight);

            Console.WriteLine("Please enter the package length:");
            int packLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your package length is: " + packLength);

            int packTotal = packWidth + packHeight + packLength;
            if (packTotal >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else if (packTotal < 50)
            {
                int packCost = packTotal * packWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + packCost);
            }

            Console.ReadLine();

        }
    }
}
