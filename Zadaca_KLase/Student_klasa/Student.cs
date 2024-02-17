using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_klasa
{
    internal class Student
    {
        public string MaticniBroj { get; }
        public string Ime { get; }
        public string Prezime { get; private set; }
        public string Adresa { get; set; }
        public double Visina { get; set; }
        public double Tezina { get; set; }
        public string BojaKose { get; set; }
        public int BrojCipela { get; set; }
        public List<string> PopisPredmeta { get; }
        public List<int> PopisOcjena { get; }
        public Student(string maticniBroj, string ime)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = ""; // Inicijalno prezime je prazno
            Adresa = "";
            Visina = 0;
            Tezina = 0;
            BojaKose = "";
            BrojCipela = 0;
            PopisPredmeta = new List<string>();
            PopisOcjena = new List<int>();
        }

        public void PostaviPrezime(string prezime)
        {
            Prezime = prezime;
        }
        // Konstruktor koji omogućava inicijalizaciju svih svojstava
        public Student(string maticniBroj, string ime, string prezime, string adresa, double visina, double tezina, string bojaKose, int brojCipela)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Visina = visina;
            Tezina = tezina;
            BojaKose = bojaKose;
            BrojCipela = brojCipela;
            PopisPredmeta = new List<string>();
            PopisOcjena = new List<int>();
        }

        // Metoda za dodavanje predmeta i ocjena
        public void DodajOcjenu(string predmet, int ocjena)
        {
            PopisPredmeta.Add(predmet);
            PopisOcjena.Add(ocjena);
        }

        // Metoda za ispis informacija o studentu
        public void IspisiInformacije()
        {
            Console.WriteLine($"Ime: {Ime}");
            Console.WriteLine($"Prezime: {Prezime}");
            Console.WriteLine($"Matični broj: {MaticniBroj}");
            Console.WriteLine($"Adresa: {Adresa}");
            Console.WriteLine($"Visina: {Visina} cm");
            Console.WriteLine($"Težina: {Tezina} kg");
            Console.WriteLine($"Boja kose: {BojaKose}");
            Console.WriteLine($"Broj cipela: {BrojCipela}");
            Console.WriteLine("Popis predmeta i ocjena:");
            for (int i = 0; i < PopisPredmeta.Count; i++)
            {
                Console.WriteLine($"- {PopisPredmeta[i]}: {PopisOcjena[i]}");
            }
        }
    }

}