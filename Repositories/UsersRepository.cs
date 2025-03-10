using rezervari.Models;

namespace rezervari.Repositories
{
  public class UsersRepository
  {
    private const int MAX_USERS = 100;
    private User[] users;
    private int usersCount;

    public UsersRepository()
    {
      users = new User[MAX_USERS];
      usersCount = 0;
    }

    public void Add(User user)
    {
      if (usersCount < MAX_USERS)
      {
        users[usersCount++] = user;
      }
    }
    public User[] GetAll()
    {
      var allUsers = new User[usersCount];
      Array.Copy(users, allUsers, usersCount);
      return allUsers;
    }

    public User? GetById(int id)
    {
      foreach (User user in users)
      {
        if (user.Id == id)
        {
          return user;
        }
      }
      return null;
    }
    public User? GetAuthUser(string email, string password)
    {
      foreach (User user in users)
      {
        if (user.Email == email && user.Password == password)
        {
          return user;
        }
      }
      return null;
    }

  }
}
