namespace rezervari.Models
{
  class Reservation
  {
    public int Id { get; set; }
    public int TableId { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public int NumberOfPeople { get; set; }

    public Reservation(int tableId, int userId, DateTime date, int duration, int numberOfPeople)
    {
      TableId = tableId;
      UserId = userId;
      Date = date;
      Duration = duration;
      NumberOfPeople = numberOfPeople;
    }

    public string Info()
    {
      return $"ID: {Id}, Table ID: {TableId}, User ID: {UserId}, Date: {Date}, Duration: {Duration}, Number of people: {NumberOfPeople}";
    }
  }
}
