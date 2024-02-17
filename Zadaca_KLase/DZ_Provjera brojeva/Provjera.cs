using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Provjera_brojeva
{
    internal static class Provjera
    {
        public static bool Prost(int a)
        {
            bool prost = true;
            for (int i = 2;i<a/2+1;i++) 
            {
                if (a % i == 0)
                    prost = false;
            }
            return prost;
        }

        public static bool Savrseni(int a)
        {
           
            int suma = 0;
            
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    suma += i;
                }
            }
            if (a == suma)
                return true;
            else
                return false;
          
        }
        public static bool Armstrongov(int n)
        {
            int suma = 0;
            int temp = n;
            var znamenke = new List<int>();

            while (temp > 0)
            {
                znamenke.Add(temp % 10);
                temp = temp / 10;
            }
            foreach (int a in znamenke)
            {
                suma = suma + Convert.ToInt32(Math.Pow(a, 3));
            }
            if (suma == n) return true;
            else return false;
        }
        public static double PI(int n)
        {
            double suma = 1.0;
           
            for (int i = 1; i <= n; i++)
            {
                double clanNiza = (i % 2 == 0) ? 1.0 / (2 * i + 1) : -1.0 / (2 * i + 1);
                suma += clanNiza;
            }
            return 4 * suma;
        }
    }
}
