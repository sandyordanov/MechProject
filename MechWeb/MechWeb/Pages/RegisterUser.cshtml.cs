using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class RegisterUserModel : PageModel
    {
        [BindProperty]
        public UserBindModel BindModel { get; set; }

        private UserManagement manager;
        public RegisterUserModel(UserManagement mng)
        {
            manager = mng;
            BindModel = new UserBindModel();
        }
        public IActionResult OnGet()
        {
            if (Request.Cookies["userId"] != null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid && manager.RegisterUser(BindModel) )
            {
                return RedirectToPage("/Login");
            }
            else
            {
                ViewData["error"] = "Registration failed";
                return Page();
            }
        }
    }
}
