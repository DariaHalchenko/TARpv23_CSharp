using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }
        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        public static string Pikkuse_analuus(double pikkus)
        {
            string analuus;
            if (pikkus < 1.6)
            {
                analuus = "Lühika kasvu inimene";
            }
            else if (pikkus < 1.8)
            {
                analuus = "Keskmine kasvu inimene";
            }
            else
            {
                analuus = "Pikka kasvu inimene";
            }
            return analuus;
        }
        //päeva number-> päeva nimetus 
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
            return paev;
        }
        public static int[] Arvude_massiv(int N, int M)
        {
            int[] arvud = new int[M - N];
            for (int i = 0; i < arvud.Length; i++) 
            {
                arvud[i] = N;
                N++;
            }
            return arvud;
        }
    }
}
