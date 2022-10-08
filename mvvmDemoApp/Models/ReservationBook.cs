using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemoApp.Models
{
    public class ReservationBook
    {
        //defining the dictionary to store the reservation book for this purpose 
        private readonly List<Reservation> _roomsToReservations;


        //defining the constructor for reservationbook
        public ReservationBook()
        {
            _roomsToReservations = new List<Reservation>();
        }
    }
}
