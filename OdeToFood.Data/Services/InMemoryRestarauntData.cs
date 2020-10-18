using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    // implimenting the interface;
    public class InMemoryRestarauntData : IRestarauntData
    {
        List<Restaurant> restaurants;

        public InMemoryRestarauntData()
        {
            restaurants = new List<Restaurant>()
            {  
                new Restaurant{Id=1,Name="Deamon's pizza",Cuisine =CuisineType.Italian},
                new Restaurant{Id=2,Name="devil's pizza",Cuisine =CuisineType.French},
                new Restaurant{Id=3,Name="3vil's pizza",Cuisine =CuisineType.Indian},
           
        };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
