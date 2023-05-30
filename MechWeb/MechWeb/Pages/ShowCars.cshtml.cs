using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Classes;

namespace MechWeb.Pages
{
    public class ShowCarsModel : PageModel
    {
        ICarDbController dbController = new CarDbController();
        public List<Car> CarList = new List<Car>();

        public IActionResult OnGet()
        {
            if (Request.Cookies["userId"] != null)
            {
                int id = Convert.ToInt32(Request.Cookies["UserId"]);
                CarList = dbController.GetCars(id);
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
