using Microsoft.AspNetCore.Mvc;

namespace Pet.Controllers
{
    [Route("Home/{action?}/")]
    public class HomeController : Controller
    {
        List<Pet.Models.Pets> pet = new List<Pet.Models.Pets>
        {
            new Pet.Models.Pets("Tom", 37, "Cat"),
            new Pet.Models.Pets("Bob", 41, "Dog"),
            new Pet.Models.Pets("Sam", 28, "Batman")
        };
        [HttpGet]
        public IActionResult Index() => View(pet);

        [HttpPost]
        public IActionResult Index(string name, int age, string breed)
        {
            return Content($"{name}, {age}, {breed}");
        }

    }
}
