using mvvmDemoApp.Exceptions;
using mvvmDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace mvvmDemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            Hotel hotel = new Hotel("SingletonSean Suites");
            Console.WriteLine("I have created a new hotel ");
            //putting this in the try catch block for this purpose 
            try
            {

                hotel.MakeReservation(new Reservation(new RoomID(1, 3), "SingletonSeon", new DateTime(2000, 1, 1), new DateTime(2000, 1, 4)));
                Console.WriteLine("Added the first reservation successfully\n");
                //now adding the new reservation for this purpose 
                hotel.MakeReservation(new Reservation(new RoomID(1, 2), "SingletonSeon", new DateTime(2000, 1, 1), new DateTime(2000, 1, 4)));
                Console.WriteLine("Added the second reservation successfully\n");
            }
            catch (ReservationConflictException ex)
            {
                Console.WriteLine("OOPS GOT A exception");
                Console.WriteLine(ex);
              
            }




            IEnumerable<Reservation> reservations = hotel.GetReservationForUser("SingletonSean");


            base.OnStartup(e);
        }
    }
}
