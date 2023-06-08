using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MechWeb.Pages
{
    [Authorize(Policy = "CarOwner")]
    public class AddCarModel : PageModel
    {
        private readonly CarManagement manager;
        public AddCarModel(CarManagement carMng)
        {
            manager = carMng;
        }
        [BindProperty]
        public CarBindModel Model { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Model.OwnerId = Convert.ToInt32(User.FindFirstValue("id"));
            manager.CreateCar(Model);
            return RedirectToPage("/ShowCars");
        }
    }
}
