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

namespace MechWeb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserDbController _dbController = new UserDbController();


        [BindProperty]
        public Login Model { get; set; }

        public IActionResult OnGet()
        {
            if (Request.Cookies["AuthToken"] != null || Request.Cookies["UserId"] != null)
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
            User user = _dbController.GetUserByEmail(Model.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(Model.Password, user.Password))
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return Page();
            }
            if (Request.Cookies["AuthToken"] == null || Request.Cookies["UserId"] == null)
            {
                // delete any existing auth tokens associated with the user, and add a new auth token.
                _dbController.DeleteAuthToken(user.Id);

                var authToken = Guid.NewGuid().ToString();
                _dbController.InsertAuthToken(user.Id, authToken);

                // set the auth token and user ID cookies
                Response.Cookies.Append("AuthToken", authToken, new CookieOptions { HttpOnly = true });
                Response.Cookies.Append("UserId", user.Id.ToString(), new CookieOptions { HttpOnly = true });
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, Model.Email));
            claims.Add(new Claim("id", "1"));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

            return RedirectToPage("/Index");
        }

    }
}
