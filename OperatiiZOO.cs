using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZOO;

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
            }
            else
            {
                AfisareTipAnimal();
                Console.Write("Alegeti tipul de animal pe care doriti sa il aduceti in ZOO, din lista de mai sus: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "iepure":
                        animaleInAspteptare.Add(CumparareAnimale<Iepure>.ParticularitatiAnimal());
                        break;
                    case "leu":
                        animaleInAspteptare.Add(CumparareAnimale<Leu>.ParticularitatiAnimal());
                        break;
                    case "sarpe":
                        animaleInAspteptare.Add(CumparareAnimale<Sarpe>.ParticularitatiAnimal());
                        break;
                    case "vulpe":
                        animaleInAspteptare.Add(CumparareAnimale<Vulpe>.ParticularitatiAnimal());
                        break;
                    default:
                        break;
                }
            }
        }

        public void AlocareCusca()
        {
            Console.WriteLine("Custile disponibile: ");
            Cazare.ListareCustiDisponibile();
            for (int i = 0;  i < animaleInAspteptare.Count; i++)
            {
                Console.WriteLine("In ce cusca vreti sa mutati {0} cu numele {1}: ", animaleInAspteptare[i].ToString().Remove(0, 4), animaleInAspteptare[i].Nume);
                Console.Write("Numarul randului: ");
                int rand = Convert.ToInt32(Console.ReadLine());
                Console.Write("Numarul coloanei: ");
                int col = Convert.ToInt32(Console.ReadLine());
                Cazare.Custi[rand][col] = animaleInAspteptare[i];
                animaleInAspteptare.RemoveAt(i);
                
            }
        }

        private void AfisareTipAnimal()
        {
            Console.Write("Tipuri de animale disponibile: ");

            /*
            IEnumerable<Animal> exporters = typeof(Animal)
            .Assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(Animal)) && !t.IsAbstract)
            .Select(t => (Animal)Activator.CreateInstance(t));
            foreach (var item in exporters)
            {
                //var ani = new CumparareAnimale<item>();
                //var aa = new CumparareAnimale < item.GetType() > ();
                Console.Write(item.ToString().Remove(0, 4));
                Console.Write("  ");
            }
            */

            var animale = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(Animal)));
            foreach (var animal in animale)
            {
                Console.Write(animal.Name);
                Console.Write("  ");
                //System.Type type = animal.GetType();
                //Type cc = genericType.MakeGenericType(animal);
                
                
                //var ani = new CumparareAnimale<animal>();
                
            }
            Console.WriteLine();
            
        }
    }
}
