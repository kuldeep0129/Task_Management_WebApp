using Microsoft.EntityFrameworkCore;
using Task_Management_Web.Models;

namespace Task_Management_Web.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) :base(options) { }

        public DbSet<AddUserModel> tbl_User {  get; set; }
    }
}
