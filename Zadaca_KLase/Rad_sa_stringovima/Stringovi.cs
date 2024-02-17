using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_stringovima
{
    internal static class Stringovi
    {
        public static string DodajRazmake(string str,int n)
        {
            string dodano = "";
            foreach (char a in str)
            {
                dodano += (a + " ");
                for (int i = 1; i < n; i++)
                {
                    dodano += " ";
                }
                
            }
            return dodano;

        }
        public static string VelikoMalo(string str)
        {
            string zamjena = "";
            foreach (char a in str)
            {
                if (char.IsLower(a))
                {
                    zamjena += a.ToString().ToUpper();
                }
                else
                {
                    zamjena += a.ToString().ToLower();
                }
            }
            return zamjena;
        }
        public static string SifrirajTekst(string tekst, int pomak)
        {
            string sifrat = ""; 

            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    char novoSlovo = (char)(znak + pomak); 
                    if ((char.IsLower(znak) && novoSlovo > 'z') || (char.IsUpper(znak) && novoSlovo > 'Z'))
                    {
                        novoSlovo = (char)(novoSlovo - 26); 
                    }
                    sifrat += novoSlovo;
                }
                else
                {
                    sifrat += znak; 
                }
            }

            return sifrat;
        }
        public static string Zagrada(string zagrada,string recenica)
        {
            char prvi = zagrada[0];
            char drugi = zagrada[1];
            return  prvi + recenica + drugi;
            

        }
    }
}
