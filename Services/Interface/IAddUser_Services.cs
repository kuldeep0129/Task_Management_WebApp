using Task_Management_Web.Dto;

namespace Task_Management_Web.Services.Interface
{
    public interface IAddUser_Services
    {
        Task<bool> CreateUser(AddUserDto dto);

        Task<ResponseDto> LoginUser(LoginDto dto);
    }
}
