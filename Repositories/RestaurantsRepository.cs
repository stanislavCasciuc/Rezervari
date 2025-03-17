using rezervari.Models;
using System.Collections.Generic;
using System.Linq;

namespace rezervari.Repositories
{
  class RestaurantsRepository
  {
    private List<Restaurant> restaurants = new List<Restaurant>();

    public void Add(Restaurant restaurant)
    {
      restaurant.Id = restaurants.Count > 0 ? restaurants.Max(r => r.Id) + 1 : 1;
      restaurants.Add(restaurant);
    }

    public List<Restaurant> GetAll()
    {
      return restaurants;
    }

    public Restaurant? GetById(int id)
    {
      return restaurants.FirstOrDefault(r => r.Id == id);
    }

    public bool Delete(int id)
    {
      Restaurant? restaurant = GetById(id);
      if (restaurant != null)
      {
        restaurants.Remove(restaurant);
        return true;
      }
      return false;
    }
  }
}
