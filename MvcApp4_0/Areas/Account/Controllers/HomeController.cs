using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Areas.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        [Route("{area}")]
        [Route("{area}/{controller}")]
        [Route("{area}/{controller}/{action}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
