using Microsoft.EntityFrameworkCore;
using Task_Management_Web.Models;

namespace Task_Management_Web.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) :base(options) { }
        DbSet<Task_status> Task_Statuses { get; set; }
        DbSet<Task_sub_status> task_Sub_Statuses { get; set; }
    }
}
