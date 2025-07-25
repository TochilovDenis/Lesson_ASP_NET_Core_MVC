using Microsoft.AspNetCore.Mvc;
using MvcApp2_5;

namespace MvcApp.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string form = @"<form method='post'>
                <p>
                    Person1 Name:<br/> 
                    <input name='people[0].name' /><br/>
                    Person1 Age:<br/>
                    <input name='people[0].age'/><br/>
                    
                    Pet1 Name:<br/> 
                    <input name='pets[0].name' /><br/>
                    Pet1 Breed:<br/>
                    <input name='pets[0].breed' /><br/>
                </p>
                <p>
                    Person2 Name:<br/> 
                    <input name='people[1].name' /><br/>
                    Person2 Age:<br/>
                    <input name='people[1].age' /><br/>

                    Pet2 Name:<br/> 
                    <input name='pets[1].name' /><br/>
                    Pet2 Breed:<br/>
                    <input name='pets[1].breed' /><br/>
                </p>
                <input type='submit' value='Send' />
            </form>";
            return new HtmlResult(form);
            //return Content(form);
        }
        [HttpPost]
        public IActionResult Index(Person[] people, Pet[] pets)
        {
            /*string result = "";
            foreach (Person person in people)
            {
                result = $"{result} \n{person}";
            }

            foreach (Pet pet in pets)
            {
                result = $"{result} \n{pet}";
            }     
            return result;*/

            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true, // не учитываем регистр
                WriteIndented = true                // отступы для красоты
            };
            return Json(people, jsonOptions);

        }

        public IActionResult Contact()
        {
            return Redirect("~/Home/Index");
        }
    }
    public record class Person(string Name, int Age);
    public record class Pet(string Name, string Breed);
}
