using Microsoft.AspNetCore.Html;            // для HtmlString
using Microsoft.AspNetCore.Mvc.Rendering;   // для IHtmlHelper

namespace MvcApp6_0.Models
{
    //[Route("/Home/ListCountries")]
    public static class ListHelper
    {        
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            string result = "<ul>";
            foreach (string item in items)
            {
                result = $"{result}<li>{item}</li>";
            }
            result = $"{result}</ul>";
            return new HtmlString(result);
        }
    }
}
