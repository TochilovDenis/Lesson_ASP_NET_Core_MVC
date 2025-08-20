using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => "Index Page";
        public string About() => "About Page";
    }
}
