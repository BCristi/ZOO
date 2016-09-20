using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class OperatiiZOO
    {
        List<Animal> AnimaleInAspteptare { get; set; }

        public void AducereAnimalZoo(Animal animal)
        {
            
            try
            {
                AnimaleInAspteptare.Add(animal);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
            

        }
    }
}
