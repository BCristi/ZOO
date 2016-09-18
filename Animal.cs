using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Animal : IAnimal
    {
        public Animal()
        {
            
        }
        public string Nume { get; set; }
        public DateTime DataAducerii { get; set; }
        public string[] HranaPreferata { get; set; }
        public int CantitateHranaPeZi { get; set; }
        //care este diferenta intre declararea unei prop ca mai sus si: int IAnimal.CantitateHranaPeZi { get; set; }

        

    }
}
