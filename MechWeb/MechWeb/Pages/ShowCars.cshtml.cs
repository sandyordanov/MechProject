using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Classes;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;

namespace MechWeb.Pages
{
    [Authorize(Policy = "CarOwner")]
    public class ShowCarsModel : PageModel
    {
        
        public List<Car> CarList = new List<Car>();
        private readonly CarManagement manager;
        public ShowCarsModel(CarManagement carMng)
        {
            manager = carMng;
        }

        public IActionResult OnGet()
        {
            
            if (Request.Cookies["userId"] != null)
            {
                int userId = Convert.ToInt32(Request.Cookies["UserId"]);
                CarList = manager.GetCarsByUserId(userId);
                return Page();
            }
            else
            {
                ViewData["isLogged"] = "Log in first";
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            var carId = RouteData.Values;
            return RedirectToPage("/RequestRepair",carId);
        }
    }
}
