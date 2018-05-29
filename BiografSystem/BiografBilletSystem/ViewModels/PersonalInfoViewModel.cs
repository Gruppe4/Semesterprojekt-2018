using BiografBilletSystem.Annotations;
using BiografBilletSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BiografBilletSystem.ViewModels
{
    class PersonalInfoViewModel : INotifyPropertyChanged
    {
        private ForestillingViewModel _valgteForestillingViewModel;
        private int _voksenBilleter;
        private int _børneBilleter;
        private int _seniorBilleter;
        private static Kunde _instance;
        public static Kunde Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new Kunde("(Navn)", "(Addresse)", "(Email)", 0000, 00000000, new List<Sæde>()));
                return _instance;
            }
        }

        public PersonalInfoViewModel()
        {
            _instance = new Kunde("(Navn)", "(Addresse)", "(Email)", 0000, 00000000, new List<Sæde>());
            Instance.Betaling = new Betaling(0, 000, new DateTime(), "(Navn på kortholder)");
            _valgteForestillingViewModel = ForestillingViewModel.Instance;
            _instance.BestilteSæder = _valgteForestillingViewModel.SalViewModel.ValgteSæder;
            _voksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count;
            _seniorBilleter = 0;
            _børneBilleter = 0;
        }

        public int VoksenBilleter
        {
            get
            {
                _voksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - (BørneBilleter + SeniorBilleter);
                return _voksenBilleter;
            }
            set
            {
                _voksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - (_børneBilleter + _seniorBilleter);
                _instance.Betaling.Billet.VoksenBillet = value;
            }
        }

        public int BørneBilleter
        {
            get { return _børneBilleter; }
            set
            {
                _børneBilleter = value;
                _instance.Betaling.Billet.BørneBillet = value;

                if (0 > VoksenBilleter)
                {
                    _seniorBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - _børneBilleter == 0
                        ? 0
                        : ForestillingViewModel.SalViewModel.ValgteSæder.Count - _børneBilleter;
                    OnPropertyChanged(nameof(SeniorBilleter));
                }
                OnPropertyChanged(nameof(VoksenBilleter));
                OnPropertyChanged();
            }
        }
        public int SeniorBilleter
        {
            get { return _seniorBilleter; }
            set
            {
                _seniorBilleter = value;
                _instance.Betaling.Billet.SeniorBillet = value;

                if (0 > VoksenBilleter)
                {
                    _børneBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - _seniorBilleter == 0
                        ? 0
                        : ForestillingViewModel.SalViewModel.ValgteSæder.Count - _seniorBilleter;
                    OnPropertyChanged(nameof(BørneBilleter));
                }
                OnPropertyChanged(nameof(VoksenBilleter));
                OnPropertyChanged();
            }
        }

        public List<int> BørneList
        {
            get
            {
                List<int> børneList = new List<int>();
                for (int i = 0; i <= VoksenBilleter; i++)
                {
                    børneList.Add(i);
                }
                return børneList;
            }
        }
        public List<int> SeniorList
        {
            get
            {
                List<int> seniorList = new List<int>();
                for (int i = 0; i <= VoksenBilleter; i++)
                {
                    seniorList.Add(i);
                }
                return seniorList;
            }
        }

        public ForestillingViewModel ForestillingViewModel
        {
            get { return _valgteForestillingViewModel; }
        }


        public Kunde Kunde
        {
            get { return Instance; }
            set
            {
                _instance = value;
                OnPropertyChanged();
            }
        }

        public Betaling Betaling
        {
            get { return Instance.Betaling; }
            set
            {
                _instance.Betaling = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
