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
            return Page();
        }

       
    }
}
