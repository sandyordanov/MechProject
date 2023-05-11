using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class MechanicDetailsModel : PageModel
    {
        public static MechanicDBController _controller = new MechanicDBController();
        [BindProperty]
        public MechanicDetails Model { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Model.Id = Convert.ToInt32(Request.Cookies["UserId"]);
            _controller.InsertDetails(Model);
            return RedirectToPage("/Index");
        }
    }
}
