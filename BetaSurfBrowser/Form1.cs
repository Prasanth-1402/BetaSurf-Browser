using System.Net;
using System.Net.Http;
using System.Diagnostics;

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
            
            HttpResponseMessage response = await client.GetAsync("https://www.google.com/search?q=" + searchText);

            HttpStatusCode responseCode = response.StatusCode;
            
            //storing the response as Raw HTML 
            String rawHTML = await response.Content.ReadAsStringAsync();

            //displaying the Status in separate text box 
            displayCodeBox.Text = response.StatusCode.ToString();

            // displaying the Raw HTML
            displayTextBox.Text = rawHTML;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
