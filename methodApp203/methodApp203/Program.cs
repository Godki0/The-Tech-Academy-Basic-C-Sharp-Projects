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
            Employee employee = new Employee();
            Employee Joe = new Employee
            {
                firstName = "Joe",
                lastName = "Dart",
                Id = 1
            };
            Employee Berry = new Employee
            {
                firstName = "Berry",
                lastName = "Merry",
                Id = 2
            };
            Employee Marry = new Employee
            {
                firstName = "Marry",
                lastName = "Jane",
                Id = 3
            };
            Employee Doug = new Employee
            {
                firstName = "Doug",
                lastName = "Marth",
                Id = 4
            };
            Employee Mark = new Employee
            {
                firstName = "Mark",
                lastName = "Cross",
                Id = 5
            };
            Employee Joe1 = new Employee
            {
                firstName = "Joe",
                lastName = "Dart",
                Id = 6
            };
            Employee Bart = new Employee
            {
                firstName = "Bart",
                lastName = "Simpson",
                Id = 7
            };
            Employee Gary = new Employee
            {
                firstName = "Gary",
                lastName = "Buddell",
                Id = 8
            };
            Employee Meg = new Employee
            {
                firstName = "Meg",
                lastName = "Myers",
                Id = 9
            };
            Employee Arthur = new Employee
            {
                firstName = "Arthur",
                lastName = "Matt",
                Id = 10
            };
            List<string> workers = new List<string>();
            foreach (string name in employee.employees)
            {
                if (name == "Joe Dart")
                {
                    workers.Add(name);
                    Console.WriteLine(name);
                }
            }

            List<string> work = employee.employees.Where(x => x.StartsWith("Joe")).ToList();
            foreach (string name in work)
            {
                Console.WriteLine(name);
            }

            //List<int> Id = employee.employees.FindIndex(x => x >= 5).ToList();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
