using Microsoft.EntityFrameworkCore;
using Task_Management_Web.Data;
using Task_Management_Web.Models;
using Task_Management_Web.Repository.Interface;

namespace Task_Management_Web.Repository.Class
{
    public class AddUser_Repository : IAddUser_Repository
    {
        private readonly AppdbContext _context;

        public AddUser_Repository(AppdbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(AddUserModel model)
        {
            if (model == null) return false;

           await _context.tbl_User.AddAsync(model);
           var res = _context.SaveChanges();
            
            if(res == null) return false;
            return true;

        }

        public async Task<AddUserModel> LoginUser(string Email, string Password)
        {
           var res = await _context.tbl_User.FirstOrDefaultAsync(x => x.Email == Email && x.Password == Password && x.Status == true);
            if (res == null) return null;
            return res;
        }
    }
}
