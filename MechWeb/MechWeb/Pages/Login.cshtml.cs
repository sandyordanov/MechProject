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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int id = manager.ValidateUser(LoginCredentials.Username, LoginCredentials.Password, "owner");
            if (id != 0)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, LoginCredentials.Username));
                claims.Add(new Claim("id", id.ToString()));
                claims.Add(new Claim("UserType", "CarOwner"));
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
               await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                return RedirectToPage("/Index");
            }
            id = manager.ValidateUser(LoginCredentials.Username, LoginCredentials.Password, "admin");
            if (id != 0)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, LoginCredentials.Username));
                claims.Add(new Claim("id", id.ToString()));
                claims.Add(new Claim("UserType", "RepairShop"));
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                return RedirectToPage("/Index");
            }
            return Page();

        }

    }
}
