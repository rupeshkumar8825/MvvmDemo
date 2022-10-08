using mvvmDemoApp.Exceptions;
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
        private readonly List<Reservation> _reservations;


        //defining the constructor for reservationbook
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }


        //defining the enumerable for getting the list of reservations a particular user 
        public IEnumerable<Reservation> GetReservationForUser(string userName)
        { 
            return _reservations.Where(x => x.UserName == userName);
        }

        //defining the method to add a reservation 
        public void AddReservation(Reservation reservation)
        {
            //we have to check whether the reservation or room is already booked or not for this purpose 
            //iterating over all the reservation that currently present 
            //using the for loop for this purpose 
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    //then we have to throw the new exception for this purpose 
                    throw new ReservationConflictException(existingReservation, reservation);
                }

            }
            _reservations.Add(reservation);  
        }
    }
}
