using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografBilletSystem
{
    class Betaling
    {
        public int Kortnummer { get; set; }
        public int Kontrolcifre { get; set; }
        public DateTime Udløbsdato { get; set; }
        public string Kortholder { get; set; }

        public Betaling(int kortnummer, int kontrolcifre, DateTime udløbsdato, string kortholder)
        {
            Kortnummer = kortnummer;
            Kontrolcifre = kontrolcifre;
            Udløbsdato = udløbsdato;
            Kortholder = kortholder;
        }

    }
}
