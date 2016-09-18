﻿using System;
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
        public enum status { libera, ocupata}
        public status Status { get; set; }

        private void ConstruireCustiZoo()
        {
            Custi = new List<List<Animal>>();
            Console.Write("Introduceti numarul de randuri pentru custi: ");
            int nrRand = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane pentru custi: ");
            int nrColoane = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < nrRand; i++)
            {
                Console.Write("                     ");
                Custi.Add(new List<Animal>());
                for(int j = 0; j < nrColoane; j++)
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
    }
}
