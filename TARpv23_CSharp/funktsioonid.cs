using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }
        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }

        //1. JUKU
        public static int Mitu_aastat_vana()
        {
            Console.WriteLine("Kui vana sa oled?");
            int vanus0;
            while (!int.TryParse(Console.ReadLine(), out vanus0))
            {
                Console.WriteLine("Palun sisesta korrektne vanus (number).");
            }

            return vanus0;
        }

        // 3.Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind
        public static int Põranda_pindala(int pikkus_1, int laius_1)
        {
            return pikkus_1 * laius_1;
        }
        public static int Põranda_pindala_summa(int hind, int põrandaPindala)
        {
            return hind * põrandaPindala;
        }

        // Funktsioon pileti määramiseks ja tüübiks
        public static void Piletid(int vanus0)
        {
            if (vanus0 < 0 || vanus0 > 100)
            {
                Console.WriteLine("Viga andmetega");
            }
            else if (vanus0 < 6)
            {
                Console.WriteLine("Tasuta");
            }
            else if (vanus0 >= 6 && vanus0 <= 14)
            {
                Console.WriteLine("Lastepilet");
            }
            else if (vanus0 >= 15 && vanus0 <= 65)
            {
                Console.WriteLine("Täispilet");
            }
            else if (vanus0 > 65)
            {
                Console.WriteLine("Sooduspilet");
            }
        }

        //6. Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
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

        //1. Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).
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
           

