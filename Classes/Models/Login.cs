using System.ComponentModel.DataAnnotations;

namespace Classes.Models
{
    public class Login
    {
        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
