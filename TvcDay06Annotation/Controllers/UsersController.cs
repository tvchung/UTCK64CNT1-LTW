using Microsoft.AspNetCore.Mvc;
using TvcDay06Annotation.Models;

namespace TvcDay06Annotation.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserManualValid() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult UserManualValid(User user)
        {
            string pass = user.Password;
            if (pass.Length <7)
            {
                ViewBag.PassErr = "Mat khau co doi dai toi thieu 7 ky tu";
                return View();
            }
            return Content("Hello, ban nhap dung roi");
        }

        [HttpGet]
        public IActionResult UserManualValid1()
        {
            return View();
        }

        public IActionResult UserAnnatation()
        {
            return View();    
        }
        [HttpPost]
        public IActionResult UserAnnatation(User user)
        {
            if(ModelState.IsValid)
            {
                return Content("Haha, thoat roi");
            }

            return View();
        }
    }
}
