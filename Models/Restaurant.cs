namespace rezervari.Models
{
  public class Restaurant
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    public string PhoneNumber { get; set; }

    public int UserId { get; set; }

    public Restaurant(string name, string location, string phoneNumber, int userId)
    {
      Name = name;
      Location = location;
      PhoneNumber = phoneNumber;
      UserId = userId;
    }

    public string Info()
    {
      return $"ID: {ID}, Name: {Name}, Location: {Location}, Phone: {PhoneNumber}, User ID: {UserId}";
    }
  }

}
