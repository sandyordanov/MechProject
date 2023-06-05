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
        }
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["Message"] = "You are already logged in! Log out if you want to register a new profile.";
                return RedirectToPage("/Index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid &&  manager.IsUsernameFree(BindModel.Username, "owner"))
            {
                manager.RegisterUser(BindModel);
                return RedirectToPage("/Login");
            }
            else
            {
                ViewData["error"] = "Registration failed. Username is already taken";
                return Page();
            }
        }
    }
}
