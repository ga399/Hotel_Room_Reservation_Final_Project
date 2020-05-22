using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_Room_Reservation_Final_Project.Models;

namespace Hotel_Room_Reservation_Final_Project.Models
{
    public class Hotel_Room_ReservationContext : DbContext
    {
        public Hotel_Room_ReservationContext (DbContextOptions<Hotel_Room_ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_Room_Reservation_Final_Project.Models.Client> Client { get; set; }

        public DbSet<Hotel_Room_Reservation_Final_Project.Models.Hotel> Hotel { get; set; }

        public DbSet<Hotel_Room_Reservation_Final_Project.Models.RoomReservation> RoomReservation { get; set; }
    }
}
