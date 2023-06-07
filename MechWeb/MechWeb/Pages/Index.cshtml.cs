using Classes;
using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MechWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserManagement userManager;
        private ServicePointManagement servicePointManager;
        public List<ServicePoint> RepairShops { get; set; }
        //pagination
        public int ItemsCount { get; set; } = 4;
        public int PageIndex { get; set; }
        //
        public IndexModel(ILogger<IndexModel> logger, UserManagement userMng, ServicePointManagement spMng)
        {
            _logger = logger;
            userManager = userMng;
            servicePointManager = spMng;
        }

        public IActionResult OnGet(int pg = 1)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
                ViewData["greeting"] = $"{user.FirstName} {user.LastName}";
                if (!userManager.HasCars(Convert.ToInt32(User.FindFirstValue("id"))))
                {
                    ViewData["hasCars"] = "We dont see any cars in your profile. Register your car now.";
                } 
            }
            RepairShops = servicePointManager.GetSortedShopsByRating();
            return Page();
        }
    }
}