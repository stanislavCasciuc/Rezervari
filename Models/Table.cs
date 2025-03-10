
namespace rezervari.Models
{
  class Table
  {
    public int Id { get; set; }
    public int RestaurantId { get; set; }
    public int Number { get; set; }
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; }

    public Table(int id, int restaurantId, int number, int capacity, bool isAvailable)
    {
      Id = id;
      RestaurantId = restaurantId;
      Number = number;
      Capacity = capacity;
      IsAvailable = isAvailable;
    }
    public virtual string Info()
    {
      return $"Id: {Id}, RestaurantId: {RestaurantId}, Number: {Number}, Capacity: {Capacity}, IsAvailable: {IsAvailable}";
    }

  }
}
