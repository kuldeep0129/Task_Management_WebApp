using Task_Management_Web.Dto;
using Task_Management_Web.Models;
using Task_Management_Web.Repository.Interface;
using Task_Management_Web.Services.Interface;

namespace Task_Management_Web.Services.Class
{
    public class SupportServices : ISupportServices
    {
        private readonly ISupportRepository _repository;
        public SupportServices(ISupportRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddTask(Task_Statues_Dto dto)
        {
            var data = new Tbl_Task_Status
            {
                Assign_Id = 2,
                Alloted_id = dto.Alloted_id,
                Title = dto.Title,
                Description = dto.Description,
                Priority = dto.Priority,
                status = "Pending",
                Is_Active = true,
                create_by = "2",
                create_date = DateTime.Now,
                update_by = "2",
                update_date = DateTime.Now,
            };
            await _repository.AddTask(data);
            return true;

        }
    }
}
