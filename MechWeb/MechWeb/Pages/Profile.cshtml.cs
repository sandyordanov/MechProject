using Classes;
using Classes.Models;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MechWeb.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public User UserDetails { get; set; }
        private readonly UserManagement userManager;
        public ProfileModel(UserManagement userMan)
        {
            userManager = userMan;
        }
        public void OnGet()
        {
            UserDetails = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
        }
        public void OnPost() 
        {

        }
        public void OnPostUpdate(int id)
        {
            userManager.UpdateUserDetails(Convert.ToInt32(User.FindFirstValue("id")), UserDetails);
            ViewData["update"] = "Profile updated";
        }
        public IActionResult OnPostDelete()
        {
            userManager.DeleteUser(Convert.ToInt32(User.FindFirstValue("id")));
            return RedirectToPage("/Logout");
        }

    }
}
