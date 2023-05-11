using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class ShowCarsModel : PageModel
    {
        UserDbController dbController = new UserDbController();
        public ShowCars CarList = new ShowCars();

        public IActionResult OnGet()
        {
            int id = Convert.ToInt32(Request.Cookies["UserId"]);
            var list = dbController.GetCars(id);
            CarList.Addcars(list);
            return Page();
        }
    }
}
