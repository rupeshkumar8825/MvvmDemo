using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemoApp.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        //defining the constructor for this purpose 
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }


        //overriding the equal method so that dictionaries knows how to comapre these keys 
        public override bool Equals(object obj)
        {
            return (obj is RoomID roomID &&  
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber);
        }

        //since we are overriding the equal then we also have to set the hashcode 
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        //we can also override the to string question for this class 
        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}"; 
        }

        //we have to now override the equals operator 
        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
            
        }
    }
}
