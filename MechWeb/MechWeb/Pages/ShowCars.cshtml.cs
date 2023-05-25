using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class ShowCarsModel : PageModel
    {
        ICarDbController dbController = new CarDbController();
        public CarBindModel CarList = new CarBindModel();

        public IActionResult OnGet()
        {
            int id = Convert.ToInt32(Request.Cookies["UserId"]);
            var list = dbController.GetCars(id);
            CarList.AddCars(list);
            return Page();
        }
    }
}
