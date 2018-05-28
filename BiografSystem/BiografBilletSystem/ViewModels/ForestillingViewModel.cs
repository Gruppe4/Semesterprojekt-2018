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
        private static ForestillingViewModel _instance;
        public static ForestillingViewModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new ForestillingViewModel());
                return _instance;
            }
        }

        public ForestillingViewModel()
        {
            _forestilling = MainViewModel.selectedForestilling;
            _salViewModel = new SalViewModel(_forestilling.Sal, _forestilling.AlleBookinger);
            _instance = this;
        }

        public Forestilling Forestilling
        {
            get { return _forestilling; }
        }

        public SalViewModel SalViewModel
        {
            get { return _salViewModel; }
        }
    }
}
