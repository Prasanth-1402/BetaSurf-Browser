using BetaSurf.Properties;
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
            catch(FileNotFoundException FnfException)
            {
                Debug.WriteLine("Missing File.." + FnfException);
                // Create a new file and write the HOME URL to that
                WriteHistoryToFile(new List<String>{ Settings.Default.DEFAULT_HOME_URL});
                return await ReadFileFromHistory();
            }catch(Exception e)
            {
                // if some other issue just give empty history
                return new List<string>();
            }
        }

        private async Task<List<string>> ReadFileFromHistory()
        {
            //using var Reader = new StreamReader(Settings.Default.HISTORY_FILE);
            //using var csv = new CsvHelper.CsvReader(Reader, System.Globalization.CultureInfo.InvariantCulture);

            //List<string> history = csv.GetRecords<string>().ToList();
            //Debug.WriteLine(" HISTORY : " + csv.GetRecords<string>().ToList());
            var history = new List<string>();
            var lines = File.ReadAllLines(Settings.Default.HISTORY_FILE);
            foreach (var line in lines) 
            {
                var urls = line.Split(new String[] {","}, StringSplitOptions.RemoveEmptyEntries);
                history.AddRange(urls);
                Debug.WriteLine("history => " + String.Join(","+history));
                Debug.WriteLine("URLs => "+ String.Join(","+urls));
            }
            return history;
        }

        internal async void WriteHistoryToFile(List<String> history)
        {
            var Writer = new StreamWriter(Settings.Default.HISTORY_FILE);
            //history.Reverse();
            var line = string.Join(",", history);
            Debug.WriteLine("Line -> "+ line);
            Writer.WriteLine(line); 
            Writer.Close();
        }
    }
}