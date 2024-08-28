using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //I.osa Andmetüübid, Alamfunktsioonid, If
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}", nimetus);
            funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus = funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
            // Loo Arvuta() funktsioon, mis sõltub 3 parameetrist: teha, arv1, arv2, kasuta if konstruktsioon. Tulemus kuva ekraanile.

            //1. Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            try
            {
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus0 = funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0} m, sa oled {1}", pikkus, vastus0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
            nimed[0] = "Marina";
            //1.V
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }
            //2.V
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            //3.V
            int n = 0;
            while (n < nimed.Length)
            {
                Console.WriteLine(nimed[n]);
                n++;
            }
            //4.V
            do
            {
                Console.WriteLine(nimed[n - 1]);
                n--;
            } while (n > 0);

            //Paevad
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                int paev_nr = random.Next(-4, 30);
                string paeva_nimetus = funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }
            //1. Loo juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni.Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus(-100,100).
            int N = random.Next(-10,101);
            Console.WriteLine(N);
            int M = random.Next(-10,101);
            Console.WriteLine(M);
            int[] arvud;
            if (N < M)
            {
                arvud=funktsioonid.Arvude_massiv(N, M);
            }
            else
            {
                arvud = funktsioonid.Arvude_massiv(M, N);
            }
            foreach (int item in arvud)         
            {
                Console.WriteLine(item * item);
            }
        }
    } 
}

