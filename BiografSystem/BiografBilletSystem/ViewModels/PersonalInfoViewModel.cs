using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using BiografBilletSystem.Annotations;
using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    class PersonalInfoViewModel : INotifyPropertyChanged
    {
        public Kunde _kunde;
        public Betaling _betaling;

        public PersonalInfoViewModel()
        {
            _kunde = new Kunde("(Navn)", "(Addresse)","(Email)", 0000, 00000000, new List<int>());
            _betaling = new Betaling(0,000,new DateTime(),"(Navn på kortholder)");
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set
            {
                _kunde = value;
                OnPropertyChanged(nameof(Kunde));
            }
        }

        public Betaling Betaling
        {
            get { return _betaling; }
            set
            {
                _betaling = value;
                OnPropertyChanged(nameof(Betaling));
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
