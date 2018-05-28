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

            _valgteSæder = ValgteSæder;
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
                    for (int j = 0; j < _bookingList.AlleKunder[i].BestiltSædeIndex.Count; j++)
                    {
                        _sædeList[_bookingList.AlleKunder[i].BestiltSædeIndex[j]].Reserveret = true;
                    }
                }
                return _sædeList;
            }
        }

        public List<Sæde> ValgteSæder
        {
            get
            {
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
