using System.Net;
using System.Net.Http;
using System.Diagnostics;
using AngleSharp.Html.Parser;

namespace BetaSurf
{
    public partial class BetaSurf : Form
    {
        public BetaSurf()
        {
            InitializeComponent();
        }

        private void backwardClick(object sender, EventArgs e)
        {

        }
        private void forwardClick(object sender, EventArgs e)
        {

        }

        private void reloadButtonClick(object sender, EventArgs e)
        {

        }
        private void searchTextChanged(object sender, EventArgs e)
        {

        }

        //SAMPLE DEBUG STATEMENT
        //Debug.WriteLine("Sender Object -> " + searchText);
        //Debug.WriteLine("E - > " + e);

        // after clicking "Search" icon button
        private async void searchButtonClick(object sender, EventArgs e)
        {

            // fetching the user input from search box
            String searchText = searchBox.Text;

            using HttpClient client = new HttpClient();

            String searchURL = searchText.Contains("http") ? searchText : "https://www.google.com/search?q=" + searchText;

            try
            {
                HttpResponseMessage response = await client.GetAsync(searchText);

                //displaying the Status in separate text box 
                displayCodeBox.Text = response.StatusCode.ToString();

                String rawHTML = await response.Content.ReadAsStringAsync();
                setTitle(rawHTML, response.StatusCode.ToString());
                
                // displaying the Raw HTML
                displayTextBox.Text = rawHTML;
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exception : "+exception);
            }

        }

        private void setTitle(String rawHTML, String responseCode)
        {
            //  using AngleSharp(third party) parser to fetch the title from the raw HTML
            var parser = new HtmlParser();
            var document = parser.ParseDocument(rawHTML);
            String title = document.Title ?? "Title not found!";

            this.Text = $"{responseCode} - {title}";
            //Debug.WriteLine("Title Text: "+ this.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
