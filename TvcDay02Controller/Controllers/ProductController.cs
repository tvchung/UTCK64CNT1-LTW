using Microsoft.AspNetCore.Mvc;

namespace TvcDay02Controller.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View("views/product/chi-tiet.cshtml");
        }
    }
}
