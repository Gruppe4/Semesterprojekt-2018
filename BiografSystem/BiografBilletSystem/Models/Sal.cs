using System.Collections.Generic;

namespace BiografBilletSystem.Models
{
    public class Sal
    {
        // To-do: Skal indeholde relevant information om en specifik sal
        private int _rækker;
        private int _sæder;
        List<Sæde> _sædeList = new List<Sæde>();
        private int _salNr;
        public static int salInstance = 1;

        public Sal(int sæderPrRække, int rækker)
        {
            _sæder = sæderPrRække * rækker;
            _rækker = rækker;
            _salNr = salInstance;
            salInstance++;
            for (int index = 0; index < _sæder; index++)
            {
                _sædeList.Add(LavSæde(index));
            }
        }

        public List<Sæde> SædeList
        {
            get { return _sædeList; }
        }

        public int SalNr
        {
            get { return _salNr; }
        }

        public Sæde ReturnerSæde(int index)
        {
            return _sædeList[index];
        }
        public Sæde LavSæde(int index)
        {
            return new Sæde(SædeRække(index), SædeNummer(index));
        }
        public int SædeNummer(int index)
        {
            index = index % _rækker + 1;
            int sæderPrRække = ((_sæder / _rækker));
            if (sæderPrRække % 2 == 0)
            {
                if (index < sæderPrRække / 2)
                {
                    return (sæderPrRække - index * 2 - 2);
                }
                else
                {
                    return (index - (sæderPrRække + 1) % index);

                }
            }
            else
            {
                if (index < sæderPrRække / 2)
                {
                    return ((sæderPrRække - 1) - index * 2 - 2);
                }
                else
                {
                    return (index - sæderPrRække % index);

                }
            }
        }

        public override string ToString()
        {
            return $"Sal Nr: {SalNr}";
        }

        public int SædeRække(int index)
        {
            return index / _rækker;
        }
    }
}