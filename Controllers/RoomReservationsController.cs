using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel_Room_Reservation_Final_Project.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_Room_Reservation_Final_Project.Controllers
{
    public class RoomReservationsController : Controller
    {
        private readonly Hotel_Room_ReservationContext _context;

        SignInManager<IdentityUser> SignInManager;
        UserManager<IdentityUser> UserManager;

        public RoomReservationsController(Hotel_Room_ReservationContext context,


             SignInManager<IdentityUser> SignInManager,
           UserManager<IdentityUser> UserManager
            )
        {

            this.SignInManager = SignInManager;
            this.UserManager = UserManager;
            _context = context;
        }

        // GET: RoomReservations
        [Authorize(Roles = "hotel_admin,client")]
        public async Task<IActionResult> Index()
        {
            var hotel_Room_ReservationContext = _context.RoomReservation.Include(r => r.Client).Include(r => r.Hotel);

            if (SignInManager.IsSignedIn(User) && User.IsInRole("client")) {

               var  hotel_Room_ReservationContext_Client = _context.RoomReservation.Include(r => r.Client)
                    .Include(r => r.Hotel).Where(r => r.Client.Email.Equals(User.Identity.Name));
                return View(await hotel_Room_ReservationContext_Client.ToListAsync());


            }
            
            
            return View(await hotel_Room_ReservationContext.ToListAsync());
        }

        // GET: RoomReservations/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReservation = await _context.RoomReservation
                .Include(r => r.Client)
                .Include(r => r.Hotel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomReservation == null)
            {
                return NotFound();
            }

            return View(roomReservation);
        }

        // GET: RoomReservations/Create
        [Authorize(Roles = "client")]
        public IActionResult Create(int id )
        {

            if (SignInManager.IsSignedIn(User)) {

                var client = (from clients in _context.Client
                              where clients.Email.Equals(User.Identity.Name)
                              select clients).FirstOrDefault();

                RoomReservation reservation = new RoomReservation();

                reservation.HotelId = id;
                reservation.ClientId = client.Id;
                _context.Add(reservation);
                _context.SaveChanges();

                var clientReservation = _context.RoomReservation.Include(r => r.Client)
                                           .Include(r => r.Hotel)
                                           .FirstOrDefault(r => r.Id == reservation.Id);
                clientReservation.Hotel.BookedRooms = clientReservation.Hotel.BookedRooms + 1;
                _context.Update(clientReservation);
                _context.SaveChanges();
                return View(clientReservation);

            
            
            }

            return View();
           
        }




        // GET: RoomReservations/Edit/5
        [Authorize(Roles = "hotel_admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReservation = await _context.RoomReservation.FindAsync(id);
            if (roomReservation == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", roomReservation.ClientId);
            ViewData["HotelId"] = new SelectList(_context.Hotel, "Id", "Id", roomReservation.HotelId);
            return View(roomReservation);
        }

        // POST: RoomReservations/Edit/5
      

        // GET: RoomReservations/Delete/5
        [Authorize(Roles = "hotel_admin,client")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReservation = await _context.RoomReservation
                .Include(r => r.Client)
                .Include(r => r.Hotel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomReservation == null)
            {
                return NotFound();
            }

            return View(roomReservation);
        }

        // POST: RoomReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "hotel_admin,client")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomReservation = await _context.RoomReservation.Include(r=>r.Hotel).FirstOrDefaultAsync(r=>r.Id == id);
            _context.RoomReservation.Remove(roomReservation);
            roomReservation.Hotel.BookedRooms = roomReservation.Hotel.BookedRooms - 1;
            await _context.SaveChangesAsync();



            return RedirectToAction(nameof(Index));
        }

        private bool RoomReservationExists(int id)
        {
            return _context.RoomReservation.Any(e => e.Id == id);
        }
    }
}
