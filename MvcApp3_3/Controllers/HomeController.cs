using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ViewData
            // ViewData представляет словарь из пар ключ-значение:
            ViewData["Message"] = "Hello AcademyTop";

            // ViewBag
            // ViewBag во многом подобен ViewData.Он позволяет определить различные свойства и присвоить им любое значение. 
            ViewBag.Message = "Hello METANIT.COM";

            ViewBag.People = new List<string> { "Tom", "Sam", "Bob" };

            return View();
        }
    }
}

// Передача данных в представление