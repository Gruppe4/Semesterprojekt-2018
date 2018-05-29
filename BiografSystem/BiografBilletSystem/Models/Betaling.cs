using BiografBilletSystem.Models;
using System;

namespace BiografBilletSystem
{
    public class Betaling
    {
        public long Kortnummer { get; set; }
        public int Kontrolcifre { get; set; }
        public DateTime Udløbsdato { get; set; }
        public string Kortholder { get; set; }
        public Billettype Billet { get; set; }

        public Betaling(long kortnummer, int kontrolcifre, DateTime udløbsdato, string kortholder)
        {
            Kortnummer = kortnummer;
            Kontrolcifre = kontrolcifre;
            Udløbsdato = udløbsdato;
            Kortholder = kortholder;
            Billet = new Billettype();
        }
    }
}