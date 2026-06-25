using Task_Management_Web.Models;

namespace Task_Management_Web.Repository.Interface
{
    public interface ISupportRepository
    {
        Task<bool> AddTask(Tbl_Task_Status status);
    }
}
