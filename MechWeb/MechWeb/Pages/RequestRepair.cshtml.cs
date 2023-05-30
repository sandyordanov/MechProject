using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class RequestRepairModel : PageModel
    {
        public string CarId { get; set; }
        public string CarIdd { get; set; }
        public RequestRepairModel(string id)
        {
            CarId = id;
        }
        public void OnGet(string carId)
        {
            CarIdd = RouteData.Values.ToString();
        }
    }
}
