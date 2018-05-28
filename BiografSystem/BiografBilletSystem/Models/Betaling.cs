using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiografBilletSystem.Models;

namespace BiografBilletSystem
{
    public class Betaling
    {
        public long Kortnummer { get; set; }
        public int Kontrolcifre { get; set; }
        public DateTime Udløbsdato { get; set; }
        public string Kortholder { get; set; }
        public Billettype Billettype { get; set; }

        public Betaling(long kortnummer, int kontrolcifre, DateTime udløbsdato, string kortholder)
        {
            Kortnummer = kortnummer;
            Kontrolcifre = kontrolcifre;
            Udløbsdato = udløbsdato;
            Kortholder = kortholder;
        }

        public void TotalPris(int børnMængde, int voksenMængde, int seniorMængde)
        {
            Billettype.MedlemsskabOverride();

            var totalPris = (Billettype.BørneBillet * børnMængde) +
                            (Billettype.VoksenBillet * voksenMængde) +
                            (Billettype.SeniorBillet * seniorMængde);
        }

    }
}