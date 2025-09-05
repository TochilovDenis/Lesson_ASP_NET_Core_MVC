using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace MvcApp6_0
{
    public static class VideoCardHelper
    {
        public static HtmlString CreateVideoCards(this IHtmlHelper html, string[] imageUrls, string[] titles, string topic)
        {
            // Та же реализация, но без this
            if (imageUrls == null || titles == null || imageUrls.Length != titles.Length)
                return new HtmlString(string.Empty);

            string cards = "";
            for (int i = 0; i < imageUrls.Length; i++)
            {
                cards += $@"<div class=""video_card"">
                                <img src=""{HtmlEncoder.Default.Encode(imageUrls[i])}"" alt=""{HtmlEncoder.Default.Encode(titles[i])}"">
                                <h4>{HtmlEncoder.Default.Encode(titles[i])}</h4>
                                <p>Video</p>
                            </div>";
            }

            string result = $@"<div>
                                    <h2>{HtmlEncoder.Default.Encode(topic)}</h2>
                                    <div class=""video-gallery"">{cards}</div>
                               </div>";

            return new HtmlString(result); ;
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