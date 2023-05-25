using Classes;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserManagement userManager;
        public IndexModel(ILogger<IndexModel> logger, IUserDbController _userDbController)
        {
            _logger = logger;
            userManager = new UserManagement(_userDbController);
        }

        public void OnGet()
        {
            if (Request.Cookies["userId"] != null)
            {
                User user = userManager.GetUserById(Convert.ToInt32(Request.Cookies["userId"]));
                ViewData["greeting"] = $"{user.FirstName} {user.LastName}";
            }
        }
    }
}