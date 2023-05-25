using DataLibrary;
using Classes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MechWeb.Pages
{
    public class SpDetailsModel : PageModel
    {
        public static OwnerDbController _controller = new OwnerDbController();
        [BindProperty]
        public ServicePointBindModel Model { get; set; }
        
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }
    }
}
