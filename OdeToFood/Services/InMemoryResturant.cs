using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryResturant : IResturantData
    {
        private readonly List<Resturant> _resturants;

        public InMemoryResturant()
        {
            _resturants = new List<Resturant>()
            {
                new Resturant(){Id = 1, Name = "Pizzahut"},
                new Resturant(){Id = 2, Name = "Burger King"},
                new Resturant(){Id = 3, Name = "Vapiano"},
                new Resturant(){Id = 4, Name = "China"},
            };
        }

        public Resturant Add(Resturant resturant)
        {
            resturant.Id = _resturants.Max(r => r.Id) + 1;
            _resturants.Add(resturant);
            return resturant;

        }

        public IEnumerable<Resturant> GetAll()
        {
            return _resturants.OrderBy(r => r.Name);
        }

        public Resturant GetById(int id)
        {
            
            return _resturants.FirstOrDefault(r => r.Id == id);
        }
    }
}
