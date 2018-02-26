using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

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
            var model = new HomeIndexViewModel
            {
                Resturants = _resturnatData.GetAll(),
                CurrentMessage = ""
            };
            return View(model);
        }
    }
}