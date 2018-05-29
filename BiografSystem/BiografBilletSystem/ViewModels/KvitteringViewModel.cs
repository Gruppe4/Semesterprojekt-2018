using System.Runtime.InteropServices;
using Windows.UI.ViewManagement;
using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    class KvitteringViewModel
    {

        private Kunde _kunde;
        private ForestillingViewModel _forestillingViewModel;
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
    }
}
