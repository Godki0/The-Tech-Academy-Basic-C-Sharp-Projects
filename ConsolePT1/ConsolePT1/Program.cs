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
            for (int i = 0; i < intArray.Length; i++) // To make it loop forever change the i++ to i--
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
                if (intArray3[j] <= 70)
                {
                    Console.WriteLine("it is starting to look like winter look at the tempatures outside: " + intArray3[j]);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Enter one of these names and see what happens: John, Marry, Joe, Bart");
            string inputUser = Console.ReadLine();
            List<string> names = new List<string>() { "John", "Marry", "Joe", "Bart" };
            

           
            if (!names.Contains(inputUser))
            {
                Console.WriteLine("Input was not in the list.");
            }
            else
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i] == inputUser)
                    {
                        Console.WriteLine(i);
                        Console.ReadLine();
                        break;
                    }
                }
            }


            Console.WriteLine("Enter one of these names and see what happens: John, Marry, Joe, Bart");
            string inputUser2 = Console.ReadLine();
            List<string> names2 = new List<string>() { "John", "Marry", "Joe", "Bart", "John" };
            

            if (!names2.Contains(inputUser2))
            {
                Console.WriteLine("Input was not in the list.");
            }
            else
            {
                for (int i = 0; i < names2.Count; i++)
                {
                    if (names2[i] == inputUser2)
                    {
                        Console.WriteLine(i);
                        Console.ReadLine();
                        
                    }
                }
            }

            Console.WriteLine("Enter one of these names and see what happens: Bob, Marry, Joe, Bart");
            List<string> names3 = new List<string>() { "Bob", "Marry", "Joe", "Bart", "Bob" };
            List<string> names4 = new List<string>();

            foreach (string name3 in names3)
            {
                if (!names4.Contains(name3))
                {
                    Console.WriteLine(name3);
                    names4.Add(name3);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That name was mentioned already");
                    Console.ReadLine();
                }
            }    

        }
    }
}
