using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
        
        //[HttpPost]
        //public string Index(string username) => $"User Name: {username}";

        [HttpPost]
        public string Index(string username, string password, int age, string comment)
        {
            return $"User Name: {username}   Password: {password}   Age: {age}  Comment: {comment}";
        }

        public IActionResult About() => View();

        public IActionResult Hello()
        {
            return PartialView();
        }
    }
}

// Передача данных в представление