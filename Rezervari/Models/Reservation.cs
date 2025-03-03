

namespace Rezervari.Models
{
    class Reservation
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
