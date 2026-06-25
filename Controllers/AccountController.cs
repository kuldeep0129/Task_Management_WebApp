using Microsoft.AspNetCore.Mvc;
using Task_Management_Web.Dto;
using Task_Management_Web.Services.Interface;
using Task_Management_Web.Enum;

namespace Task_Management_Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAddUser_Services _Services;

        public AccountController(IAddUser_Services services)
        {
            _Services = services;
        }
        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveUser(AddUserDto dto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Please Fill All field";
                return View("AddUser", dto);
            }

            var res = await _Services.CreateUser(dto);

            if(!res)
            {
                ViewBag.Message = "Something Went Wrong";
                return View("AddUser", dto);
            }
            else
            {
                ViewBag.Message = "Saved Successfully";
                ModelState.Clear();
                return View("AddUser");
            }
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginDto dto)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Message = "Please Fill All Field";
                return View("Login", dto);
            }

            var user = await _Services.LoginUser(dto);
            if (!user.status)
            {
                ViewBag.Message = user.Message;
                return View("Login", dto);
            }
            else
            {
                HttpContext.Session.SetInt32("Id", user.Id);

                if(user.Role == (int)RoleEnum.Admin)
                {
                    return RedirectToAction("AddUser");
                }
                else if(user.Role == (int)RoleEnum.Support)
                {
                    return RedirectToAction("Index", "Support");
                }
                else
                {
                    return RedirectToAction("Index", "Developer");
                }
                
            }
        }
    }
}
