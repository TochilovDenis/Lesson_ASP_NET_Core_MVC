using Microsoft.AspNetCore.Mvc;
using MvcApp2_5;

namespace MvcApp.Controllers
{

    public class HomeController : Controller
    {
        /// <summary>
        /// Главная страница с формой для ввода данных.
        /// </summary>
        /// <returns>HTML-форма для отправки данных</returns>
        public IActionResult Index()
        {
            // Форма с полями для ввода данных людей (people) и животных (pets)
            // Используется индексация (people[0], pets[0] и т.д.) для корректной привязки модели
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
            return new HtmlResult(form);// Возвращаем HTML-форму
            // Альтернатива: return Content(form);

        }


        /// <summary>
        /// Пример переадресации на маршрут с использованием именованного маршрута "default"
        /// </summary>
        /// <returns>
        /// HTTP-редирект (302) на действие About контроллера Home 
        /// с параметрами name="Tom" и age=22
        /// </returns>
        public IActionResult RedirectExample()
        {
            // Переадресация на маршрут с именем "default"
            // Маршрут должен быть определен в Startup.cs/Program.cs
            return RedirectToRoute("default", new { controller = "Home", action = "About", name = "Tom", age = 22 });

            /*  При переходе на /Home/RedirectExample произойдет перенаправление на:
                https://localhost:7264/Home/About?name=Tom&age=22

                Примечания:
                1. Порт (7264) может отличаться в вашем окружении
                2. Это временный редирект (HTTP 302)
                3. Для работы требуется наличие маршрута с именем "default" */
        }


        [HttpPost]
        /// <summary>
        /// Обработка POST-запроса с данными из формы.
        /// </summary>
        /// <param name="people">Массив объектов Person</param>
        /// <param name="pets">Массив объектов Pet</param>
        /// <returns>Строка с данными всех людей и животных</returns>
        public IActionResult Index(Person[] people, Pet[] pets)
        {
            string result = "";

            // Собираем данные всех людей
            foreach (Person person in people)
            {
                result = $"{result} \n{person}";
            }
            // Собираем данные всех животных
            foreach (Pet pet in pets)
            {
                result = $"{result} \n{pet}";
            }
            return Content(result); // Возвращаем строку с результатом

            /* Альтернативный вариант: возврат данных в формате JSON
            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true, // Игнорировать регистр свойств
                WriteIndented = true               // Форматированный вывод JSON
            };
            return Json(people, jsonOptions);
            */

        }


        /// <summary>
        /// Возвращает данные человека в формате JSON.
        /// </summary>
        /// <param name="person">Объект Person (параметры передаются через строку запроса)</param>
        /// <returns>JSON-представление объекта Person</returns>
        public IActionResult About(Person person)
        {
            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true, // не учитываем регистр
                WriteIndented = true                // отступы для красоты(Форматированный вывод JSON)
            };
            return Json(person, jsonOptions);

        }

        /// <summary>
        /// Перенаправляет на страницу About с параметрами.
        /// </summary>
        /// <returns>Редирект на /Home/About?name=Tom&age=37</returns>
        public IActionResult Contact()
        {
            // Альтернатива: return Redirect("~/Home/About?name=Tom&age=37");

            // Временное перенаправление (302)
            return RedirectToAction("About", "Home", new { name = "Tom", age = 37 });
            /*
             При переходе на /Home/Contact произойдет перенаправление на:
             https://localhost:7264/Home/About?name=Tom&age=37
             */
        }
    }


    /// <summary>
    /// Модель данных для человека (имя и возраст).
    /// </summary>
    public record class Person(string Name, int Age);

    /// <summary>
    /// Модель данных для животного (имя и порода).
    /// </summary>
    public record class Pet(string Name, string Breed);
}
