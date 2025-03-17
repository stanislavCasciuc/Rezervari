using rezervari.Models;
using rezervari.Repositories;

UsersRepository usersRepository = new UsersRepository();
TablesRepository tablesRepository = new TablesRepository();
RestaurantsRepository restaurantsRepository = new RestaurantsRepository();
ReservationsRepository reservationsRepository = new ReservationsRepository();
string? opt = "";
do
{
  Console.WriteLine("C. Citire utilizator de la tastatura");
  Console.WriteLine("R. Afisare utilizatori");
  Console.WriteLine("U. Afisare utilizator dupa ID");
  Console.WriteLine("A. Autentificare utilizator");
  Console.WriteLine("X. Iesire");
  Console.WriteLine("CT. Citire masa de la tastatura");
  Console.WriteLine("RT. Afisare mese");
  Console.WriteLine("UT. Afisare masa dupa ID");
  Console.WriteLine("DT. Stergere masa dupa ID");
  Console.WriteLine("CR. Citire restaurant de la tastatura");
  Console.WriteLine("RR. Afisare restaurante");
  Console.WriteLine("UR. Afisare restaurant dupa ID");
  Console.WriteLine("DR. Stergere restaurant dupa ID");
  Console.WriteLine("CZ. Citire rezervare de la tastatura");
  Console.WriteLine("RZ. Afisare rezervari");
  Console.WriteLine("UZ. Afisare rezervare dupa ID");
  Console.WriteLine("DZ. Stergere rezervare dupa ID");

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
    case "CT":
      Console.Write("RestaurantId: ");
      int restaurantId = int.Parse(Console.ReadLine());
      Console.Write("Number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write("Capacity: ");
      int capacity = int.Parse(Console.ReadLine());
      Console.Write("IsAvailable (true/false): ");
      bool isAvailable = bool.Parse(Console.ReadLine());
      Table table = new Table(0, restaurantId, number, capacity, isAvailable);
      tablesRepository.Add(table);
      break;
    case "RT":
      foreach (Table currentTable in tablesRepository.GetAll())
      {
        Console.WriteLine(currentTable.Info());
      }
      break;
    case "UT":
      Console.Write("ID: ");
      int tableId = int.Parse(Console.ReadLine());
      Table? tableById = tablesRepository.GetById(tableId);
      if (tableById != null)
      {
        Console.WriteLine(tableById.Info());
      }
      else
      {
        Console.WriteLine("Masa nu exista!");
      }
      break;
    case "DT":
      Console.Write("ID: ");
      int deleteTableId = int.Parse(Console.ReadLine());
      bool isDeleted = tablesRepository.Delete(deleteTableId);
      if (isDeleted)
      {
        Console.WriteLine("Masa a fost stearsa!");
      }
      else
      {
        Console.WriteLine("Masa nu exista!");
      }
      break;
    case "CR":
      Console.Write("Nume: ");
      string? restaurantName = Console.ReadLine();
      Console.Write("Adresa: ");
      string? address = Console.ReadLine();
      Restaurant restaurant = new Restaurant(0, restaurantName, address);
      restaurantsRepository.Add(restaurant);
      break;
    case "RR":
      foreach (Restaurant currentRestaurant in restaurantsRepository.GetAll())
      {
        Console.WriteLine(currentRestaurant.Info());
      }
      break;
    case "UR":
      Console.Write("ID: ");
      int currentRestaurantId = int.Parse(Console.ReadLine());
      Restaurant? restaurantById = restaurantsRepository.GetById(currentRestaurantId);
      if (restaurantById != null)
      {
        Console.WriteLine(restaurantById.Info());
      }
      else
      {
        Console.WriteLine("Restaurantul nu exista!");
      }
      break;
    case "DR":
      Console.Write("ID: ");
      int deleteRestaurantId = int.Parse(Console.ReadLine());
      bool isRestaurantDeleted = restaurantsRepository.Delete(deleteRestaurantId);
      if (isRestaurantDeleted)
      {
        Console.WriteLine("Restaurantul a fost sters!");
      }
      else
      {
        Console.WriteLine("Restaurantul nu exista!");
      }
      break;
    case "CZ":
      Console.Write("UserId: ");
      int userId = int.Parse(Console.ReadLine());
      Console.Write("TableId: ");
      int currentTableId = int.Parse(Console.ReadLine());
      Console.Write("Data si ora (yyyy-MM-dd HH:mm): ");
      DateTime dateTime = DateTime.Parse(Console.ReadLine());
      Console.Write("Numar de persoane: ");
      int numberOfPeople = int.Parse(Console.ReadLine());
      Console.Write("Durata (minute): ");
      int duration = int.Parse(Console.ReadLine());
      Reservation reservation = new Reservation(currentTableId, userId, dateTime, duration, numberOfPeople);
      reservationsRepository.Add(reservation);
      break;
    case "RZ":
      foreach (Reservation currentReservation in reservationsRepository.GetAll())
      {
        Console.WriteLine(currentReservation.Info());
      }
      break;
    case "UZ":
      Console.Write("ID: ");
      int reservationId = int.Parse(Console.ReadLine());
      Reservation? reservationById = reservationsRepository.GetById(reservationId);
      if (reservationById != null)
      {
        Console.WriteLine(reservationById.Info());
      }
      else
      {
        Console.WriteLine("Rezervarea nu exista!");
      }
      break;
    case "DZ":
      Console.Write("ID: ");
      int deleteReservationId = int.Parse(Console.ReadLine());
      bool isReservationDeleted = reservationsRepository.Delete(deleteReservationId);
      if (isReservationDeleted)
      {
        Console.WriteLine("Rezervarea a fost stearsa!");
      }
      else
      {
        Console.WriteLine("Rezervarea nu exista!");
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


