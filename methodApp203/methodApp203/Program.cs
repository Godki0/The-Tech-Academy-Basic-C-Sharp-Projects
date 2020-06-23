using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp203
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> employees = new List<string>() { "Joe Can" , "Bob Bird", "Jerry Join", "Jim Don", "Johnny Main", "Jeff Fort", "Marry Grau", "Steve Scar", "Berry Bee", "Joe Can" };
            List<string> workers = new List<string>();
            foreach (string name in employees)
            {
                if (name == "Joe Can")
                {
                    workers.Add(name);
                    Console.WriteLine(name);
                }
            }

            List<string> work = employees.Where(x => x.StartsWith("Joe")).ToList();
            foreach (string name in work)
            {
                Console.WriteLine(name);
            }

            List<int> Id = employees.FindIndex(x => x >= 5).ToList();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
