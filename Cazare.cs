using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Cazare
    {
        public Cazare()
        {
            ConstruireCustiZoo();

        }
        public static List<List<Animal>> Custi { get; set; }//cand as avea nevoie sa pun o prop statica intr un ctor?
        public enum status { libera, ocupata }
        public status Status { get; set; }

        private void ConstruireCustiZoo()
        {
            Console.WriteLine("Pentru a avea ZOO trebuie mai intai construite custile. Sa le cream!");
            Custi = new List<List<Animal>>();
            Console.Write("Introduceti numarul de randuri pentru custi: ");
            int nrRand = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane pentru custi: ");
            int nrColoane = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < nrRand; i++)
            {
                Console.Write("                     ");
                Custi.Add(new List<Animal>());
                for (int j = 0; j < nrColoane; j++)
                {

                    Console.Write("Cusca [{0}{1}]", i, j);
                    Custi[i].Add(null);
                    // tbd Custi[i] = status.libera;
                    Console.Write("   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void ListareCustiDisponibile()
        {
            for (int i = 0; i < Custi.Count; i++)
            {
                Console.Write("                     ");
                for (int j = 0; j < Custi[i].Count; j++)
                {
                    if (Custi[i][j] == null)
                    {
                        Console.Write("Cusca [{0}{1}]", i, j);
                    }
                    else
                    {
                        Console.Write("  ocupat  ");//tbd animalul din celula
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
