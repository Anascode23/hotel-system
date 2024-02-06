using hotel_system.Models;

namespace hotel_system.RepositoryPattern.Interfaces
{
    public interface IGuest : IDisposable
    {
        IEnumerable<Guest> GetAllGuests();
        Guest GetGuestById(int id);
        int CreateGuest(Guest guest); 
    }
}
