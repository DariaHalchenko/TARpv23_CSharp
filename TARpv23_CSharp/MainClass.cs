using System;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
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
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus = Funktsioonid.Liitmine(a, (int)arv);
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

            // 1. Kui eesnimi on Juku siis lähme Jukuga kinno. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.
            Console.WriteLine("Tere tulemast!");
            Console.Write("Mis su nimi on? ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla!");
                int vanus = Funktsioonid.Mitu_aastat_vana();
                Funktsioonid.Piletid(vanus);
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            // 2. Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            Console.Write("Mis on sinu nimi? ");
            string nimi_1 = Console.ReadLine();
            Console.Write("Mis on sinu nimi? ");
            string nimi_2 = Console.ReadLine();
            if (nimi_1 == nimi_2)
            {
                Console.WriteLine("Samad nimed");
            }
            else
            {
                Console.WriteLine("Täna " + nimi_1 + " ja " + nimi_2 + " naabrid pingil ");
            }

            // 3.Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala. Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind
            Console.WriteLine("Tere!");
            Console.Write("Mis on teie seinte pikkus? ");
            int pikkus_1 = int.Parse(Console.ReadLine());
            Console.Write("Mis on teie seinte laius? ");
            int laius_1 = int.Parse(Console.ReadLine());
            int põrandaPindala = Funktsioonid.Põranda_pindala(pikkus_1, laius_1);
            Console.WriteLine("Põranda pindala: {0} ruutmeetrit", põrandaPindala);
            Console.Write("Kas soovite remonti teha? Jah, Ei => ");
            string remont = Console.ReadLine().ToLower();
            if (remont == "jah")
            {
                Console.Write("Kui palju see ruutmeeter maksab? ");
                int hind = int.Parse(Console.ReadLine());

                int summa = Funktsioonid.Põranda_pindala_summa(hind, põrandaPindala);
                Console.WriteLine("Remondi hind: {0} eurot", summa);
            }
            else
            {
                Console.WriteLine("Ma ei vaja remonti.");
            }

            // 5. Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
            Console.Write("Mis su temperatuur on? ");
            int temperatuuri = int.Parse(Console.ReadLine());
            if (temperatuuri > 18)
            {
                Console.WriteLine("Temperatuur üle 18 kraadi");
            }
            else
            {
                Console.WriteLine("Temperatuur mitte üle 18 kraadi");
                Console.WriteLine("See on talvel soovitatav temperatuur");
            }

            // 6. Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
            try
            {
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus0 = Funktsioonid.Pikkuse_analuus(pikkus);
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
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine(paeva_nimetus);
            }

            // 1. Loo juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni.Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus(-100,100).
            int N = random.Next(-10, 101);
            Console.WriteLine(N);
            int M = random.Next(-10, 101);
            Console.WriteLine(M);
            int[] arvud;
            if (N < M)
            {
                arvud = Funktsioonid.Arvude_massiv(N, M);
            }
            else
            {
                arvud = Funktsioonid.Arvude_massiv(M, N);
            }
            foreach (int item in arvud)
            {
                Console.WriteLine(item * item);
            }

            // 2. Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis.
            int[] viis_arvu = new int[5];
            for (int i = 0; i < viis_arvu.Length; i++)
            {
                Console.Write("Sisesta numbrid {0}: ", i + 1);
                viis_arvu[i] = int.Parse(Console.ReadLine());
            }
            int nende_summa = 0;
            int korrutis = 1;
            foreach (int number in viis_arvu)
            {
                nende_summa += number;
                korrutis *= number;
            }
            double aritmeetiline_keskmine = (double)nende_summa / viis_arvu.Length;
            Console.WriteLine("Numbrite summa: " + nende_summa);
            Console.WriteLine("Aritmeetiline keskmine: " + aritmeetiline_keskmine);
            Console.WriteLine("Arvude korrutamine: " + korrutis);

            // 3. Küsi viielt kasutajalt nimed ja vanused, salvesta nende andmeid massiivi ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused.
            string[] kasutajalt_nimed = new string[5];
            int[] vanuseid = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sisesta viis kasutajanime  {0}: ", i + 1);
                kasutajalt_nimed[i] = Console.ReadLine();
                Console.Write("Sisesta kasutaja viis vanust {0}: ", i + 1);
                vanuseid[i] = int.Parse(Console.ReadLine());
            }
            int summaarne_vanus = 0;
            for (int i = 0; i < vanuseid.Length; i++)
            {
                summaarne_vanus += vanuseid[i];
            }
            double keskmine_vanus = (double)summaarne_vanus / vanuseid.Length;
            Console.WriteLine("Summaarne vanus: " + summaarne_vanus);
            Console.WriteLine("Keskmine vanus : " + keskmine_vanus);
            Console.WriteLine("\nÜle keskealised inimesed: ");
            for (int i = 0; i < vanuseid.Length; i++)
            {
                if (vanuseid[i] > keskmine_vanus)
                {
                    Console.WriteLine("{0} - {1} aastat", kasutajalt_nimed[i], vanuseid[i]);
                }
            }
            Console.WriteLine("\nKeskealistest nooremad inimesed: ");
            for (int i = 0; i < vanuseid.Length; i++)
            {
                if (vanuseid[i] <= keskmine_vanus)
                {
                    Console.WriteLine("{0} - {1} aastat", kasutajalt_nimed[i], vanuseid[i]);
                }
            }

            // 4. Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
            string Kasutaja_sisestamine = " ";
            while (Kasutaja_sisestamine.ToLower() != "elevant")
            {
                Console.WriteLine("Osta elevant ära!");
                Kasutaja_sisestamine = Console.ReadLine(); 
            }
            Console.WriteLine("Müüdud!");

            // 4.1. Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant".
            string Kasutaja_sisestamine_1 = " ";
            do
            {
                Console.WriteLine("Osta elevant ära!");
                Kasutaja_sisestamine_1 = Console.ReadLine();
            }
            while (!string.Equals(Kasutaja_sisestamine_1, "elevant", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Müüdud!"); 

            //5. Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.
            int arvutiArv = random.Next(1, 25);
            int kasutajaArv;
            int katsed = 0;
            bool arvatiOigesti = false;
            Console.WriteLine("Programm on mõelnud välja arvu vahemikus 1 kuni 25, sul on 5 katset.");
            while (katsed < 5 && !arvatiOigesti)
            {
                Console.Write("Sisesta oma arvatav arv: ");
                kasutajaArv = int.Parse(Console.ReadLine());
                katsed++;
                if (kasutajaArv == arvutiArv)
                {
                    Console.WriteLine("Õige! Sa arvasid arvu ära.");
                    arvatiOigesti = true;
                }
                else if (kasutajaArv < arvutiArv)
                {
                    Console.WriteLine("Liiga väike!");
                }
                else
                {
                    Console.WriteLine("Liiga suur!");
                }
            }
            if (arvatiOigesti = false)
            {
                Console.WriteLine($"Kahjuks ei arvanud sa õiget arvu ära. Programm mõtles välja arvu (arvutiArv).");
            }

            // 6. Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.
            int[] neli_numbrit = new int[4];
            for (int i = 0; i < 4; i++)
            {
                 Console.Write("Sisestage neli numbrit {0}: ", i + 1);
                 neli_numbrit[i] = int.Parse(Console.ReadLine());
            }
            var numbrite_sorteerimine = neli_numbrit.OrderByDescending(d => d).ToArray();
            string suurim_number = string.Concat(numbrite_sorteerimine);
            Console.WriteLine("Swuurim number: " + suurim_number);

            // 6.1. Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.
            int[] neliArvu = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Sisestage neli numbrit {0}: ", i + 1);
                neliArvu[i] = int.Parse(Console.ReadLine());
            } 
            Array.Sort(neliArvu);
            Array.Reverse(neliArvu);;
            string suurimArv = string.Join("", neliArvu);
            Console.WriteLine("Swuurim number: " + int.Parse (suurimArv)); 
            
            //II. osa listid ja sõnastikud 
            List<string> abc = new List<string> ();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fail ei saa leida!");
            }
            foreach (string e in abc)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine(); 

            //
            ArrayList arrayList = new ArrayList ();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vas=Console.ReadLine();
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) +".kohal");
            }
            else
            {
                Console.WriteLine("Kokku oli" + arrayList.Count + " elemente, vaid otsitav puudub");
            }
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Clear ();
            arrayList1.Insert(1, "Anna");
            arrayList1.Insert(0, "Inna");
            Console.WriteLine(); 

            ///III. osa OOP 
            List<Inimene> inimesed = new List<Inimene> ();
            Inimene inimene1 = new Inimene ();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene ("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("Daria", 17);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene ("Valeria", 17));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + "aasta vana");
            }
        }
    }
}

