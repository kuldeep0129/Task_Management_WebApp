using Microsoft.AspNetCore.Mvc;

namespace Task_Management_Web.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
