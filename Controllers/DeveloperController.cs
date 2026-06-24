using Microsoft.AspNetCore.Mvc;

namespace Task_Management_Web.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Developer_ui()
        {
            return View();
        }
    }
}
