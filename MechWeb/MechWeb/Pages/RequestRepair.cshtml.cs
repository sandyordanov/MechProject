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
        public bool isShopSelected = false;
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
        public RepairDetails RequestDetails { get; set; }
        public User UserDetails { get; set; }
        public List<ServicePoint> RepairShops { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("carId") == null)
            {
                return RedirectToPage("/Index");
            }
            Car car = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
            if (car.Model == null)
            {
                TempData["Message"] = "But but but... you deleted the car";
                return RedirectToPage("/Index");              
            }
            LoadData();
            return Page();
        }
        public IActionResult OnPostSend()
        {
            int carId = Convert.ToInt32(HttpContext.Session.GetString("carId"));
            int servicePointId = Convert.ToInt32(HttpContext.Session.GetString("spId"));
            int userId = Convert.ToInt32(User.FindFirstValue("id"));
            int requestId = requestManager.InsertNewRequest(carId, userId, servicePointId);
            if (requestId != 0)
            {
                requestManager.InsertRequestDetails(RequestDetails, requestId);
                TempData["request"] = "Request successfully sent!";
                return RedirectToPage("/Index");
            }
            TempData["Message"] = "Request failed. Request about this car exists.";
            return RedirectToPage("/Index");
        }

        public void OnPostSelectShop(string id)
        {
            HttpContext.Session.SetString("spId", id);
            isShopSelected = true;
            LoadData();
        }

        private void LoadData()
        {
            SelectedCar = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
            UserDetails = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
            RepairShops = spManager.GetAllRepairShops();
        }
    }
}
