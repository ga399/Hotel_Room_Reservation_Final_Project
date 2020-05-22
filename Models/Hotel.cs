using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Room_Reservation_Final_Project.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string HotelName { get; set; }

        public int TotalRooms { get; set;  }

        public int BookedRooms { get; set; }

        public int RemainingRooms {
            get { return TotalRooms - BookedRooms; }
                                 
                
                
               }


        public decimal RoomPrice { get; set; }

        public string Address { get; set; }




    }
}
