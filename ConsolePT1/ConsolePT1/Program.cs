using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, please type any word");

            string userInput = Console.ReadLine();
            string[] strArray = { "Orange ", "Red ", "Blue ", "Green ", "purple " };

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i] + userInput);
            }
            Console.ReadLine();


            Console.WriteLine("Infinite loop");

            int[] intArray = { 500 };
            for (int i = 0; i < intArray.Length; i++) // To make it loop change the i++ to i--
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadLine();



            Console.WriteLine("Using < ");

            int[] intArray2 = { 70, 75, 80, 40, 30, 10 };
            for (int j = 0; j < intArray2.Length; j++)
            {
                if (intArray2[j] < 70)
                {
                    Console.WriteLine("it is cold out it is: " + intArray2[j]);
                }
            }
            Console.ReadLine();



            Console.WriteLine("Using <= ");

            int[] intArray3 = { 70, 75, 80, 40, 30, 10 };
            for (int j = 0; j < intArray2.Length; j++)
            {
                if (intArray2[j] <= 70)
                {
                    Console.WriteLine("it is starting to look like winter look at the tempatures outside: " + intArray2[j]);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Enter one of these names and see what happens: John, Marry, Joe, Bart");
            string inputUser = Console.ReadLine().ToUpper();
            List<string> names = new List<string>() { "JOHN", "MARRY", "JOE", "BART" };
            
            foreach (string name in names)
            {
                if (name == inputUser)
                {
                    Console.WriteLine("Hey stop yelling at: " + inputUser);
                    Console.ReadLine();
                    //Environment.Exit(0); code to exit at this point
                }
                //else if (name != inputUser)
                //{
                    //Console.WriteLine("That was the wrong answer!");
                    //Console.ReadLine();
                    //Environment.Exit(0);
                //}
            }
            



            Console.WriteLine("Enter one of these names and see what happens: John, Marry, Joe, Bart");
            string inputUser2 = Console.ReadLine();
            List<string> names2 = new List<string>() { "JOHN", "MARRY", "JOE", "BART", "JOHN" };
            List<string> names21 = new List<string>();

            foreach (string name2 in names2)
            {
                if (name2 == inputUser2)
                {
                    names21.Add(name2);
                }
                else if (name2 != inputUser2)
                {
                    Console.WriteLine("That is not in the list");
                    Console.ReadLine();
                }
            }
            Console.WriteLine(names21.Count);
            Console.ReadLine();
        }
    }
}
