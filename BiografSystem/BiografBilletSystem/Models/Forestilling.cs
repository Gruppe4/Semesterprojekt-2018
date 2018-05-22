using System;

namespace BiografBilletSystem.Models
{
    public class Forestilling
    {
        //To-do: Skal indeholde alt relevant information om en specifik forestilling

        public DateTime StartTid { get; private set; }

        public Film Film { get; private set; }

        public Sal Sal { get; private set; }

    
    }
}