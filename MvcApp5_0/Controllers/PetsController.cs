using Microsoft.AspNetCore.Mvc;
using MvcApp5_0.Models;

namespace MvcApp5_0.Controllers
{
    [Route("{controller=Pets}/{action}")]
    public class PetsController : Controller
    {

        List<Pets> pets = new List<Pets>
        {
            new Pets(1, "Tom", 37, "Cat"),
            new Pets(2, "Bob", 41, "Dog"),
            new Pets(3, "Sam", 28, "Betman")
        };

        [HttpGet]
        public ActionResult pet()
        {
            return View(pets);
        }

        [HttpPost]
        public ActionResult pet(int id, string name, int age, string breed)
        {
            pets.Add(new Pets(id, name, age, breed));
            return View(pets);
        }
    }
}
