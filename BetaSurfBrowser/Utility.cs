using AngleSharp.Html.Parser;

namespace BetaSurf
{
    internal class Utility
    {
        internal static String GetTitle(String rawHTML)
        {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(rawHTML);
            String title = document.Title ?? "Title not found!";

            return title;
        }
        internal static String ValidateURL(string url)
        {
            return url.Contains("http") ? url : "https://www.google.com/search?q=" + url;

        }
    }
}
