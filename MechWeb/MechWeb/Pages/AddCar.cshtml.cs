using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class AddCarModel : PageModel
    {
        public readonly ICarDbController controller = new CarDbController();
        [BindProperty]
        public CarBindModel Model { get; set; }

        public IActionResult OnGet()
        {
            if (Request.Cookies["userId"] != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Login");
            }
        }
        public IActionResult OnPost()
        {
            Model.OwnerId = Convert.ToInt32(Request.Cookies["UserId"]);
            controller.CreateCar(Model);
            return RedirectToPage("/ShowCars");
        }
    }
}
