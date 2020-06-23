using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp230
{
    public class Students
    {
        public Students()
        {
        }

        public Students(string name, int currentAge)
        {
            age = currentAge;
            Name = name;
        }

        public Students(string name) : this(name, 35)
        {

        }
        public int age { get; set; }
        public string Name { get; set; }

        public void nameOfStudent()
        {
            Console.WriteLine(Name + age);
        }
    }
}
