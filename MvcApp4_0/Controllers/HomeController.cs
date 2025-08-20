using Microsoft.AspNetCore.Mvc;

namespace MvcApp4_0.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(int id) => $"Index Page. Id: {id}";

        public string Index(int? id)
        {
            if (id is not null) return $"Product Id: {id}";

            return "Product List";
        }

        public string About(string name, int age) => $"About Page. Name: {name}  Age: {age}";
    }
}
