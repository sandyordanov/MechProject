using Classes;
using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Security.Claims;

namespace MechWeb.Pages
{
    [Authorize(Policy = "CarOwner")]
    public class RequestRepairModel : PageModel
    {
        public bool IsShopSelected { get; set; } = false;
        private readonly CarManagement carManager;
        private readonly UserManagement userManager;
        private readonly RepairRequestManagement requestManager;
        public readonly ServicePointManagement spManager;

        public int CurrentPage { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 3;
        public int TotalPages { get; set; }

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
        public User UserDetails { get; private set; }
        public List<ServicePoint> RepairShops { get; set; }
        public int StarIndex { get; set; }

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
                      
            TotalPages = (int)Math.Ceiling((double)spManager.GetShopsCount() / ItemsPerPage);
            StarIndex = (CurrentPage-1) * ItemsPerPage +1;
            LoadData();
            return Page();
        }
        public IActionResult OnPostPagi(int page)
        {
            CurrentPage = Math.Max(CurrentPage, page);
            HttpContext.Session.SetInt32("currentPage", CurrentPage);
            TotalPages = (int)Math.Ceiling((double)spManager.GetShopsCount() / ItemsPerPage);
            StarIndex = (CurrentPage - 1) * ItemsPerPage + 1;
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
            IsShopSelected = true;
            OnPostPagi((int)HttpContext.Session.GetInt32("currentPage"));
        }

        private void LoadData()
        {
            RepairShops = spManager.GetServicePointsPagination(StarIndex, ItemsPerPage);
            SelectedCar = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
            UserDetails = userManager.GetUserById(Convert.ToInt32(User.FindFirstValue("id")));
        }
    }
}
