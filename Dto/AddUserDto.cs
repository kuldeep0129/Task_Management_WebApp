using System.ComponentModel.DataAnnotations;
using Task_Management_Web.Enum;

namespace Task_Management_Web.Dto
{
    public class AddUserDto
    {

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter valid 10 digit mobile number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }



        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Confirm Password Should be match Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public RoleEnum Role { get; set; }   

        [StringLength(250)]
        public string Address { get; set; }

        public bool Status { get; set; } = true; 

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public IFormFile ProfilePicture { get; set; }
    }
}
