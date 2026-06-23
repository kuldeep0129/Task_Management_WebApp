using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management_Web.Models
{
    public class Task_sub_status
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public int task_status_id { get; set; }
        public Task_status TaskStatus { get; set; }  
        public string status { get; set; }
        public bool Is_active { get; set; }
        public DateTime create_date { get; set; }
        public string create_by { get; set; }
        public DateTime update_date { get; set; }
        public string update_by { get; set; }

    }
}
