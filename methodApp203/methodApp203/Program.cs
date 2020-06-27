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
            List<Employee> employees = new List<Employee>();
            employees.Add(Joe);
            employees.Add(Berry);
            employees.Add(Marry);
            employees.Add(Doug);
            employees.Add(Mark);
            employees.Add(Joe1);
            employees.Add(Bart);
            employees.Add(Gary);
            employees.Add(Meg);
            employees.Add(Arthur);
            List<Employee> workers = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    workers.Add(employee);
                    Console.WriteLine(employee.firstName);
                }
            }

            List<Employee> work = employees.Where(x => x.firstName.StartsWith("Joe")).ToList();
            foreach (Employee employee1 in work)
            {
                Console.WriteLine(employee1.firstName);
            }

            List<Employee> Id = employees.Where(x => x.Id >= 5).ToList();
            foreach (Employee employee2 in Id)
            {
                Console.WriteLine(employee2.Id);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
