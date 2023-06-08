using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Classes;
using LogicLibrary;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace MechWeb.Pages
{
    [Authorize(Policy = "CarOwner")]
    public class ShowCarsModel : PageModel
    {
        public List<Car> CarList = new List<Car>();
        private readonly CarManagement manager;
        private readonly RepairRequestManagement repReqManager;
        public ShowCarsModel(CarManagement carMng, RepairRequestManagement reqManager)
        {
            manager = carMng;
            repReqManager = reqManager;
        }

        public IActionResult OnGet()
        {          
                int userId = Convert.ToInt32(User.FindFirstValue("id"));
                CarList = manager.GetCarsByUserId(userId);
                return Page();
        }
        public IActionResult OnPost(string carId)
        {
            if (!repReqManager.IsRequestSent(Convert.ToInt32(carId)))
            {
                HttpContext.Session.SetString("carId", carId);
                return RedirectToPage("/RequestRepair");
            }
            TempData["recFailed"] = "Car is already registered for a repair!";
            return OnGet();
            
        }
        public IActionResult OnPostDelete(string carId)
        {
            manager.DeleteCar(Convert.ToInt32(carId));
            return OnGet();
        }
    }
}
