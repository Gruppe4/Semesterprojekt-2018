using System;

namespace BiografBilletSystem.Models
{
    public class Forestilling
    {
        //To-do: Skal indeholde alt relevant information om en specifik forestilling
        private Bookinger _bookinger;
        public DateTime StartTid { get; private set; }

        public Film Film { get; private set; }

        public Sal Sal { get; private set; }

        public DateTime SlutTid { get; private set; }

        public Bookinger AlleBookinger
        {
            get { return _bookinger; }
        }

        public Forestilling(Sal sal, Film film, DateTime start)
        {
            StartTid = start;
            Sal = sal;
            Film = film;
            SlutTid = StartTid.AddMinutes(Film.Spilletid);
            _bookinger = new Bookinger();
            _bookinger.AlleKunder = Factory.PopulateBookingList();
        }

     
    }
}