using System.Collections.Generic;
using System.Linq;

namespace BiografBilletSystem.Models
{
    public class Biograf
    {
        //To-do: skal holde styr på alle biografens Film, forestillinger og sale.

        private List<Film> _filmListe;
        private List<Forestilling> _forestillingListe;
        private List<Sal> _salList;

        public Biograf()
        {
            _filmListe = new List<Film>();
            _forestillingListe = new List<Forestilling>();
            _salList = new List<Sal>();
        }
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
    }
}
