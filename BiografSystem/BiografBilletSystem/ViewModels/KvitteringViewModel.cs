using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.UI.ViewManagement;
using BiografBilletSystem.Annotations;
using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    class KvitteringViewModel
    {

        private Kunde _kunde;
        private ForestillingViewModel _forestillingViewModel;
        private int _pris;
        public KvitteringViewModel()
        {
            _kunde = PersonalInfoViewModel.Instance;
            _forestillingViewModel = ForestillingViewModel.Instance;
            _forestillingViewModel.Forestilling.AlleBookinger.AlleKunder.Add(_kunde);
        }


        public Kunde Kunde
        {
            get { return _kunde; }
        }

        public List<Sæde> Sæde
        {
            get { return Kunde.BestilteSæder; }
        }
        public int Pris
        {
            get { return _pris = Kunde.Betaling.Billet.Pris(); }
        }

        public ForestillingViewModel ForestillingViewModel
        {
            get { return _forestillingViewModel; }
        }




    }
}
