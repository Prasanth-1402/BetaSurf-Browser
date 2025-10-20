using AngleSharp.Html.Parser;
using BetaSurf.Properties;
using System.Diagnostics;

namespace BetaSurf
{
    internal class Utility
    {
        internal static String GetTitle(String rawHTML)
        {
            try
            {
                var parser = new HtmlParser();
                var document = parser.ParseDocument(rawHTML);
                String title = document.Title ?? "Title not found!";

                return title;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return "Beta Surf"; // Doesn't want to return empty title so keeping it as Application's Name
        }
        internal static String ValidateURL(string url)
        {
            return url.Contains("http") ? url : "https://www.google.com/search?q=" + url;

        }
        internal static List<BookmarkDTO>? GetAllBookmarks()
        {
            try
            {
                using var Reader = new StreamReader(Settings.Default.BOOKMARKS_FILE);
                using var csv = new CsvHelper.CsvReader(Reader, System.Globalization.CultureInfo.InvariantCulture);
                return csv.GetRecords<BookmarkDTO>().ToList();
            }
            catch(FileNotFoundException fnException)
            {
                Debug.WriteLine("File Not Found to fetch the bookmarks!  -> "+ fnException);
                return null;
            }
            catch (Exception ex) {
                Debug.WriteLine("Exception in getting bookmarks from file -> "+ ex);
                return null;
            }
        }

        internal static void WriteToBookmarks(List<BookmarkDTO> AllBookmarks)
        {
            var Writer = new StreamWriter(Settings.Default.BOOKMARKS_FILE);
            var BookmarkFile = new CsvHelper.CsvWriter(Writer, System.Globalization.CultureInfo.InvariantCulture);
            BookmarkFile.WriteRecords(AllBookmarks);
            Writer.Close();

        }
    }
}
