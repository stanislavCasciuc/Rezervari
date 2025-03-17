using rezervari.Models;
using System.Collections.Generic;
using System.Linq;

namespace rezervari.Repositories
{
  class ReservationsRepository
  {
    private List<Reservation> reservations = new List<Reservation>();

    public void Add(Reservation reservation)
    {
      reservation.Id = reservations.Count > 0 ? reservations.Max(r => r.Id) + 1 : 1;
      reservations.Add(reservation);
    }

    public List<Reservation> GetAll()
    {
      return reservations;
    }

    public Reservation? GetById(int id)
    {
      return reservations.FirstOrDefault(r => r.Id == id);
    }

    public bool Delete(int id)
    {
      Reservation? reservation = GetById(id);
      if (reservation != null)
      {
        reservations.Remove(reservation);
        return true;
      }
      return false;
    }
  }
}
