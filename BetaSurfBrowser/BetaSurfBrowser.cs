namespace BetaSurf
{
    internal static class BetaSurfBrowser
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}