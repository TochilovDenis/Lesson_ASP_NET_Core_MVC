using Microsoft.AspNetCore.Mvc;
using MvcApp6_0;
using MvcApp6_0.Models;

namespace MvcApp5_0.Controllers
{
    [Route("{controller=Home}/{action=index}")]
    public class HomeController : Controller
    {

        IEnumerable<Person> people = new List<Person>
        {
            new Person(1, "Tom", 37),
            new Person(2, "Bob", 41),
            new Person(3, "Sam", 28)
        };

        [HttpGet]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            ViewBag.HeaderTitle = "Добро пожаловать!";
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string[] languages)
        //{
        //    string result = "Вы выбрали:";
        //    foreach (string lang in languages)
        //    {
        //        result = $"{result} {lang};";
        //    }
        //    return Content(result);
        //}

        [HttpPost]
        public IActionResult Index(string name, string password, int age, string comment)
        {
            // Обработка пользовательской формы
            return Content($"User Name: {name}   Password: {password}   Age: {age}  Comment: {comment}");

        }

        [HttpGet]
        //[Route("Home/About")]
        public IActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.HeaderTitle = "Person";
            return View("About", people);
        }


        [HttpGet]
        //[Route("Home/Contact/{age:int?}/{name?}")]
        public IActionResult Contact(int age = 5, string name = "Dex")
        {
            return Content($"Home/Contact action - Name: {name}, Age: {age}");
        }


        [HttpGet]
        public IActionResult ListCountries()
        {
            return View();
        }


        [HttpGet]
        public IActionResult VideoGallery()
        {
            return View();
        }
    }
}
