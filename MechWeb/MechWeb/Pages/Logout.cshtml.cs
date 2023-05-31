using DataLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace MechWeb.Pages.Shared
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
            Response.Cookies.Delete("userId");
            Response.Redirect("/Index");
        }
    }
}
