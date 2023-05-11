using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using DataLibrary;

namespace MechWeb.Pages
{
    public class RegisterServicePointModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Address { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public void OnGet()
        {
            ServicePointManagement manger = new ServicePointManagement();
            manger.RegisterServicePoint(Name, Address,Phone,Email, Password);
            // and redirect the user to a confirmation page.
        }
    }
}
