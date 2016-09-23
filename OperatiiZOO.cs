using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void TipAnimal()
        {

            Console.WriteLine("Tipuri de animale disponibile");
            var animale = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(Animal)));
            foreach (var animal in animale)
            {
                Console.Write(animal.Name);
                Console.Write("  ");
            }

            Console.Write("Alegeti tipul de animal pe care doriti sa il aduceti in ZOO, din lista disponibila:");

            string optiune = Console.ReadLine();

            switch (optiune)
            {
                case "Iepure":
                    Iepure iepure = new Iepure();
                    Console.WriteLine("Cantitate hrana pe zi:");
                    iepure.CantitateHranaPeZi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Data aducerii");
                    iepure.DataAducerii = Convert.ToDateTime(Console.ReadLine());
                    

                    break;
                default:
                    break;
            }


        }

        public void AlocareCusca()
        {

        }

    }
}
