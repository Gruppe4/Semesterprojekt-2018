using System.Collections.Generic;

namespace BiografBilletSystem.Models
{
    public class Biograf
    {
        //To-do: skal holde styr på alle biografens Film, forestillinger og sale.

        private List<Film> _filmListe = new List<Film>();
        private List<Forestilling> _forestillingListe = new List<Forestilling>();

        public Biograf(List<Film> FilmListe, List<Forestilling> ForestillingListe)
        {
            _filmListe = FilmListe;
            _forestillingListe = ForestillingListe;
        }

        public void TilføjFilm(Film nyFilm)
        {
            _filmListe.Add(nyFilm);
        }

        public void TilføjForestilling(Forestilling nyForestiliing)
        {
            _forestillingListe.Add(nyForestiliing);
        }
    }
}
