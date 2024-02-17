using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Provjera_brojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int b in brojevi)
            {
                if (Provjera.Prost(b) == true)
                {
                    Console.WriteLine($"Broj {b} je prost!");
                }
                else
                {
                    Console.WriteLine($"Broj {b} nije prost!");
                }
            }

            int[] armstrongovi = {0,1,153,370,371,400,407,1634 };
            foreach (int b in armstrongovi)
            {
                if (Provjera.Armstrongov(b) == true)
                {
                    Console.WriteLine($"Broj {b} je Armstrongov broj.");
                }
                else
                    Console.WriteLine($"Broj {b} nije Armstrongov broj.");
            }

            int[] savrseni = {6,12,28,352,496,8000,8128 };
            foreach (int b in savrseni)
            {
                if (Provjera.Savrseni(b) == true)
                {
                    Console.WriteLine($"Broj {b} je Savrsen broj.");
                }
                else
                    Console.WriteLine($"Broj {b} nije Savrsen broj.");
            }
           
            int[] pi = { 1, 2, 3, 4, 5, 6 };
            foreach (int b in pi)
            {
                double piValue = Provjera.PI(b);
                Console.WriteLine($"Aproksimacija broja Pi koristeći zadane cikluse:{b} : {piValue}");
            }


            Console.ReadKey();
        }
    }
}
