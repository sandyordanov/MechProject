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
        private readonly UserDbController _dbcontroller = new UserDbController();
        private readonly MechanicDBController controller = new MechanicDBController();

        [BindProperty]
        public Register Model { get; set; }

        public IActionResult OnGet()
        {
            if (Request.Cookies["AuthToken"] != null || Request.Cookies["UserId"] != null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (Model.Role == UserType.Mechanic)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                bool success = await _dbcontroller.RegisterUserAsync(Model);
                int id = controller.GetId(Model.Email);
                if (success)
                {
                    Response.Cookies.Append("UserId", id.ToString(), new CookieOptions { HttpOnly = true });
                    return RedirectToPage("/MechanicDetails");
                }

                ModelState.AddModelError("", "Error creating user account. Please try again.");
                return Page();
            }
            else if (Model.Role == UserType.CarOwner)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                bool success = await _dbcontroller.RegisterUserAsync(Model);
                int id = controller.GetId(Model.Email);
                if (success)
                {
                    Response.Cookies.Append("UserId", id.ToString(), new CookieOptions { HttpOnly = true });
                    return RedirectToPage("/Index");
                }

                ModelState.AddModelError("", "Error creating user account. Please try again.");
                return Page();
            }
            else if (Model.Role == UserType.ServicePoint)
            {

                if (!ModelState.IsValid)
                {
                    return Page();
                }
                bool success = await _dbcontroller.RegisterUserAsync(Model);
                int id = controller.GetId(Model.Email);
                if (success)
                {

                    Response.Cookies.Append("UserId", id.ToString(), new CookieOptions { HttpOnly = true });
                    return RedirectToPage("/SpDetails");
                }

                ModelState.AddModelError("", "Error creating user account. Please try again.");
                return Page();
            }
            return RedirectToPage("/Index"); ;
        }
    }
}
