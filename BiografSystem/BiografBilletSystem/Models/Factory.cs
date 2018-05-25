using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace BiografBilletSystem.Models
{
    static class Factory
    {

        public static List<Film> PopulateFilms()
        {
            List<Film> filmListe = new List<Film>() {new Film("The Dark Knight", 152, "Christian Bale, Heath Ledger, Aaron Eckhart",
                        "Christopher Nolan", "Action, Crime, Drama"
                        , "When the menace known as the Joker emerges from his mysterious past, " +
                          "he wreaks havoc and chaos on the people of Gotham. " +
                          "The Dark Knight must accept one of the greatest psychological " +
                          "and physical tests of his ability to fight injustice.",
                        new DateTime(2018, 7, 18), "Images/The Dark Knight.jpg")};
            return filmListe;
        }

        public static List<Sal> PopulateSale()
        {
            List<Sal> salListe = new List<Sal>() { new Sal(30, 22), new Sal(19, 15) };
            return salListe;
        }

        public static List<Forestilling> PopulateForestillinger(List<Sal> salList, List<Film> filmList)
        {
            List<Forestilling> forestillingsListe = new List<Forestilling>() { new Forestilling(salList[0], filmList[0], DateTime.Now.AddDays(1)) };
            return forestillingsListe;
        }
    }
}
