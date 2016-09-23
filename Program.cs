using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Leu leu = new Leu();
            Animal ani = new Leu();
            OperatiiZOO operatii = new OperatiiZOO();
            Cazare cazare = new Cazare();

            leu.CantitateHranaPeZi = 30;
            leu.DataAducerii = new DateTime(2016, 09, 18);
            leu.HranaPreferata = new string[3];
            leu.HranaPreferata[0] = "Carne";
            leu.Nume = "Leutu";
            leu.TaraProvenienta = "Romania";
            leu.TempMinima = 10;

            //Cazare.Custi[0][0] = leu;

            bool ales = true;
            string optiune;
            while(ales)
            {
                Console.WriteLine("Alegeti optiunea:");
                Console.WriteLine("1 - Adaugare animale in ZOO");
                Console.WriteLine("2 - Alocare cusca");
                Console.WriteLine("3 - TEst");
                Console.WriteLine("0 - Iesire");
                optiune = Console.ReadLine();
                switch (optiune)
                {
                    case "1":
                        operatii.AducereAnimalZoo(leu);
                        break;
                    case "2":

                        break;
                    case "3":
                        operatii.TipAnimal();
                        break;

                    case "0":
                        ales = false;
                        break;
                    default:
                        //ales = false;
                        break;
                }
            }




        }
    }
}
