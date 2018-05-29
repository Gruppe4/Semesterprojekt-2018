using BiografBilletSystem.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using BiografBilletSystem.Annotations;

namespace BiografBilletSystem.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Biograf _biograf;
        private Film _selectedFilm;
        private List<Forestilling> _forestillingsListe;
        public static Forestilling selectedForestilling;
        private SalViewModel _salViewModel;

        public MainViewModel()
        {
            _biograf = Biograf.Instance;
            _selectedFilm = null;
            _forestillingsListe = _biograf.AlleForestillinger;
            selectedForestilling = _forestillingsListe[0];
            _salViewModel = new SalViewModel(selectedForestilling.Sal, selectedForestilling.AlleBookinger);
        }

        public List<Film> AlleFilm
        {
            get { return _biograf.AlleFilm; }
        }

        public List<Forestilling> AlleForestillinger
        {
            //Implement sorting
            get
            {
                if (SelectedFilm == null)
                {
                    var forestillingerList = from forestilling in _biograf.AlleForestillinger
                        orderby forestilling.StartTid
                        select forestilling;
                    SelectedForestilling = forestillingerList.First();
                    return forestillingerList.ToList();
                }
                else
                {
                    var forestillingerList = from forestilling in _biograf.AlleForestillinger
                        where forestilling.Film.Titel == SelectedFilm.Titel
                              orderby forestilling.StartTid
                        select forestilling;
                    SelectedForestilling = forestillingerList.First();
                    return forestillingerList.ToList();
                }
            }
        }

        public Film SelectedFilm
        {
            get { return _selectedFilm; }
            set
            {
                _selectedFilm = value;
                OnPropertyChanged(nameof(AlleForestillinger));
            }
        }

        

        public Forestilling SelectedForestilling
        {
            get
            {
                if (selectedForestilling == null)
                {
                    return AlleForestillinger[0];
                }
                else
                {
                    return selectedForestilling;
                }
            }
            set
            {
                selectedForestilling = value;
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
