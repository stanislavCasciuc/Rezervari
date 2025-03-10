namespace rezervari.Models
{
  public class User
  {
    public int? Id { get; set; }
    public string Name { get; set; }
    public int[] PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string name, string phoneNumber, string email, string password)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber.Split(' ').Select(int.Parse).ToArray();
      Password = password;
    }

    public string Info()
    {
      return $"ID: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Password: {Password}";
    }
  }
}
