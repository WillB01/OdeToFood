using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant GetById(int id);
        Resturant Add(Resturant resturant);
        Resturant Update(Resturant resturant);
    }
}
