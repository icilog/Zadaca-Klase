using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("123456", "Marko");
            Student student2 = new Student("654321", "Ana");

            // Unos potrebnih podataka za studente
            student1.PostaviPrezime("Markovic");
            student1.Adresa = "Zagreb";
            student1.Visina = 180;
            student1.Tezina = 75;
            student1.BojaKose = "Crna";
            student1.BrojCipela = 43;
            student1.DodajOcjenu("Matematika", 5);
            student1.DodajOcjenu("Fizika", 4);
            student1.DodajOcjenu("Povijest", 3);

            student2.PostaviPrezime("Anić");
            student2.Adresa = "Split";
            student2.Visina = 165;
            student2.Tezina = 55;
            student2.BojaKose = "Plava";
            student2.BrojCipela = 38;
            student2.DodajOcjenu("Matematika", 5);
            student2.DodajOcjenu("Engleski", 4);
            student2.DodajOcjenu("Povijest", 4);

            // Ispis informacija o studentima
            Console.WriteLine("Informacije o studentu 1:");
            student1.IspisiInformacije();
            Console.WriteLine();

            Console.WriteLine("Informacije o studentu 2:");
            student2.IspisiInformacije();
            Console.ReadKey();
        }
    }
  
}
