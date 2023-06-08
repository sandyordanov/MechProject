using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class ServicePointBindModel
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The password must be between 5 and 50 characters long")]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The phone number should be at least 6 digits long.")]
        [MaxLength(50)]
        [Phone(ErrorMessage ="Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }
    }
}
