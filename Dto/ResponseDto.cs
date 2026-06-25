using Task_Management_Web.Enum;

namespace Task_Management_Web.Dto
{
    public class ResponseDto
    {
        public bool status { get; set; }

        public string Message { get; set; }

        public int Id { get; set; }

        public int Role { get; set; }
    }
}
