using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp187
{
    public class Employee : Person
    {
        public static Employee operator ==(Employee employee)
        {
            if (employee.Id == employee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Employee operator !=(Employee employee)
        {
            if (employee.Id != employee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> employees { get; set; }
    }
}
