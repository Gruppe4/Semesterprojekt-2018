﻿using System.Collections.Generic;
using System.Linq;
using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    class SalViewModel
    {
        private Sal _sal;
        private Bookinger _bookingList;
        private List<Sæde> _valgteSæder;

        public SalViewModel(Sal sal, Bookinger bookingList)
        {
            _sal = sal;
            _bookingList = bookingList;
        }
        public Sal Sal
        {
            get { return _sal; }
        }

        public List<Sæde> SædeList
        {
            get
            {
                List<Sæde> sædeList = new List<Sæde>();
                sædeList = Sal.SædeList;
                for (int i = 0; i < _bookingList.AlleKunder.Count; i++)
                {
                    for (int j = 0; j < _bookingList.AlleKunder[i].BestiltSædeIndex.Count; j++)
                    {
                        sædeList[_bookingList.AlleKunder[i].BestiltSædeIndex[j]].Reserveret = true;
                    }
                }
                return sædeList;
            }
        }

        public List<Sæde> ValgteSæder
        {
            get { return _valgteSæder; }
            set { _valgteSæder = value; }
        }


    }
}
