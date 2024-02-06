using hotel_system.Data;
using hotel_system.Models;
using hotel_system.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace hotel_system.RepositoryPattern.Implementations
{
    public class GuestRepo : IGuest
    {
        private readonly HotelDbcontext _hotelDbcontext;

        public GuestRepo(HotelDbcontext hotelcontext)
        {
            _hotelDbcontext = hotelcontext;
        }
        public int CreateGuest(Guest guest)
        {
            int result = -1;
            if (guest == null)
            {
                result = 0;
            }
            else
            {
                _hotelDbcontext.Guests.Add(guest);
                _hotelDbcontext.SaveChanges();
                result = guest.Id;
            }
            return result;
        }

        public void Dispose()
        {
            _hotelDbcontext.Dispose();
        }

        public IEnumerable<Guest> GetAllGuests()
        {
            var x = _hotelDbcontext.Guests.ToList();
            return x;
        }

        public Guest GetGuestById(int id)
        {
            var y = _hotelDbcontext.Guests.Where(x => x.Id == id).FirstOrDefault() ?? null;
            return y;
        }
    }
}
