using System;
using System.Collections.Generic;

namespace BiografBilletSystem.Models
{
    public class Kunde
    {
        //To-do: Skal indeholde alt relevant information om en specifik kunde
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public int PostNummer { get; set; }
        public int TlfNr { get; set; }
        public bool Medlem { get; set; }
        public Betaling Betaling { get; set; }

        //public List<int> BestiltSædeIndex { get; set; }
        public List<Sæde> BestilteSæder { get; set; }

        public Kunde(string navn, string adresse, string email,
             int postNummer, int tlfNr, List<Sæde> bestilteSæder)
        {
            Navn = navn;
            Adresse = adresse;
            Email = email;
            PostNummer = postNummer;
            TlfNr = tlfNr;
            Medlem = false;
            BestilteSæder = bestilteSæder;
            Betaling = new Betaling(1111111111111111, 111, DateTime.Now, "navn");
        }


    }
}