using BiografBilletSystem.Models;
using System.Collections.Generic;

namespace BiografBilletSystem.ViewModels
{
    public class MainViewModel
    {
        private Biograf _biograf;
        private Film _selectedFilm;
        private List<Forestilling> _forestillingsListe;
        private Forestilling _selectedForestilling;
        private SalViewModel _salViewModel;

        public MainViewModel()
        {
            _biograf = new Biograf();
            _selectedFilm = null;
            _forestillingsListe = _biograf.AlleForestillinger;
            _selectedForestilling = _forestillingsListe[0];
            _salViewModel = new SalViewModel(_selectedForestilling.Sal, _selectedForestilling.AlleBookinger);
        }

        public List<Film> AlleFilm
        {
            get { return _biograf.AlleFilm; }
        }

        public List<Forestilling> AlleForestillinger
        {
            //Implement sorting
            get { return _forestillingsListe; }
        }

        public Film SelectedFilm
        {
            get { return _selectedFilm; }
            set { _selectedFilm = value; }
        }

        public Forestilling SelectedForestilling
        {
            get { return _selectedForestilling; }
            set
            {
                _selectedForestilling = value;
            }
        }
    }
}
