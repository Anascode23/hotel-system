using hotel_system.Models;
using hotel_system.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace hotel_system.Controllers
{
    public class HotelController : Controller
    {
        private readonly IGuest _guest;

        public HotelController(IGuest guest)
        {
            _guest = guest;
        }
        [HttpGet]
        [Route("GetAllGuests")]
        public IActionResult GetAllGuests()
        {
            var a = _guest.GetAllGuests();
            if (a == null)
            {
                return NotFound();
            }

            return Ok(a);
        }
        [HttpGet]
        [Route("GetGuestById")]
        public IActionResult GetGuestById(int id)
        {
            Guest guest = _guest.GetGuestById(id);
            if (guest == null)
            {
                return NotFound("guest not found");
            }
            return Ok(guest);
        }
        [HttpPost]
        [Route("CreateGuest")]
        public IActionResult CreateGuest(Guest guest)
        {
            int st = _guest.CreateGuest(guest);
            if (st <= 0)
            {
                return BadRequest("Failed to create guest");
            }
            else
                return Ok("Added guest " + st);
        }

    }
}
