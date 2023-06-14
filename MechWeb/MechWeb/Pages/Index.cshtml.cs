using Classes;
using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace MechWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserManagement userManager;
        private ServicePointManagement servicePointManager;
        public List<ServicePoint> RepairShops { get; set; }

        public string Search { get; set; } = string.Empty;
        public bool hasSearchResults = false;
        public IndexModel(ILogger<IndexModel> logger, UserManagement userMng, ServicePointManagement spMng)
        {
            _logger = logger;
            userManager = userMng;
            servicePointManager = spMng;
        }

        public IActionResult OnGet()
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
            RepairShops = servicePointManager.SortShopsByRating(servicePointManager.GetAllRepairShops());
            return Page();
        }
        public IActionResult OnPostSearch(string search)
        {

            OnGet();
            hasSearchResults = true;
            if (search == null)
            {
                Search = string.Empty;
                RepairShops = servicePointManager.SortShopsByRating(servicePointManager.GetAllRepairShops());
                return Page();
            }
            else
            {
                Search = $"'{search}'" ;
                RepairShops = SearchEngine.SearchForRepairShops(search,servicePointManager.GetAllRepairShops());
                return Page();
            }

        }
    }
}