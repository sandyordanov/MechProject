using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataLibrary;
using Classes;
using Classes.Models;
using Microsoft.AspNetCore.Identity;
using LogicLibrary;

namespace MechWeb.Pages
{
    public class RegisterModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["Message"] = "You are already logged in! Log out if you want to register a new profile.";
                return RedirectToPage("/Index");
            }
            return Page();
        }

       
    }
}
