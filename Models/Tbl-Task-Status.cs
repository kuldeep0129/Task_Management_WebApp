using System.ComponentModel.DataAnnotations;

namespace Task_Management_Web.Models
{
    public class Tbl_Task_Status
    {
        [Key]
        public int Id { get; set; }
        public int Assign_Id { get; set; }
        public int Alloted_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public string Priority { get; set; }
        public bool Is_Active { get; set; }
        public DateTime create_date { get; set; }
        public string create_by { get; set; }
        public DateTime update_date { get; set; }
        public string update_by { get; set; }
    }
}
