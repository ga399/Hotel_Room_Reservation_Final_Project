using System;
using Hotel_Room_Reservation_Final_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Hotel_Room_Reservation_Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace Hotel_Room_Reservation_Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Hotel_Room_ReservationIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Hotel_Room_Reservation_ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)

                     .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Hotel_Room_ReservationIdentityContext>();
            });
        }
    }
}