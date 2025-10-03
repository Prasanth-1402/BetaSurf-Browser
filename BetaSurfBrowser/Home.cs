using System.Net;
using System.Net.Http;
using System.Diagnostics;
using AngleSharp.Html.Parser;
using System.Collections;

namespace BetaSurf
{
    public partial class BetaSurf : Form
    {
        private String reloadURL;
        private String homeURL = "http://hw.ac.uk";
        private Dictionary<String, String> bookmarks = new Dictionary<String, string>();
        public BetaSurf()
        {
            InitializeComponent();
            Debug.WriteLine("Constructor");
            LoadWebContent(homeURL);
        }

        private void BackwardClick(object sender, EventArgs e)
        {

        }
        private void ForwardClick(object sender, EventArgs e)
        {

        }

        private void ReloadButtonClick(object sender, EventArgs e)
        {
            if (reloadURL == null) return;
            LoadWebPage();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            LoadWebPage();
        }
        private void LoadWebPage()
        {
            String searchText = searchBox.Text;
            if (searchText == null) return;
            String searchURL = ValidateURL(searchText);
            LoadWebContent(searchURL);

        }

        private async void LoadWebContent(String searchURL)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(searchURL);

                String rawHTML = await response.Content.ReadAsStringAsync();

                SetTitle(rawHTML, response.StatusCode.ToString());
                displayCodeBox.Text = response.StatusCode.ToString();
                // displaying the Raw HTML
                displayTextBox.Text = rawHTML;

                reloadURL = searchURL;
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exception : " + exception);
            }

        }
        private void SetTitle(String rawHTML, String responseCode)
        {
            //  using AngleSharp(third party) parser to fetch the title from the raw HTML
            String title = GetTitle(rawHTML);

            this.Text = $"{responseCode} - {title}";
        }

        private String GetTitle(String rawHTML)
        {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(rawHTML);
            String title = document.Title ?? "Title not found!";

            return title;
        }
        private void OnBrowserLoad(object sender, EventArgs e)
        {
        }

        private void HomeButtonClick(object sender, EventArgs e)
        {
            LoadWebContent(homeURL);
        }
        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsDropDown.Show(settingsButton, 0, settingsButton.Height);
        }



        //SETTINGS ------ 
        private void OpenModifyURL(object sender, EventArgs e)
        {
            currentURLTextBox.Text = homeURL;
            modifyURLPanel.Visible = true;
        }
        private void ModifyURLOKButtonClick(object sender, EventArgs e)
        {
            if (modifyURLTextBox.Text.StartsWith("http://") && modifyURLTextBox.TextLength > 11)
            {
                homeURL = modifyURLTextBox.Text;
                modifyURLPanel.Visible = false;
            }
            else
            {
                modifyURLTextBox.Select();
                modifyURLTextBox.ResetText();
            }
        }

        private void ModifyURLCancelButton_Click(object sender, EventArgs e)
        {
            modifyURLTextBox.Text = "";
        }

        private void CloseModifyURLPanel(object sender, EventArgs e)
        {
            modifyURLPanel.Visible = false;
        }

        private void ValidateURLModification(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // validate the new URL
            if (modifyURLTextBox.Text.StartsWith("http://"))
                homeURL = modifyURLTextBox.Text;
            else
            {
                e.Cancel = false;
                newURLError.SetError(modifyURLTextBox, "Invalid URL!");
                modifyURLTextBox.Focus();
                modifyURLTextBox.PlaceholderText = "Provide a Valid URL";
            }
        }


        //--------------------------------  BOOKMARK -------------------------------------------
        private void BookmarkButtonClick(object sender, EventArgs e)
        {
            //PANEL IS NOT YET VISIBLE ------------- CHECK
            bookmarkerPanel.Visible = true;

            Debug.WriteLine("WORK Incoming");
            bookmarkURLBox.Text = searchBox.Text;
            String pageTitle = this.Text.Split(" - ")[1];
            bookmarkTitleBox.Text = pageTitle;
            Debug.WriteLine("WORK DONE - "+ pageTitle + " && "+bookmarkURLBox.Text);
            Debug.WriteLine("Bookmarks : "+ bookmarkerPanel.Visible);
        }

        private void AddBookmarkButtonClick(object sender, EventArgs e)
        {
            AddToBookmark(bookmarkTitleBox.Text, bookmarkURLBox.Text);
        }


        //UTILITY METHOD
        private void AddToBookmark(String bookmarkTitle, String url)
        {
            String bookmarkURL = ValidateURL(url);
            bookmarks.Add(bookmarkTitle, bookmarkURL);

        }
        //UTILITY METHOD

        private String ValidateURL(string url)
        {
            return url.Contains("http") ? url : "https://www.google.com/search?q=" + url;

        }

    }
}
