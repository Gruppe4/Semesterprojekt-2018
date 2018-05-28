using System.Collections.Generic;

namespace BiografBilletSystem.Models
{
    public class Bookinger
    {
        //To-do: Skal holde styr på alle bookingerne til en specifik forestilling

        public Bookinger()
        {
            
        }

        public List<Kunde> AlleKunder { get; set; } = new List<Kunde>();

        public void TilføjKunde(Kunde kunde)
        {
            AlleKunder.Add(kunde);
         }

    }
}