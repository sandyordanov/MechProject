using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Classes;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
                int userId = Convert.ToInt32(User.FindFirstValue("id"));
                CarList = manager.GetCarsByUserId(userId);
                return Page();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/RequestRepair");
        }
    }
}
