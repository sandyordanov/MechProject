using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLibrary;

namespace MechWeb.Pages
{
    public class AddCarModel : PageModel
    {
        private readonly CarManagement manager;
        public AddCarModel(CarManagement carMng)
        {
            manager = carMng;
            Model = new CarBindModel();
        }
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
            manager.CreateCar(Model);
            return RedirectToPage("/ShowCars");
        }
    }
}
