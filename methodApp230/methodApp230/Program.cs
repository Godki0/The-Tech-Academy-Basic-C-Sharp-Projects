using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp230
{
    class Program
    {
        static void Main(string[] args)
        {
            const string code = "bootcamp";
            Console.WriteLine("Welcome to this coding {0}", code);
            Students students = new Students();
            var students1 = new Students("Bart");
            students.Name = "Joe ";
            students.age = 25;
            students.nameOfStudent();
            Console.ReadLine();
        }
    }
}
