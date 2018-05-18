using System;

namespace BiografBilletSystem.Models
{
    class Factory
    {
        public Factory()
        {
            Film film1 = new Film("The Dark Knight", 152, "Christian Bale, Heath Ledger, Aaron Eckhart", 
                "Christopher Nolan", "Action, Crime, Drama"
                , "When the menace known as the Joker emerges from his mysterious past, " +
                  "he wreaks havoc and chaos on the people of Gotham. " +
                  "The Dark Knight must accept one of the greatest psychological " +
                  "and physical tests of his ability to fight injustice.", 
                new DateTime(2018, 7, 18), "URL The Dark Knight ");


        }




    }
}
