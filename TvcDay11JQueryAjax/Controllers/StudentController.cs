using Microsoft.AspNetCore.Mvc;
using TvcDay11JQueryAjax.Models;

namespace TvcDay11JQueryAjax.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbContext db;
        public StudentController(StudentDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
           return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var students = db.Students.ToList();
            return Json(students);
        }
    }
}
