using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_stringovima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Ovo je probna rečenica";
            int[] razmaci = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < razmaci.Length; i++)
            {
                string b = Stringovi.DodajRazmake(a,razmaci[i]);
                Console.WriteLine(b);
            }
            string zamijenime = "OvO jE proBna Za zamJenu VelikiH i MaliH sloVa.";
            Console.WriteLine(zamijenime);
            string Zamjena = Stringovi.VelikoMalo(zamijenime);
            Console.WriteLine(Zamjena);
            

            string sifra = "Ovo će biti rećenica koju ćemo šifrirati za n pomaka, n brojevi su 1 -5";
            Console.WriteLine(sifra);
            int[] sifre = { 1, 2, 3, 4, 5 };
            for (int i = 0; i< sifre.Length; i++)
            {
                Console.WriteLine($"Pomak: {sifre[i]}: {Stringovi.SifrirajTekst(sifra, sifre[i])}");

            }
            string zagrade = "U ovaj string ćemo dodati zagrade";
            Console.WriteLine(Stringovi.Zagrada("{}", zagrade));
            Console.WriteLine(Stringovi.Zagrada("[]", zagrade));
            Console.WriteLine(Stringovi.Zagrada("()", zagrade));
            Console.ReadKey();



        }
    }
}
