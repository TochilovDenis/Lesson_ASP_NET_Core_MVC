using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index() => $"Home/Index action";

        [HttpPost]
        public string About() => $"Home/About action";

        [HttpGet]
        public string Contact(int age = 5, string name = "Dex") 
            => $"Home/Contact action - Name: {name}, Age: {age}";
    }
}
