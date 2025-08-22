using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Controllers
{
    [Route("Home/{action?}/{age?}/{name?}")]
    public class HomeController : Controller
    {
        //[HttpGet]
        //public string Index() => $"Home/Index action";

        //[HttpPost]
        //public string About() => $"Home/About action";

        //[HttpGet]
        //public string Contact(int age = 5, string name = "Dex") 
        //    => $"Home/Contact action - Name: {name}, Age: {age}";


        [HttpGet]
        //[Route("Home/Index")]
        public IActionResult Index() => View();


        [HttpGet]
        //[Route("Home/About")]
        public IActionResult About() => View();


        [HttpGet]
        //[Route("Home/Contact/{age:int?}/{name?}")]
        public IActionResult Contact(int age = 5, string name = "Dex")
        {
            return Content($"Home/Contact action - Name: {name}, Age: {age}");
        }

        [HttpGet]
        public IActionResult Hello()
        {
            return PartialView();
        }
    }
}
