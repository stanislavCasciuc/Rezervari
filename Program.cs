using rezervari.Models;
using rezervari.Repositories;

UsersRepository usersRepository = new UsersRepository();
string opt = "";
do
{
  Console.WriteLine("C. Citire utilizator de la tastatura");
  Console.WriteLine("R. Afisare utilizatori");
  Console.WriteLine("U. Afisare utilizator dupa ID");
  Console.WriteLine("A. Autentificare utilizator");
  Console.WriteLine("X. Iesire");

  Console.Write("Optiunea dvs: ");
  opt = Console.ReadLine();

  switch (opt.ToUpper())
  {
    case "C":
      Console.Write("Nume: ");
      string? name = Console.ReadLine();
      Console.Write("Email: ");
      string? email = Console.ReadLine();
      Console.Write("Numara de telefon: ");
      string? phoneNumber = Console.ReadLine();
      Console.Write("Parola: ");
      string? password = Console.ReadLine();
      User user = new User(name, phoneNumber, email, password);
      usersRepository.Add(user);
      break;
    case "R":
      foreach (User currentuser in usersRepository.GetAll())
      {
        Console.WriteLine(currentuser.Info());
      }
      break;
    case "U":
      Console.Write("ID: ");
      int id = int.Parse(Console.ReadLine());
      User? userById = usersRepository.GetById(id);
      if (userById != null)
      {
        Console.WriteLine(userById.Info());
      }
      else
      {
        Console.WriteLine("Utilizatorul nu exista!");
      }
      break;
    case "A":
      Console.Write("Email: ");
      string? emailAuth = Console.ReadLine();
      Console.Write("Parola: ");
      string? passwordAuth = Console.ReadLine();
      User? authUser = usersRepository.GetAuthUser(emailAuth, passwordAuth);
      if (authUser != null)
      {
        Console.WriteLine(authUser.Info());
      }
      else
      {
        Console.WriteLine("Autentificare esuata!");
      }
      break;
    case "X":
      Console.WriteLine("La revedere!");
      break;
    default:
      Console.WriteLine("Optiune invalida!");
      break;
  }
} while (opt.ToUpper() != "X");


