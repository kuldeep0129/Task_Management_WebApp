using Microsoft.EntityFrameworkCore;
using Task_Management_Web.Models;

namespace Task_Management_Web.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) :base(options) { }
       public DbSet<Task_sub_status> tbl_task_Sub_Statuses { get; set; }
       public DbSet<Tbl_Task_Status> tbl_Task_Statuses { get; set; }

        public DbSet<AddUserModel> tbl_tbl_User {  get; set; }
    }
}
