using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Classes.Models;
using LogicLibrary;
using DataLibrary;
using Classes;
using Microsoft.AspNetCore.Authorization;
using Azure;
using System.Net;

namespace MechWeb.Pages
{
    //[Authorize]
    public class LoginModel : PageModel
    {
        private UserManagement manager;

        [BindProperty]
        public Login LoginCredentials { get; set; }

        public LoginModel(UserManagement userMan)
        {
            manager = userMan;
            LoginCredentials = new Login();
        }
        public IActionResult OnGet()
        {
            if (Request.Cookies["UserId"] != null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int id = manager.ValidateUser(LoginCredentials.Username, LoginCredentials.Password, "owner");
            if (id != 0)
            {
                Response.Cookies.Append("userId",id.ToString());
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }

        }

    }
}
