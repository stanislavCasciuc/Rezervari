namespace rezervari.Models
{
  public class Restaurant
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public Restaurant(int id, string name, string address)
    {
      Id = id;
      Name = name;
      Address = address;
    }

    public virtual string Info()
    {
      return $"Id: {Id}, Name: {Name}, Address: {Address}";
    }
  }
}
