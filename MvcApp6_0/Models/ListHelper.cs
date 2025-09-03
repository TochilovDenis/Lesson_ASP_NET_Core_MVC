using Microsoft.AspNetCore.Html;        // для HtmlString
using Microsoft.AspNetCore.Mvc.Rendering;   // для IHtmlHelper
using System.Text.Encodings.Web;    // для HtmlEncoder
 
namespace MvcApp6_0
{
    public static class ListHelper
    {
        /*public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            TagBuilder ul = new TagBuilder("ul");

            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                // добавляем текст в li
                li.InnerHtml.Append(item);
                // добавляем li в ul
                ul.InnerHtml.AppendHtml(li);
            }*/

       
        public static HtmlString CreateList(this IHtmlHelper html, string[] items, string topic)
        {
            // Создаем основной div контейнер
            var containerDiv = new TagBuilder("div");

            // Создаем заголовок h2
            var h2 = new TagBuilder("h2");
            h2.InnerHtml.Append(topic);

            // Добавляем заголовок в контейнер
            containerDiv.InnerHtml.AppendHtml(h2);

            foreach (string question in items)
            {
                // Создаем ul для каждого вопроса
                var ul = new TagBuilder("ul");
                ul.Attributes.Add("class", "itemsList");

                // Первый li с вопросом
                var liQuestion = new TagBuilder("li");
                liQuestion.InnerHtml.Append(question);
                ul.InnerHtml.AppendHtml(liQuestion);

                // Второй li с полем ввода "Ответ"
                var liAnswer = new TagBuilder("li");
                var inputAnswer = new TagBuilder("input");
                inputAnswer.Attributes.Add("value", "Ответ");
                inputAnswer.Attributes.Add("type", "text");
                liAnswer.InnerHtml.AppendHtml(inputAnswer);
                ul.InnerHtml.AppendHtml(liAnswer);

                // Третий li с чекбоксом
                var liCheckbox = new TagBuilder("li");
                var inputCheckbox = new TagBuilder("input");
                inputCheckbox.Attributes.Add("type", "checkbox");
                liCheckbox.InnerHtml.AppendHtml(inputCheckbox);
                ul.InnerHtml.AppendHtml(liCheckbox);

                // Добавляем ul в контейнер
                containerDiv.InnerHtml.AppendHtml(ul);
            }

            using var writer = new StringWriter();
            containerDiv.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }


        /*public static HtmlString CreateList(this IHtmlHelper html, string[] items, string topic)
       {
           string result = "<div><h2>" + topic + "</h2></div>";

           foreach (string question in items)
           {
               result = "${result}<ul class=\"itemsList\">" +
                     $"<li>{question}</li>" +
                     $"<li><input value=\"Ответ\"></li>" +
                     $"<li>< input type =\"checkbox\"></li>" +
                     $"</ul>";
           }

           result = $"{result}</div>";
           return new HtmlString(result);
       }*/
    }
}