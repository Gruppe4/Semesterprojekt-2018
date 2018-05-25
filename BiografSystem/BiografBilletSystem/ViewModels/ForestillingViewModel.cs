using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiografBilletSystem.Models;
using BiografBilletSystem;

namespace BiografBilletSystem.ViewModels
{
    class ForestillingViewModel
    {
        private Forestilling _forestilling;
        private SalViewModel _salViewModel;

        public ForestillingViewModel()
        {
            _forestilling = MainViewModel.selectedForestilling;
            _salViewModel = new SalViewModel(_forestilling.Sal, _forestilling.AlleBookinger);
        }
    }
}
