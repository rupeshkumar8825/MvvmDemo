using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemoApp.Models
{
    class Hotel
    {
        //defining the instance of the reservation book for this purpose 
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        //defining the constructor for this purpose 
        public Hotel(string name)
        { 
            _reservationBook = new ReservationBook();
            Name = name;
        }

        //we have to add the functionality for the fetching the list of reservations given the username 
        public IEnumerable<Reservation> GetReservationForUser(string userName)
        { 
            return _reservationBook.GetReservationForUser(userName);
        }

        //function to make the reservation for the hotel and for the current customer 
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
