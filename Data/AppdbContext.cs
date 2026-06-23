using Microsoft.EntityFrameworkCore;

namespace Task_Management_Web.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) :base(options) { }
    }
}
