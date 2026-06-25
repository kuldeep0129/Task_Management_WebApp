using Microsoft.EntityFrameworkCore;
using Task_Management_Web.Data;
using Task_Management_Web.Models;
using Task_Management_Web.Repository.Interface;

namespace Task_Management_Web.Repository.Class
{
    public class SupportRepository : ISupportRepository
    {
        private readonly AppdbContext _context;
        public SupportRepository(AppdbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddTask(Tbl_Task_Status status)
        {
            await _context.tbl_Task_Statuses.AddAsync(status);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
