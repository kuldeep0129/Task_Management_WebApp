using Task_Management_Web.Dto;
using Task_Management_Web.Models;

namespace Task_Management_Web.Repository.Interface
{
    public interface IAddUser_Repository
    {

        Task<bool> CreateUser(AddUserModel model);

        Task<AddUserModel> LoginUser(string Email, string Password); 
    }
}
