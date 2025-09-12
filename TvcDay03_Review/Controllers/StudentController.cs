using Microsoft.AspNetCore.Mvc;

namespace TvcDay03_Review.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hà nội mùa thu tỏa nắng vàng ươm";
            //return View();
        }

        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
