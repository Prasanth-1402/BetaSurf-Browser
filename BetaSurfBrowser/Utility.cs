using AngleSharp.Html.Parser;
using BetaSurf.Properties;
using System.ComponentModel;
using System.Diagnostics;

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
        internal static List<BookmarkDTO> GetAllBookmarks()
        {
            try
            {
                using var Reader = new StreamReader(Settings.Default.BOOKMARKS_FILE);
                using var csv = new CsvHelper.CsvReader(Reader, System.Globalization.CultureInfo.InvariantCulture);
                return csv.GetRecords<BookmarkDTO>().ToList();
            }
            catch (Exception ex) {
                Debug.WriteLine("Exception in getting bookmarks -> "+ ex);
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
