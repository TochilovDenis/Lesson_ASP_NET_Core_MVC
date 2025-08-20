using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();

        public IActionResult Hello()
        {
            return PartialView();
        }
    }
}

// Передача данных в представление