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

        public IActionResult Details(int id)
        {
            var model = _resturnatData.GetById(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(ResturantEditModel model)
        {
            var NewResturant = new Resturant()
            {
                Name = model.Name,
                Cuisine = model.Cuisine
            };

            NewResturant =  _resturnatData.Add(NewResturant);
            return RedirectToAction(nameof(Details),
                new { id = NewResturant.Id });
        }
    }
}