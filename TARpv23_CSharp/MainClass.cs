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
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Sisestage tegevusmärk: ");
            märk = Console.
            int vastus = funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=funktsioonid.Liitmine(a,(int)arv);
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
        }
    }
}
