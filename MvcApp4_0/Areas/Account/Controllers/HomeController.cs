using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Areas.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
