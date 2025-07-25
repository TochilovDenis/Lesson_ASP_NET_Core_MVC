using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{

    public class HomeController : Controller
    {
        public async Task Index()
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
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(form);
        }
        [HttpPost]
        public string Index(Person[] people, Pet[] pets)
        {
            string result = "";
            foreach (Person person in people)
            {
                result = $"{result} \n{person}";
            }

            foreach (Pet pet in pets)
            {
                result = $"{result} \n{pet}";
            }
            return result;
        }
    }
    public record class Person(string Name, int Age);
    public record class Pet(string Name, string Breed);
}

/*
Практическое задание "Отправка сложных объектов":
Добавить кроме Person класс Pet и сделать для него на форме добавление не менее 2 питомцев
*/