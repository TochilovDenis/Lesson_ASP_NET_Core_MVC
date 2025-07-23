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
        //public async Task Index()
        //{
        //    Response.ContentType = "text/html;charset=utf-8";
        //    System.Text.StringBuilder tableBuilder = new("<h2>Request headers</h2><table>");
        //    foreach (var header in Request.Headers)
        //    {
        //        tableBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
        //    }
        //    tableBuilder.Append("</table>");
        //    await Response.WriteAsync(tableBuilder.ToString());
        //}

        // Получение данных через строку запроса
        // public string Index(string name) => $"Your name: {name}";  // https://localhost:7240/Home/Index?name=Dex

        //// или
        //public string Index(string name, int age)
        //{
        //    return $"Name: {name}  Age: {age}";                    // https://localhost:7240/Home/Index?name=Dex&age=34
        //}

        //// или
        //public string Index(string name = "Dex", int age = 34)
        //{
        //    return $"Name: {name}  Age: {age}";
        //}


        // Передача сложных объектов\
        //public string Index(Person person)
        //{
        //    return $"Person Name: {person.Name}  Person Age: {person.Age}";  // https://localhost:7240/Home/Index?name=Dex&age=34
        //}


        // Передача массивов  //  https://localhost:7240/Home/Index?people=Dex&people=Bob&people=Sam
        public string Index(string[] people)
        {
            string result = "";
            foreach (var person in people)
                result = $"{result}{person}; ";
            return result;
        }
    }
    public record class Person(string Name, int Age);
}

