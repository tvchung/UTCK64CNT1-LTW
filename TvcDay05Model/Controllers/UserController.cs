using Microsoft.AspNetCore.Mvc;
using TvcDay05Model.Models;

namespace TvcDay05Model.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User();
            user.Id = 1;
            user.Name = "Trịnh Văn Chung";
            user.Address = "Ha Noi";
            user.Email = "chungtrinhj@gmail.com";
            ViewBag.User = user;
            return View();
        }
        public IActionResult ListUser()
        {
            var listUser = new List<User>()
            {
                new User { Id = 1, Name = "Nguyen Van A", Address = "Ha Noi", Email = "a@example.com" },
                new User { Id = 2, Name = "Tran Thi B", Address = "Ho Chi Minh", Email = "b@example.com" },
                new User { Id = 3, Name = "Le Van C", Address = "Da Nang", Email = "c@example.com" },
                new User { Id = 4, Name = "Pham Thi D", Address = "Hai Phong", Email = "d@example.com" },
                new User { Id = 5, Name = "Hoang Van E", Address = "Can Tho", Email = "e@example.com" }
            };
            ViewBag.ListUser = listUser;
            return View();
        }

    }
}
