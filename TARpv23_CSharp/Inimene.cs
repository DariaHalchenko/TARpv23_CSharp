using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp
{
    public enum Sugu
    {
        mees,
        naine
    }
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal { get; set; }
        public Inimene() { }
        public Inimene(string nimi)
        {
            Nimi = nimi;
        }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Inimene(string nimi, int vanus, Sugu sugu )
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
        }
        public Inimene(string nimi, int vanus, Sugu sugu, int pikkus, double kaal)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
        }
        public double HB_vorrand()
        {
            double SBI = 0;
            if (Sugu == 0)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            return SBI; 
        } 
        public enum Eluviis
        {
            istuv_eluviis = 1,
            vähene_aktiivsus = 2,
            mõõdukas_aktiivsus = 3, 
            kõrge_aktiivsus = 4,
            väga_kõrge_aktiivsus = 5
        }
        public double Eluviis_2 (double SBI, Eluviis eluviis) 
        { 
            switch (eluviis)
            {
                case Eluviis.istuv_eluviis:
                    SBI = SBI * 1.2;
                    break;
                case Eluviis.vähene_aktiivsus:
                    SBI = SBI * 1.375;
                    break;
                case Eluviis.mõõdukas_aktiivsus:
                    SBI = SBI * 1.55;
                    break;
                case Eluviis.kõrge_aktiivsus:
                    SBI = SBI * 1.725;
                    break;
                case Eluviis.väga_kõrge_aktiivsus:
                    SBI = SBI * 1.9; 
                    break; 
            }
            return Math.Round(SBI,1); 
        }
    }
}
