using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemoApp.Models
{
    public class Reservation
    {
        //we have to make it readonly hence we will have the option to get method only not to write it for this application 
        public RoomID RoomID { get; }
        public string UserName { get;  }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        //defining the constructor to initialize the reservation constructor for this purpose 
        //as we have made the attributes as read only hence we have to assign the values inside the constructor itself 
        public Reservation(RoomID roomID, string userName, DateTime startTime, DateTime endTime)
        { 
            RoomID = roomID;    
            UserName = userName;    
            StartTime = startTime;  
            EndTime = endTime;
        }
    }
}
