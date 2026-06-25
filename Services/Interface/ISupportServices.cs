using Task_Management_Web.Dto;

namespace Task_Management_Web.Services.Interface
{
    public interface ISupportServices
    {
        Task<bool> AddTask(Task_Statues_Dto dto);
    }
}
