using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{

    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        /*[HttpGet]
        public string Index() => "Hello IT Academy-TOP 2";

        [HttpPost]
        public string Hello() => "Hello IT Academy-TOP 5";

        protected internal string HelloOne() => "Hello IT Academy-TOP 3";

        [ActionName("Welcome")]
        public string HelloTwo() => "Hello IT Academy-TOP 4";*/


        // Response
/*        public async Task Index()
        {
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync("<h2>Hello IT Academy-TOP</h2>");
        }*/


        // Request
        public async Task Index()
        {
            Response.ContentType = "text/html;charset=utf-8";
            System.Text.StringBuilder tableBuilder = new("<h2>Request headers</h2><table>");
            foreach (var header in Request.Headers)
            {
                tableBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
            }
            tableBuilder.Append("</table>");
            await Response.WriteAsync(tableBuilder.ToString());
        }
    }
}
