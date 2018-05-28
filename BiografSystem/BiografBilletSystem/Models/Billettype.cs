using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografBilletSystem.Models
{
    class Billettype
    {

        public int BørneBillet { get; private set; }

        public int VoksenBillet { get; private set; }

        public int SeniorBillet { get; private set; }

        public int Medlemsskab { get; private set; }

        public Billettype(int børneBillet, int voksenBillet, int seniorBillet, int medlemsskab)
        {
            BørneBillet = 70;
            VoksenBillet = 100;
            SeniorBillet = 70;
            Medlemsskab = 80;
        }
    }
}
