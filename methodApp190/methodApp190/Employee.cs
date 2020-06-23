using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodApp190
{
    class Employee<T>
    {
        private List<T> _things = new List<T>();
        public List<T> things { get { return _things; } set { _things = value; } }
    }
}
