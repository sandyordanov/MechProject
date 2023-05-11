using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class AddCarModel : PageModel
    {
        public readonly UserDbController controller = new UserDbController();
        [BindProperty]
        public AddCar Model { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Model.OwnerId = Convert.ToInt32(Request.Cookies["UserId"]);
            controller.CreateCar(Model);
            return RedirectToPage("/Index");
        }
    }
}
