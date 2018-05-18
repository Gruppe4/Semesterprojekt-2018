using System;

namespace BiografBilletSystem.Models
{
    public class Film
    {
        //To-do: Skal indeholde alt relevant information om en specifik film

        public string Titel { get; private set; }
        public int Spilletid { get; private set; }
        public string Stjerner { get; private set; }
        public string Indstruktør { get; private set; }
        public string Genre { get; private set; }
        public string Resumé { get; private set; }
        public DateTime Dato { get; private set; }
        public string Billede { get; private set; }

        public Film(string titel, int spilletid, string stjerner, string indstruktør, 
            string genre, string resumé, DateTime dato, string billede)
        {
            Titel = titel;
            Spilletid = spilletid;
            Stjerner = stjerner;
            Indstruktør = indstruktør;
            Genre = genre;
            Resumé = resumé;
            Dato = dato;
            Billede = billede;
        }
    }
}