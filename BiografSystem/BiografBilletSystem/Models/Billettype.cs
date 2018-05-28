using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografBilletSystem.Models
{
    public class Billettype
    {
        private bool _medlemsskab;
        public int BørneBillet { get; private set; }

        public int VoksenBillet { get; private set; }

        public int SeniorBillet { get; private set; }

        public bool Medlemsskab
        {
            get { return _medlemsskab; }
            set { value = _medlemsskab; }
        }
 
        

        public Billettype()
        {
            BørneBillet = 70;
            VoksenBillet = 100;
            SeniorBillet = 70;
            _medlemsskab = false;
        }

        public void MedlemsskabOverride()
        {
            if (Medlemsskab == true)
            {
                VoksenBillet = 80;
            }
        }
        
    }
}
