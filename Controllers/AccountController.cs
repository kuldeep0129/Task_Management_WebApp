using Microsoft.AspNetCore.Mvc;

namespace Task_Management_Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
