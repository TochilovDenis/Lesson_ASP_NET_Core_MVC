using Microsoft.AspNetCore.Mvc;
 
namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        public string Index()
        {
            return "Hello IT Academy-TOP 2";
        }
    }
}
