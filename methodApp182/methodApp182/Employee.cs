using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp182
{
    class Employee : Person, Iquittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
