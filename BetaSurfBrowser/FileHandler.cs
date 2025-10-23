namespace BetaSurf
{
    internal class FileHandler
    {
        private static String BASE_DIR = AppDomain.CurrentDomain.BaseDirectory;

        public static String BOOKMARKS = Path.Combine(BASE_DIR, Properties.Settings.Default.BOOKMARKS_FILE);
        public static String HISTORY = Path.Combine(BASE_DIR, Properties.Settings.Default.HISTORY_FILE);
        public static String DEFAULT_HOME_URL = Properties.Settings.Default.DEFAULT_HOME_URL;
    }
}
