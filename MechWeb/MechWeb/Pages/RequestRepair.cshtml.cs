using Classes;
using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Security.Claims;

namespace MechWeb.Pages
{
    [Authorize(Policy = "CarOwner")]
    public class RequestRepairModel : PageModel
    {
        public bool isSelected = false;
        private readonly CarManagement carManager;
        private readonly UserManagement userManager;
        private readonly RepairRequestManagement requestManager;
        private readonly ServicePointManagement spManager;

        public RequestRepairModel(CarManagement _carManager, UserManagement _userManager, RepairRequestManagement _repairRequestManagement, ServicePointManagement _spMan)
        {
            carManager = _carManager;
            userManager = _userManager;
            requestManager = _repairRequestManagement;
            spManager = _spMan;
        }
        [BindProperty]
        public Car SelectedCar { get; set; }
        [BindProperty]
        public RequestBindModel RequestBind { get; set; }
        public User UserDetails { get; set; }
        public List<ServicePoint> RepairShops { get; set; }
        public IActionResult OnGet()
        {
            SelectedCar = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
            UserDetails = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
            RepairShops = spManager.GetAllRepairShops();
            return Page();
        }
        public void OnPost()
        {

        }

        public void OnPostSelectShop(string id)
        {
            HttpContext.Session.SetString("spId", id);
            isSelected = true;
            SelectedCar = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
            UserDetails = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
            RepairShops = spManager.GetAllRepairShops();
        }
    }
}
