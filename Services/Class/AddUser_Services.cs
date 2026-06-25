using Task_Management_Web.Dto;
using Task_Management_Web.Models;
using Task_Management_Web.Repository.Interface;
using Task_Management_Web.Services.Interface;

namespace Task_Management_Web.Services.Class
{
    public class AddUser_Services : IAddUser_Services
    {
        private readonly IAddUser_Repository _repository;
        private readonly IWebHostEnvironment _env;


        public AddUser_Services(IAddUser_Repository repository,IWebHostEnvironment env)
        {
            _repository = repository;
            _env = env;
        }
        public async Task<bool> CreateUser(AddUserDto dto)
        {
            if (dto == null) return false;

            var img = "1.png";

            if (dto.ProfilePicture != null)
            {
                var folder = Path.Combine(_env.WebRootPath, "Images");
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(dto.ProfilePicture.FileName);
                var fullpath = Path.Combine(folder, ImageName);

                using(var stream = new FileStream(fullpath,FileMode.Create))
                {
                    dto.ProfilePicture.CopyTo(stream);
                }
                img = ImageName;
            }



            var repo_model = new AddUserModel
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Mobile = dto.Mobile,
                Password = dto.Password,
                Role = dto.Role,
                Address = dto.Address,
                Status = dto.Status,
                CreatedDate = DateTime.Now,
                ProfilePicture = img
            };

            var res = await _repository.CreateUser(repo_model);
           if(!res) return false;
           return true;
        }

        public async Task<ResponseDto> LoginUser(LoginDto dto)
        {
            var res_dto = new ResponseDto();

            var user = await _repository.LoginUser(dto.Email, dto.Password);

            if(user == null)
            {
                res_dto.Message = "Invalid Credentials";
                res_dto.status = false;
                return res_dto;
            }
            else
            {
                res_dto.Message = "Login Successfull";
                res_dto.status = true;
                res_dto.Id = user.Id;
                res_dto.Role = (int)user.Role;
                return res_dto;
            }
        }
    }
}
