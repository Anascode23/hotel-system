using hotel_system.Models;
using Microsoft.EntityFrameworkCore;

namespace hotel_system.Data
{
    public class HotelDbcontext : DbContext
    {
        public HotelDbcontext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Rooms> rooms { get; set; }
        public DbSet<Booking> bookings { get; set; }
    }
}
