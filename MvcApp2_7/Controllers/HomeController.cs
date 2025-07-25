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
