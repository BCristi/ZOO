using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class CumparareAnimale<TAnimal> where TAnimal : Animal, new()
    {
        public static TAnimal ParticularitatiAnimal ()
        {
            var animal = new TAnimal();
            //var instance = Activator.CreateInstance<TAnimal>(); alta modalitate de a crea un obiect generic. Acelasi rezultat ca mai obj de mai sus
            try
            {
                foreach (var prop in typeof(TAnimal).GetProperties())
                {
                    Console.Write("Introduceti valoarea dorita pentru {0}: ", prop.Name);


                    switch (prop.PropertyType.Name)
                    {
                        case "Int32":
                            prop.SetValue(animal, Convert.ToInt32(Console.ReadLine()));
                            break;
                        case "DateTime":
                            prop.SetValue(animal, Convert.ToDateTime(Console.ReadLine()));
                            break;
                        case "String":
                            prop.SetValue(animal, Console.ReadLine());
                            break;
                        case "String[]":
                            Console.WriteLine();
                            Console.Write("      Cate tipuri de hrana introduceti (1-3): ");
                            int tipHrana = 1;
                            tipHrana = Convert.ToInt32(Console.ReadLine());
                            string[] hrana = new string[tipHrana];
                            for (int i = 0; i < tipHrana; i++)
                            {
                                Console.Write("            Tipul {0} de hrana: ", i+1);
                                hrana[i] = Console.ReadLine();
                            }
                            prop.SetValue(animal, hrana);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("A aparut o eroare, va rugam contactati administrtorul (D0ru), {0}", ex);
                //throw;
            }
           catch (Exception ex)
            {
                Console.WriteLine("EROARE {0}", ex);
            }
            
            return animal;
        }
    }
}
