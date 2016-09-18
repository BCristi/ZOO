using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Vulpe : Animal
    {
        public enum tip { polara, indigena }
        tip _tip;

        public int TempMaxima { get; set; }
        //public string[] Tip { get; set; }
        public tip Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
            }
        }



    }
}
