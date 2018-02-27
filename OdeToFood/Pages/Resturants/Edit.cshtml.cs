using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages.Resturants
{
    public class EditModel : PageModel
    {
        private IResturantData _resturantData;

        [BindProperty]
        public Resturant Resturant { get; set; }

        public EditModel(IResturantData resturantData)
        {
            _resturantData = resturantData;
        }

        [HttpGet]
        public IActionResult OnGet(int id)
        {
            Resturant = _resturantData.GetById(id);
            if (Resturant == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _resturantData.Update(Resturant);
                return RedirectToAction("Details", "Home", new { id = Resturant.Id });
            }
            return Page();

        }

    }
}