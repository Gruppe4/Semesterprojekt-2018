using System.Collections.Generic;
using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    public class MainViewModel
    {
        private Biograf _biograf;
        private Film _selectedFilm;
        private List<Forestilling> _forestillingsListe;
        private Forestilling _selectedForestilling;

        public MainViewModel()
        {
            _biograf = new Biograf();
            _selectedFilm = null;
            _selectedForestilling = null;
            _forestillingsListe = _biograf.AlleForestillinger;
        }

        public List<Film> AlleFilm
        {
            get { return _biograf.AlleFilm; }
        }

        public Film SelectedFilm
        {
            get { return _selectedFilm; }
            set { _selectedFilm = value; }
        }

        public Forestilling SelectedForestilling
        {
            get { return _selectedForestilling; }
            set { _selectedForestilling = value; }
        }
    }
}
