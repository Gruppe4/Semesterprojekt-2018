using BiografBilletSystem.Models;
using System.Collections.Generic;

namespace BiografBilletSystem.ViewModels
{
    class SalViewModel
    {
        private Sal _sal;
        private Bookinger _bookingList;
        private List<Sæde> _valgteSæder;
        private List<Sæde> _sædeList;

        public SalViewModel(Sal sal, Bookinger bookingList)
        {
            _sal = sal;
            _bookingList = bookingList;
            foreach (var sæde in Sal.SædeList)
            {
                sæde.Checked = false;
            }

            _valgteSæder = new List<Sæde>();
        }
        public Sal Sal
        {
            get { return _sal; }
        }

        public List<Sæde> SædeList
        {
            get
            {
                _sædeList = Sal.SædeList;
                
                for (int i = 0; i < _bookingList.AlleKunder.Count; i++)
                {
                    foreach (var a in _bookingList.AlleKunder[i].BestilteSæder)
                    {
                        foreach (var b in _sædeList)
                        {
                            if (b.Nummer == a.Nummer && b.RækkeNr == a.RækkeNr)
                            {
                                b.Reserveret = true;
                            }
                        }
                    }
                }
                return _sædeList;
            }
        }

        public List<Sæde> ValgteSæder
        {
            get
            {
                _valgteSæder.Clear();
                foreach (var sæde in SædeList)
                {
                    if (sæde.Checked)
                    {
                        _valgteSæder.Add(sæde);
                    }
                }
                return _valgteSæder;
            }
        }


    }
}
