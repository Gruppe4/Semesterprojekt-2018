namespace BiografBilletSystem.Models
{
    public class Billettype
    {
        public int BørneBillet { get; set; }

        public int VoksenBillet { get; set; }

        public int SeniorBillet { get; set; }

        public bool Medlemsskab { get; set; }

        public int RabatBillet
        {
            get { return BørneBillet + SeniorBillet; }
        }



        public Billettype()
        {
            BørneBillet = 0;
            VoksenBillet = 0;
            SeniorBillet = 0;
            Medlemsskab = false;
        }

        public int Pris()
        {
            int pris = RabatBillet * 70;
            pris = Medlemsskab ? pris + VoksenBillet * 80 : pris + VoksenBillet * 100;
            return pris;
        }
    }
}
