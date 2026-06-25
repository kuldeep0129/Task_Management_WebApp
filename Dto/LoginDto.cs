using System.ComponentModel.DataAnnotations;
using Task_Management_Web.Enum;

namespace Task_Management_Web.Dto
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
