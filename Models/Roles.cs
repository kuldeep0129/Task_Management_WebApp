using System.ComponentModel.DataAnnotations;

namespace Task_Management_Web.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
