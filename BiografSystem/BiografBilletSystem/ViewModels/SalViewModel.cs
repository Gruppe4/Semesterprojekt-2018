using BiografBilletSystem.Models;

namespace BiografBilletSystem.ViewModels
{
    class SalViewModel
    {
        private Sal _sal;
        private Bookinger _bookingList;

        public SalViewModel(Sal sal, Bookinger bookingList)
        {
            _sal = sal;
            _bookingList = bookingList;
        }
        public Sal Sal
        {
            //Implement Filter
            get { return _sal; }
            set { _sal = value; }
        }

       
        
    }
}
