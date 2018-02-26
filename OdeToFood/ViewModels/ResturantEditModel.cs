using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModels
{
    public class ResturantEditModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
