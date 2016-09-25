using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Iepure : Animal
    {
        public Iepure()
        {
            _number = _number+1;
        }
        public int SuprafataMinima { get; set; }
        private static int _number;
        public static int NumarIepuri()
        {
            return _number;
        }
    }
}
