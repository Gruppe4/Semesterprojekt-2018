using System.Collections.Generic;
using System.Linq;

namespace BiografBilletSystem.Models
{
    public class Biograf
    {
        //To-do: skal holde styr på alle biografens Film, forestillinger og sale.
        #region Singleton
        private static Biograf _instance;
        public static Biograf Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new Biograf());
                return _instance;
            }
        }
        #endregion

        #region Instance Fields

        private List<Film> _filmListe;
        private List<Forestilling> _forestillingListe;
        private List<Sal> _salList;

        #endregion

        #region Constructor

        public Biograf()
        {
            _filmListe = new List<Film>();
            _forestillingListe = new List<Forestilling>();
            _salList = new List<Sal>();
        }

        #endregion

        #region Methods

        public Film HentFilm(string filmTitel)
        {

            foreach (var film in _filmListe)
            {
                if (film.Titel == filmTitel)
                {
                    return film;
                }
            }

            return null;
        }

        
        public void TilføjFilm(Film nyFilm)
        {
            _filmListe.Add(nyFilm);
        }

        public void TilføjForestilling(Forestilling nyForestiliing)
        {
            _forestillingListe.Add(nyForestiliing);
        }

        public void TilføjSal(Sal nySal)
        {
            _salList.Add(nySal);
        }

        #endregion
    }
}
