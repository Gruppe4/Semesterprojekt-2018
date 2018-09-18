using System;
using System.Globalization;

namespace BiografBilletSystem.Models
{
    public class Film
    {
        //To-do: Skal indeholde alt relevant information om en specifik film
        private DateTime _dato;

        public string Titel { get; private set; }
        public int Spilletid { get; private set; }
        public string Stjerner { get; private set; }
        public string Indstruktør { get; private set; }
        public string Genre { get; private set; }
        public string Resumé { get; private set; }
        public string Dato
        {
            get { return _dato.ToString("dd / MM / yyyy g", CultureInfo.CurrentCulture); }
        }
        public string BilledeUri { get; private set; }

        public Film(string titel, int spilletid, string stjerner, string indstruktør, 
            string genre, string resumé, DateTime dato, string billede)
        {
            Titel = titel;
            Spilletid = spilletid;
            Stjerner = stjerner;
            Indstruktør = indstruktør;
            Genre = genre;
            Resumé = resumé;
            _dato = dato;
            BilledeUri = billede;
        }
    }
}