using System;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static TARpv23_CSharp.Inimene;
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
            Array.Reverse(neliArvu); ;
            string suurimArv = string.Join("", neliArvu);
            Console.WriteLine("Swuurim number: " + int.Parse(suurimArv));

            //II. osa listid ja sõnastikud 
            List<string> abc = new List<string>();
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
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing: ");
            string vas = Console.ReadLine();
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + ".kohal");
            }
            else
            {
                Console.WriteLine("Kokku oli" + arrayList.Count + " elemente, vaid otsitav puudub");
            }
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Insert(0, "Inna");
            arrayList1.Insert(1, "Anna");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Clear ();
            //arrayList1.Insert(1, "Anna");
            //arrayList1.Insert(0, "Inna");
            //Console.WriteLine(); 

            ///III. osa OOP 
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("Daria", 17);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Valeria", 17));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + " aasta vana");
            }
            Auto auto1 = new Auto("666 MAX", Color.NavajoWhite, inimene1);
            Auto auto2 = new Auto("345 VKD", Color.DeepPink, inimene2);
            Auto auto3 = new Auto("789 ABC", Color.DarkRed, inimene3);
            auto1.KelleOmaAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene2);
            register.Add(auto3, inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.Regnumber} - {item.Value.Nimi}");
            }
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.Regnumber + "-" + pair.Value.Nimi);
            }

            //Ülesanne 2
            //Antud on 20 juhusliku numbri nimekiri.Kirjutage selle elemendid ümber uueks loeteluks järgmiselt: kõigepealt kõik paarilised arvud, seejärel kõik paaritu arvud.
            List<int> numbrid = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbrid.Add(random.Next(0, 101));
            }
            List<int> paarisNumbrid = numbrid.Where(n => n % 2 == 0).ToList();
            List<int> parituNumbrid = numbrid.Where(n => n % 2 != 0).ToList();
            List<int> sortNumbrid = paarisNumbrid.Concat(parituNumbrid).ToList();
            Console.WriteLine("Sorteeritud numbers : ");
            sortNumbrid.ForEach(n => Console.WriteLine(n + " "));

            //Ülesanne 1
            Console.WriteLine("Sisesta numbrid");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(" ");
            int[] newlist = new int[numblist.Length];
            for (int i = 0; i < numblist.Length; i++)
            {
                int a_1;
                if (i == 0)
                {
                    a_1 = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[i + 1]);
                }
                else if (i == numblist.Length - 1)
                {
                    a_1 = int.Parse(numblist[i - 1]) + int.Parse(numblist[0]);
                }
                else
                {
                    a_1 = int.Parse(numblist[i - 1]) + int.Parse(numblist[i + 1]);
                }

                newlist[i] = a_1;
            }
            Console.WriteLine("New list of sums");
            Console.WriteLine(string.Join(" ", newlist));


            //// Ülesanne 4
            //List<int> list = new List<int>();
            //List<int> list1 = new List<int>();
            //for (int i = 0; i < random.Next(1, 100); i++)
            //{
            //    int a_2 = random.Next(1, 100);
            //    list.Add(a_2);
            //}
            //foreach (int i in list)
            //{
            //    Console.Write(i + " ");
            //}
            //list.Insert(0, list[list.Count - 1]);
            //list.Insert(list.Count, list[1]);
            //Console.WriteLine();
            //for (int i = 1; i < list.Count - 1; i++)
            //{
            //    list1.Insert(i - 1, list[i - 1] + list[i + 1]);
            //}
            //foreach (int i in list1)
            //{
            //    Console.Write(i + " ");
            //}
            //while (true)
            //{
            //    Console.WriteLine("\n1-Vaadake maakondi ja pealinnu\n2-Lisa maakond ja linnˇ\n3-Leia pealinn või maakond");
            //    int o = int.Parse(Console.ReadLine());

            //    if (o == 0)
            //    {
            //        break;
            //    }
            //    else if (o == 1)
            //    {
            //        List<string> list_failist = new List<string>();
            //        try
            //        {
            //            foreach (string rida in File.ReadAllLines(@"..\..\..\pealinna_maakond.txt"))
            //            {
            //                list_failist.Add(rida);
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Viga failiga");
            //        }
            //        string key;
            //        string value;
            //        Dictionary<string, string> maakond_linn = new Dictionary<string, string>();
            //        foreach (var rida in list_failist)
            //        {
            //            key = rida.Split('-')[0];
            //            value = rida.Split('-')[1];
            //            maakond_linn.Add(key, value);
            //        }
            //        foreach (KeyValuePair<string, string> keyValue in maakond_linn)
            //        {
            //            Console.WriteLine(keyValue.Key + " pealinn on " + keyValue.Value);
            //        }
            //    }
            //    else if (o == 2)
            //    {
            //        try
            //        {
            //            StreamWriter text = new StreamWriter(@"..\..\..\pealinna_maakond.txt", true);
            //            Console.WriteLine("Sisesta maakonda nimetus: ");
            //            string maakond = Console.ReadLine();
            //            Console.WriteLine("Sisesta linn nimetus: ");
            //            string linn = Console.ReadLine();
            //            string lause = maakond + " - " + linn;
            //            text.WriteLine(lause);
            //            text.Close();
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Viga failiga!");
            //        }
            //    }
            //    else if (o == 3)
            //    {
            //        Console.WriteLine("Sisesta maakond või pealinn");
            //        string l = Console.ReadLine();
            //    }
            //}

            // Ülesanne 3
            List<Inimene> inimesed_1 = new List<Inimene>();
            Inimene inimene_1 = new Inimene("Pjotr 1", 52, Sugu.mees, 180, 87);
            Inimene inimene_2 = new Inimene("Jelizaveta", 23, Sugu.naine, 175, 65);
            Inimene inimene_3 = new Inimene("Daria", 17, Sugu.naine, 155, 40);
            Inimene inimene_4 = new Inimene("Valeria", 17, Sugu.naine, 170, 42);
            Inimene inimene_5 = new Inimene("Maksim", 18, Sugu.mees, 180, 62);
            inimesed_1.Add(inimene_1);
            inimesed_1.Add(inimene_2);
            inimesed_1.Add(inimene_3);
            inimesed_1.Add(inimene_4);
            inimesed_1.Add(inimene_5);
            foreach (Inimene inimene in inimesed_1)
            {
                Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus + " aasta vana" + ".Ta on " + inimene.Sugu + " SBI=" + inimene.HB_vorrand ());
            } 
            foreach (Inimene inimene in inimesed_1)
            {
                Console.WriteLine("Milline on " +inimene.Nimi + " elustill: (1 - Istuv eluviis/ 2 - Vähene aktiivsus/ 3 - Mõõdukas aktiivsus/ 4 - Kõrge aktiivsus/ 5 - Väga kõrge aktiivsus)");
                int elustiili_sisend = Convert.ToInt32(Console.ReadLine());
                Eluviis eluviis = (Eluviis)elustiili_sisend; 
                double kohandatud_SBI = inimene.Eluviis_2(inimene.HB_vorrand(), eluviis);
                Console.WriteLine(inimene.Nimi, " kohandatud SBI: " + kohandatud_SBI); 
            }
        }
    }
}

