using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    interface IAnimal
    {
        string Nume { get; set; }
        DateTime DataAducerii { get; set; }
        string[] HranaPreferata { get; set; }
        int CantitateHranaPeZi { get; set; }



    }
}
