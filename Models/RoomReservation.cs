using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Room_Reservation_Final_Project.Models
{
    public class RoomReservation
    {
        public int Id { get; set; }

        public int ClientId  { get; set; }

        public int HotelId { get; set; }
        
        public Client Client { get; set; }

        public Hotel Hotel { get; set;  }

    }
}
