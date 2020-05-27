using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Tech_Academy_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseOn = Console.ReadLine();
            Console.WriteLine("Your course is: "+ courseOn);
            Console.ReadLine();

            Console.WriteLine("What page are you on? ");
            string coursePage = Console.ReadLine();
            int courseP = Convert.ToInt32(coursePage);
            Console.WriteLine("Your course page is: " + courseP);
            Console.ReadLine();

            Console.WriteLine(" Do you need help with anything? Please answer 'true' or 'false '");
            string boolAnswer = Console.ReadLine();
            Console.WriteLine("Answer is: " + boolAnswer);
            Console.ReadLine();

            Console.WriteLine(" Were there any positive experiences you’d like to share? Please give specifics");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Answer is: " + positiveExp);
            Console.ReadLine();

            Console.WriteLine(" Is there any other feedback you'd like to provide? Please be specific");
            string otherFeed = Console.ReadLine();
            Console.WriteLine("Thank you for the feedback: " + otherFeed);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today? ");
            string hourStudy = Console.ReadLine();
            byte hoursDone = (byte)Convert.ToInt32(hourStudy);
            Console.WriteLine("Your hours studied is: " + hoursDone);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
