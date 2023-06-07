using Classes;
using Classes.Models;
using DataLibrary;
using LogicLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class RequestRepairModel : PageModel
    {

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
        public Car SelectedCar { get; set; } = new Car();
        [BindProperty]
        public RequestBindModel RequestBind { get; set; }
        public IActionResult OnGet()
        {
            if(SelectedCar.Id == 0)
            {
                Car car = carManager.GetCarById(Convert.ToInt32(HttpContext.Session.GetString("carId")));
                SelectedCar = car;
            }
            return Page();
        }
        public void OnPost()
        {

        }
    }
}
