using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturnatData;

        public HomeController(IResturantData resturantData)
        {
            _resturnatData = resturantData;
        }
        public IActionResult Index()
        {
            var model = _resturnatData.GetAll();
            return View(model);
        }
    }
}