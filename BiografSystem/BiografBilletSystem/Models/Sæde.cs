namespace BiografBilletSystem.Models
{
    public class Sæde
    {
        //To-do: Et sæde til en sal..

        public int RækkeNr { get; private set; }
        public int Nummer { get; private set; }
        public bool Reserveret { get; set; }

        public Sæde(int rækkeNr, int nummer)
        {
            RækkeNr = rækkeNr;
            Nummer = nummer;
            Reserveret = false;
        }
    }
}