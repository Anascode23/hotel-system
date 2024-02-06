namespace hotel_system.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Guest guest_id { get; set; }
        public Rooms room_id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
