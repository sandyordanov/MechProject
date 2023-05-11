using DataLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages.Shared
{
    public class LogoutModel : PageModel
    {
        public readonly UserDbController _dbController = new UserDbController();
        public void OnGet()
        {
            if (HttpContext.Request.Cookies.TryGetValue("AuthToken", out string authToken))
            {
                int userId = int.Parse(HttpContext.Request.Cookies["UserId"]);
                _dbController.DeleteAuthToken(userId);

                HttpContext.Response.Cookies.Delete("AuthToken");
                HttpContext.Response.Cookies.Delete("UserId");
            }
            Response.Redirect("/Login");
        }
    }
}
