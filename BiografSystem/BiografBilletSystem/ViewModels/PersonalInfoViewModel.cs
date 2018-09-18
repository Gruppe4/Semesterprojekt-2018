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
        private bool _medlem;
        private int _pris;
        public static Kunde Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new Kunde("Henrik Andersen", "Hillerødvej 1", "Henrik@Andersen.com", 3400, 48484848, new List<Sæde>()));
                return _instance;
            }
        }

        public PersonalInfoViewModel()
        {
            _instance = new Kunde("Henrik Andersen", "Hillerødvej 1", "Henrik@Andersen.com", 3400, 48484848, new List<Sæde>());
            Instance.Betaling = new Betaling(4545454545454545, 666, new DateTime(), "Henrik Andersen");
            _valgteForestillingViewModel = ForestillingViewModel.Instance;
            _instance.BestilteSæder = _valgteForestillingViewModel.SalViewModel.ValgteSæder;
            VoksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count;
            _seniorBilleter = 0;
            _børneBilleter = 0;
            _medlem = _instance.Betaling.Billet.Medlemsskab;
        }

        public int VoksenBilleter
        {
            get
            {
                _voksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - (BørneBilleter + SeniorBilleter);
                _instance.Betaling.Billet.VoksenBillet = _voksenBilleter;
                OnPropertyChanged(nameof(Pris));
                return _voksenBilleter;
            }
            set
            {
                _voksenBilleter = ForestillingViewModel.SalViewModel.ValgteSæder.Count - (_børneBilleter + _seniorBilleter);
                _instance.Betaling.Billet.VoksenBillet = value;
                OnPropertyChanged(nameof(Pris));
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
                    _instance.Betaling.Billet.SeniorBillet = _seniorBilleter;
                    OnPropertyChanged(nameof(SeniorBilleter));
                }
                OnPropertyChanged(nameof(VoksenBilleter));
                OnPropertyChanged();
                OnPropertyChanged(nameof(Pris));
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
                    _instance.Betaling.Billet.BørneBillet = _børneBilleter;
                    OnPropertyChanged(nameof(BørneBilleter));
                }
                OnPropertyChanged(nameof(VoksenBilleter));
                OnPropertyChanged();
                OnPropertyChanged(nameof(Pris));
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

        public bool Medlem
        {
            get { return _medlem; }
            set
            {
                _medlem = value;
                _instance.Betaling.Billet.Medlemsskab = value;
                OnPropertyChanged(nameof(Pris));
            }
        }
        public int Pris
        {
            get { return _pris = Kunde.Betaling.Billet.Pris(); }
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
