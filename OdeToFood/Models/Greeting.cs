using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class Greeting : IGreeter
    {
        public string Message { get; set; } = "Hello";
    }
}
