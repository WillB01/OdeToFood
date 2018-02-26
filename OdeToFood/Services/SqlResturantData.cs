using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class SqlResturantData : IResturantData
    {
        private AppDbContext _appDbContext;

        public SqlResturantData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Resturant Add(Resturant resturant)
        {
            _appDbContext.Add(resturant);
            _appDbContext.SaveChanges();
            return resturant;
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _appDbContext.Resturants.OrderBy(r => r.Name);
        }

        public Resturant GetById(int id)
        {
            return _appDbContext.Resturants.FirstOrDefault(r => r.Id == id);

        }
    }
}
