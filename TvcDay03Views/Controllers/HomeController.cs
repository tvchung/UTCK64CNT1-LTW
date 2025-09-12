using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TvcDay03Views.Models;

namespace TvcDay03Views.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van A", Age = 20, Gender = "Male",   IsActive = true },
                new Student { Id = 2, Name = "Tran Thi B",   Age = 19, Gender = "Female", IsActive = true },
                new Student { Id = 3, Name = "Le Van C",     Age = 21, Gender = "Male",   IsActive = false },
                new Student { Id = 4, Name = "Pham Thi D",   Age = 22, Gender = "Female", IsActive = true },
                new Student { Id = 5, Name = "Hoang Van E",  Age = 20, Gender = "Male",   IsActive = false }
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["name"] = "Chung Trịnh";
            // object
            Student student = new Student
            {
                Id = 1,
                Name = "Nguyen Van A",
                Age = 20,
                Gender = "Male",
                IsActive = true
            };
            ViewData["student"]= student;

            // list object
            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = 1, Name = "Nguyen Van A", Age = 20, Gender = "Male",   IsActive = true },
            //    new Student { Id = 2, Name = "Tran Thi B",   Age = 19, Gender = "Female", IsActive = true },
            //    new Student { Id = 3, Name = "Le Van C",     Age = 21, Gender = "Male",   IsActive = false },
            //    new Student { Id = 4, Name = "Pham Thi D",   Age = 22, Gender = "Female", IsActive = true },
            //    new Student { Id = 5, Name = "Hoang Van E",  Age = 20, Gender = "Male",   IsActive = false }
            //};
            ViewData["students"] = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewBagDemo()
        {
            ViewBag.name = "Chung Trịnh Văn";

            // Object
            Student student = new Student
            {
                Id = 64102318,
                Name = "Chạch Văn Đoành",
                Age = 20,
                Gender = "Male",
                IsActive = true
            };
            ViewBag.student= student;

            // List Object
            ViewBag.students = students;

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
