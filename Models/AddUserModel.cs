using System.ComponentModel.DataAnnotations;
using Task_Management_Web.Enum;

namespace Task_Management_Web.Models
{
    public class AddUserModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Password { get; set; }

        public RoleEnum Role { get; set; }

        public string Address { get; set; }

        public bool Status { get; set; } = true;

        public DateTime CreatedDate { get; set; }

        public string ProfilePicture { get; set; }
    }
}
