using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class OperatiiZOO
    {
        public OperatiiZOO()
        {
            animaleInAspteptare = new List<Animal>();
        }

        private List<Animal> animaleInAspteptare { get; set; }

        public void AducereAnimalZoo(Animal animal)
        {
            if (animal != null)
            {
                try
                {
                    animaleInAspteptare.Add(animal);
                }
                catch (NullReferenceException ex)
                {

                    Console.WriteLine(ex); ;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Mesaj din al doilea Catch {0}", ex);
                }
                //finally
                //{
                //    Console.WriteLine("Mesaj din finally");
                //}
            }
        } 
        public void AlocareCusca()
        {

        }

    }
}
