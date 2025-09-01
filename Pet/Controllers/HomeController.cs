using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    [Route("Home/{action?}/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(string name, int age, string breed)
        {
            return Content($"{name}, {age}, {breed}");
        }

    }
}
