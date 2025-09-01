using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Controllers
{
    [Route("{controller=Home}/{action=Index}")]
    //[Route("Home/{action?}/{age:int?}/{name?}")]
    public class HomeController : Controller
    {

        public string Index() => "HomeController вне области";

        [HttpGet]
        //[Route("Home/Index")]
        //public IActionResult Index()
        //{
        //    ViewBag.HeaderTitle = "Добро пожаловать!";
        //    return View();
        //}

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


        [HttpPost]
        public IActionResult Index(string[] languages, string username, string password, int age, string comment)
        {
            // Проверяем, какая форма была отправлена
            if (languages != null && languages.Length > 0)
            {
                // Обработка выбора языков
                string result = "Вы выбрали: " + string.Join(", ", languages);
                return Content(result);
            }
            else if (!string.IsNullOrEmpty(username))
            {
                // Обработка пользовательской формы
                return Content($"User Name: {username}   Password: {password}   Age: {age}  Comment: {comment}");
            }
            else
            {
                return Content("Данные не получены");
            }
        }


        [HttpGet]
        //[Route("Home/About")]
        public IActionResult About()
        {
            ViewBag.Title = "О нас";
            ViewBag.HeaderTitle = "О нашей компании";
            return View();
        }


        [HttpGet]
        //[Route("Home/Contact/{age:int?}/{name?}")]
        public IActionResult Contact(int age = 5, string name = "Dex")
        {
            return Content($"Home/Contact action - Name: {name}, Age: {age}");
        }
    }
}
