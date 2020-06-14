using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please pick a number to be divide our numbers by.");
            int numUser = Convert.ToInt32(Console.ReadLine());
            List<int> intNums = new List<int>() { 30, 45, 65, 13, 89, 10, 13, 18 };

            foreach (var intNum in intNums)
            {
                var result = intNum / numUser;
                Console.WriteLine("The answer is:" + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please input only numbers.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You can't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}

