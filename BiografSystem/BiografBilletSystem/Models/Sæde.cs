namespace BiografBilletSystem.Models
{
    public class Sæde
    {
        //To-do: Et sæde til en sal..

        public int RækkeNr { get; private set; }
        public int Nummer { get; private set; }
        public bool Reserveret { get; set; }
        public bool Checked { get; set; }

        public bool CheckBox
        {
            get { return !Reserveret; }
        }

        public Sæde(int rækkeNr, int nummer)
        {
            RækkeNr = rækkeNr;
            Nummer = nummer;
            Reserveret = false;
        }

        public string SædeUri
        {
            get
            {
                if (Reserveret)
                {
                    return "Images/ReservedSeat.png";
                }
                else
                {
                    return "Images/FreeSeat.png";
                }
            }
        }
    }
}