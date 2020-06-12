using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.WriteLine("Hello there, Please select a index up to 5");
        int indexUser = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = { "Hi", "there", "how", "are", "you", "doing" };

        if (indexUser > 5)
        {
            Console.WriteLine("Error that is a wrong selection!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        Console.WriteLine("You selected: " + indexUser);
        Console.WriteLine("Here is what you have picked: " + stringArray[indexUser]);
        

        Console.WriteLine("\nHello there, Please select a index up to 5");
        int indexUser2 = Convert.ToInt32(Console.ReadLine());
        int[] numArray = { 5, 2, 22, 18, 13, 20 };
        
        if (indexUser2 > 5)
        {
            Console.WriteLine("Error that is a wrong selection!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        Console.WriteLine("You selected: " + indexUser2);
        Console.WriteLine("Here is what you have picked: " + numArray[indexUser2]);
        

        Console.WriteLine("\nHello there, Please select a index up to 5");
        int indexUser3 = Convert.ToInt32(Console.ReadLine());
        List<string> strList = new List<string>();
        strList.Add("Red");
        strList.Add("Blue");
        strList.Add("Orange");
        strList.Add("Pink");
        strList.Add("Purple");
        strList.Add("Maroon");

        if (indexUser3 > 5)
        {
            Console.WriteLine("Error that is a wrong selection!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        Console.WriteLine("You selected: " + indexUser3);
        Console.WriteLine("Here is what you have picked: " + strList[indexUser3]);
        Console.ReadLine();
    }
}

