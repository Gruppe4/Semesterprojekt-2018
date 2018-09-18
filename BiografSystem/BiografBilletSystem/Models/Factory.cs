using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BiografBilletSystem.Models
{
    static class Factory
    {

        public static List<Film> PopulateFilms()
        {
            List<Film> filmListe = new List<Film>()
            {
                new Film("The Dark Knight", 152, "Christian Bale, Heath Ledger, Aaron Eckhart",
                    "Christopher Nolan", "Action, Crime, Drama"
                    , "When the menace known as the Joker emerges from his mysterious past, " +
                      "he wreaks havoc and chaos on the people of Gotham. " +
                      "The Dark Knight must accept one of the greatest psychological " +
                      "and physical tests of his ability to fight injustice.",
                    new DateTime(2008, 7, 18), "Images/The Dark Knight.jpg")
            };


            filmListe.Add(new Film("Terminator 2: Judgment Day", 137, "Arnold Schwarzenegger, Linda Hamilton, Edward Furlong",
                "James Cameron",
                "Action, Sci-Fi",
                "A cyborg, identical to the one who failed to kill Sarah Connor," +
                "must now protect her teenage son," +
                "John Connor, from a more advanced and powerful cyborg",
                new DateTime(1991, 7, 3), "Images/Terminator2.jpg"));


            filmListe.Add(new Film("Alien", 116, "Sigourney Weaver, Tom Skerritt, John Hurt", "Ridley Scott",
                "Horror Sci-Fi",
                "After a space merchant vessel perceives an unknown transmission as a distress call," +
                "its landing on the source moon finds one of the crew attacked by a mysterious lifeform," +
                "and they soon realize that its life cycle has merely begun.",
                new DateTime(1979, 6, 22), "Images/Alien.jpg"));

            filmListe.Add(new Film("Pulp Fiction", 154, "John Travolta, Uma Thurman, Samuel L Jackson",
                "Quentin Tarantino", "Crime, Drama",
                "The lives of two mob hitmen, a boxer, a gangster's wife," +
                "and a pair of diner bandits intertwine in four tales of violence and redemption.",
                new DateTime(1994, 10, 14), "Images/PulpFiction.jpg"));


            filmListe.Add(new Film("The Room", 99, "Tommy Wiseau, Greg Sestero, Juliette Danielle", "Tommy Wiseau",
                "Drama",
                "Johnny is a successful banker who lives happily in a San Francisco townhouse with his fiancée, Lisa." +
                "One day, inexplicably, she gets bored with him and decides to seduce his best friend, Mark." +
                "From there, nothing will be the same again.",
                new DateTime(2003, 3, 3), "Images/TheRoom.jpg"));

            return filmListe;
        }

        public static List<Sal> PopulateSale()
        {
            List<Sal> salListe = new List<Sal>()
            {
                new Sal(18, 10),
                new Sal(18, 9),
                new Sal(16, 9),
                new Sal(15, 8),
                new Sal(15, 7)
            };
            return salListe;
        }



        public static List<Forestilling> PopulateForestillinger(List<Sal> salList, List<Film> filmList)
        {
            List<Forestilling> forestillingsListe = new List<Forestilling>()
            {
                new Forestilling(salList[0], filmList[0], DateTime.Now.AddDays(1)),
                new Forestilling(salList[2], filmList[0], DateTime.Now.AddDays(2)),
                new Forestilling(salList[3], filmList[0], DateTime.Now.AddDays(4)),
                new Forestilling(salList[1], filmList[1], DateTime.Now.AddDays(1)),
                new Forestilling(salList[1], filmList[1], DateTime.Now.AddDays(2)),
                new Forestilling(salList[2], filmList[1], DateTime.Now.AddDays(5)),
                new Forestilling(salList[2], filmList[2], DateTime.Now.AddDays(1)),
                new Forestilling(salList[0], filmList[2], DateTime.Now.AddDays(2)),
                new Forestilling(salList[2], filmList[2], DateTime.Now.AddDays(3)),
                new Forestilling(salList[3], filmList[3], DateTime.Now.AddDays(1)),
                new  Forestilling(salList[4], filmList[3], DateTime.Now.AddDays(2)),
                new Forestilling(salList[0], filmList[3], DateTime.Now.AddDays(4)),
                new Forestilling(salList[4], filmList[4], DateTime.Now.AddDays(1)),
                new Forestilling(salList[3], filmList[4], DateTime.Now.AddDays(2)),
                new Forestilling(salList[1], filmList[4], DateTime.Now.AddDays(5))

            };
            return forestillingsListe;
        }

        public static List<Sæde> TilfældigSædeList()
        {
            Random rng = new Random();
            List<Sæde> sædeList = new List<Sæde>();
            int bookinger = rng.Next(5, 15);
            for (int i = 0; i < bookinger; i++)
            {
                int række = rng.Next(1, 7);
                int nummer = rng.Next(0, 15);
                int antal = rng.Next(5);
                sædeList.Add(new Sæde(række, nummer));
                for (int y = 1; y <= antal; y++)
                {
                    if (y % 2 == 0)
                    {
                        sædeList.Add(new Sæde(række, nummer + 2 * (y / 2)));
                    }
                    else
                    {
                        sædeList.Add(new Sæde(række, nummer - 2 * (y / 2)));
                    }
                }
            }

            return sædeList;
        }
        public static List<Kunde> PopulateBookingList()
        {
            Task.Delay(20).Wait();
            List<Kunde> kundeListe = new List<Kunde>();
            kundeListe.Add(new Kunde("TestName", "TestAdress", "TestEmail", 1111, 11111111, TilfældigSædeList()));

            return kundeListe;
        }
    }
}
