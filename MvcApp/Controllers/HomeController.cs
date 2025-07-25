using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    /*public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Index() => "Hello IT Academy-TOP 2";

        [HttpPost]
        public string Hello() => "Hello IT Academy-TOP 5";

        protected internal string HelloOne() => "Hello IT Academy-TOP 3";

        [ActionName("Welcome")]
        public string HelloTwo() => "Hello IT Academy-TOP 4";
    }*/


    // Response
    /*public class HomeController : Controller
    {       
        public async Task Index()
        {
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync("<h2>Hello IT Academy-TOP</h2>");
        }

    }*/


    // Request
    /*public class HomeController : Controller
    {        
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
    }*/


    // Прочитать материал https://metanit.com/sharp/aspnetmvc/2.3.php
    // Получение данных через строку запроса
    /*public class HomeController : Controller
    {
        public string Index(string name) => $"Your name: {name}";  // https://localhost:7240/Home/Index?name=Dex
        // или
        public string Index(string name, int age)
        {
            return $"Name: {name}  Age: {age}";                    // https://localhost:7240/Home/Index?name=Dex&age=34
        }
        // или
        public string Index(string name = "Dex", int age = 34)
        {
            return $"Name: {name}  Age: {age}";
        }
    }*/


    // Передача сложных объектов
    /*public class HomeController : Controller
    {
        public string Index(Person person)
        {
            return $"Person Name: {person.Name}  Person Age: {person.Age}";  // https://localhost:7240/Home/Index?name=Dex&age=34
        }
    }*/


    // Передача массивов  //  https://localhost:7240/Home/Index?people=Dex&people=Bob&people=Sam
    /*public class HomeController : Controller
    {
        public string Index(string[] people)
        {
            string result = "";
            foreach (var person in people)
                result = $"{result}{person}; ";
            return result;
        }
    }*/


    // Передача массивов сложных объектов
    /*public class HomeController : Controller
    {
        public string Index(Person[] people)
        {
            string result = "";
            foreach (Person person in people)
            {
                result = $"{result} {person.Name}; ";
            }
            return result;
        }
        */
    /*
          И чтобы передать в этот метод данные, нам надо использовать запрос типа
           https://localhost:7240/Home/Index?people[0].name=Tom&people[0].age=37&people[1].name=Bob&people[1].age=41
          В этом случае в массиве people будут два объекта Person.

          Также можно опустить название параметра и оставить только индексы:
           https://localhost:7240/Home/Index?[0].name=Tom&[0].age=37&[1].name=Bob&[1].age=41
    }*/


    // Передача словарей Dictionary
    /*public class HomeController : Controller
    {
        public string Index(Dictionary<string, string> items)
        {
            string result = "";
            foreach (var item in items)
            {
                result = $"{result} {item.Key} - {item.Value}; ";
            }
            return result;
        }

        // https://localhost:7240/Home/Index?items[germany]=berlin&items[france]=paris&items[spain]=madrid 
    }*/


    // Объект Request.Query
    /* public class HomeController : Controller
     {
          /* public string Index()
          {
              string name = Request.Query["name"];
              string age = Request.Query["age"];
              return $"Name: {name}  Age: {age}";
          }
          // https://localhost:7240/Home/Index?name=Dex&age=34
     }*/


    /*https://metanit.com/sharp/aspnetmvc/2.4.php*/
    // Передача данных в контроллер через формы
    /*public class HomeController : Controller
    {
        [HttpGet]
        public async Task Index()
        {
            string content = @"<form method='post'>
                <label>Name:</label><br />
                <input name='name' /><br />
                <label>Age:</label><br />
                <input type='number' name='age' /><br />
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string Index(string name, int age) => $"{name}: {age}";
    }*/


    // Получение сложных объектов
    /*public class HomeController : Controller
    {
        public async Task Index()
        {
            string content = @"<form method='post'>
                <label>Name:</label><br />
                <input name='name' /><br />
                <label>Age:</label><br />
                <input type='number' name='age' /><br />
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string Index(Person person) => $"{person.Name}: {person.Age}";
    }
    
    public record class Person(string Name, int Age);
    */


    // Получение массивов
    public class HomeController : Controller
    {
        public async Task Index()
        {
            string form = @"<form method='post'>
                <p><input name='names' /></p>
                <p><input name='names' /></p>
                <p><input name='names' /></p>
                <input type='submit' value='Send' />
            </form>";
            Response.ContentType = "text/html; charset=utf-8";
            await Response.WriteAsync(form);
        }
        [HttpPost]
        public string Index(string[] names)
        {
            string result = "";
            foreach (string name in names)
            {
                result = $"{result} {name}";
            }
            return result;
        }
    }
}

