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
        private Sæde _sæde;
        private PersonalInfoViewModel _personalInfoViewModel;
        private int _pris;
        public KvitteringViewModel()
        {
            _kunde = PersonalInfoViewModel.Instance;
            _forestillingViewModel = ForestillingViewModel.Instance;
        }

        public string TakForBestilling
        {
            get
            {
                return
                    $"Tak for din bestilling{_kunde.Navn}! " +
                    $"Du har bestilit {_kunde.BestilteSæder} til {_forestillingViewModel.Forestilling}. " +
                    $"Kopi af regningen er sendt til {_kunde.Email}." +
                    $"God film!";
            }
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




    }
}
