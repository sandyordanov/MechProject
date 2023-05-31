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
            BindModel = new ServicePointBindModel();
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
            if (ModelState.IsValid && manager.RegisterServicePoint(BindModel))
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
