using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using DataLibrary;
using Classes.Models;

namespace MechWeb.Pages
{
    public class RegisterServicePointModel : PageModel
    {
        [BindProperty]
        public ServicePointBindModel BindModel { get; set; }

        private ServicePointManagement manager;

        public RegisterServicePointModel(ServicePointManagement mng)
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
            if (ModelState.IsValid && manager.IsUsernameFree(BindModel.Username, "admin"))
            {
                manager.RegisterServicePoint(BindModel);
                return RedirectToPage("/Login");
            }
            else
            {
                ViewData["error"] = "Registration failed. Username is already taken.";
                return Page();
            }
        }

    }
}
