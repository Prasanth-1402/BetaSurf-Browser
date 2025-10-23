using System.Diagnostics;

namespace BetaSurf
{
    partial class Home
    {
        internal async Task<List<String>> GetHistoryFromFile()
        {
            try
            {
                return await ReadFileFromHistory();
            }
            catch (FileNotFoundException FnfException)
            {
                Debug.WriteLine("Missing File.." + FnfException);
                // Create a new file and write the HOME URL to that
                WriteHistoryToFile(new List<String> { FileHandler.DEFAULT_HOME_URL });
                return await ReadFileFromHistory();
            }
            catch (Exception e)
            {
                // if some other issue just give empty history
                return new List<string>();
            }
        }

        private async Task<List<string>> ReadFileFromHistory()
        {
            var history = new List<string>();
            var lines = File.ReadAllLines(FileHandler.HISTORY);
            foreach (var line in lines)
            {
                var urls = line.Split(new String[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                history.AddRange(urls);

            }
            return history;
        }

        internal async void WriteHistoryToFile(List<String> history)
        {
            var Writer = new StreamWriter(FileHandler.HISTORY);
            //history.Reverse();
            var line = string.Join(",", history);
            Debug.WriteLine("Line -> " + line);
            Writer.WriteLine(line);
            Writer.Close();
        }
    }
}