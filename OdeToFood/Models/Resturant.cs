using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Resturant
    {
        public int Id { get; set; }

        [Display(Name="Resturant Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }


        public CuisineType Cuisine { get; set; }


    }
}
