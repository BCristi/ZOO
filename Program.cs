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
            leu.CantitateHranaPeZi = 30;
            leu.DataAducerii = new DateTime(2016, 09, 18);
            leu.HranaPreferata = new string[3];
            leu.HranaPreferata[0] = "Carne";
            leu.Nume = "Leutu";
            leu.TaraProvenienta = "Romania";
            leu.TempMinima = 10;


            Cazare cazare = new Cazare();

            OperatiiZOO operatii = new OperatiiZOO();
            operatii.AducereAnimalZoo(leu);
           
            Cazare.Custi[0][0] = leu;
            /*
            //List<List<Animal>> custi = new List<List<Animal>>(); //de ce nu pot sa fac o lista de tipul Animal in care sa pun obiecte de tipul Leu?  List<Animal> custi = new List<Leu>()
            custi.Add(new List<Animal>());
            custi.Add(new List<Animal>());
            custi.Add(new List<Animal>());
            custi[0].Add(leu);
            custi[0].Add(leu);
            custi[0].Add(leu);
            custi[1].Add(leu);
            custi[2].Add(leu);

            */



        }
    }
}
