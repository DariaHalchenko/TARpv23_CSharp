using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    internal class Toode
    {
        public string Toodete_nimetus { get; set; }
        public int Kaloreid { get; set; }
        public Toode() { }
        public Toode(string toodete_nimetus, int kaloreid)
        {
            Toodete_nimetus = toodete_nimetus;
            Kaloreid = kaloreid;
        }
        public static List<Toode> Toodete_loetelu()
        {
            List<Toode> tooted = new List<Toode>();
            string[] lines = File.ReadAllLines("toode.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int calories = int.Parse(parts[1]);
                tooted.Add(new Toode(name, calories));
            }
            return tooted;
        }
    }
}
