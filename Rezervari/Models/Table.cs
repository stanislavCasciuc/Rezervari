

namespace Rezervari.Models
{
    class Table
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }
}
