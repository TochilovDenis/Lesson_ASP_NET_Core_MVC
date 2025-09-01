using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MvcApp5_0.Models;

namespace MvcApp5_0.Controllers
{
    [Route("Home/{action=index}")]
    public class HomeController : Controller
    {

        List<Person> people = new List<Person>
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

        /*[HttpPost]
        public IActionResult Index(string[] languages)
        {
            string result = "Вы выбрали:";
            foreach (string lang in languages)
            {
                result = $"{result} {lang};";
            }
            return Content(result);
        }*/


        //[HttpPost]
        //public IActionResult Index(string[] languages, string name, string password, int age, string comment)
        //{
        //    // Проверяем, какая форма была отправлена
        //    if (languages != null && languages.Length > 0)
        //    {
        //        // Обработка выбора языков
        //        string result = "Вы выбрали: " + string.Join(", ", languages);
        //        return Content(result);
        //    }
        //    else if (!string.IsNullOrEmpty(name))
        //    {
        //        // Обработка пользовательской формы
        //        return Content($"User Name: {name}   Password: {password}   Age: {age}  Comment: {comment}");
        //    }
        //    else
        //    {
        //        return Content("Данные не получены");
        //    }
        //}

        [HttpPost]
        public ActionResult Index(int id, string name, int age)
        {
            people.Add(new Person(id, name, age));
            return View(people);
        }



        [HttpGet]
        //[Route("Home/About")]
        public IActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.HeaderTitle = "bla-bla";
            return View("About");
        }


        [HttpGet]
        //[Route("Home/Contact/{age:int?}/{name?}")]
        public IActionResult Contact(int age = 5, string name = "Dex")
        {
            return Content($"Home/Contact action - Name: {name}, Age: {age}");
        }
    }
}
