using System.Diagnostics;
using BetaSurf.Properties;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace BetaSurf
{
    public partial class Home : Form
    {
        private String? ReloadURL;
        private static String HomeURL = "http://hw.ac.uk";
        private BookmarkControl BookmarkController;
        public List<BookmarkDTO> Bookmarks;

        private String CurrentURL = HomeURL;
        public Home()
        {
            InitializeComponent();
            SearchBox.Text = HomeURL;
            LoadWebContent(HomeURL);
            BookmarkController = new();
            Bookmarks = new(10);
            this.Load += async (s, e) => await LoadBookmarksDataFromCSV();
        }

        private void BackwardClick(object sender, EventArgs e)
        {

        }
        private void ForwardClick(object sender, EventArgs e)
        {

        }

        private void ReloadButtonClick(object sender, EventArgs e)
        {
            if (ReloadURL == null) return;
            LoadWebPage();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            LoadWebPage();
            BookmarkController.LoadData(Bookmarks);
            CurrentURL = SearchBox.Text;
            backward.Enabled = true;

        }
        private void HomeButtonClick(object sender, EventArgs e)
        {
            LoadWebContent(HomeURL);
        }
        private void BookmarkButtonClick(object sender, EventArgs e)
        {
            bookmarkerPanel.Visible = true;
            bookmarkURLBox.Text = SearchBox.Text;
            String pageTitle = this.Text.Split(" - ")[1]; // getting page title from the current context 
            bookmarkTitleBox.Text = pageTitle;
        }
        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsDropDown.Show(settingsButton, 0, settingsButton.Height);
        }

        internal void ShowLinksPanel(string RawHTML)
        {
            DedicatedURLLayout.Controls.Clear();
            HtmlDocument Document = new HtmlDocument();
            Document.LoadHtml(RawHTML);

            var Links = Document.DocumentNode.SelectNodes("//a[@href]");

            if (Links != null)
            {
                var firstFiveLinks = Links.Take(5).ToList();

                foreach (var link in firstFiveLinks)
                {
                    string HREF = link.GetAttributeValue("href", "").Trim();
                    string Text = link.InnerText.Trim();
                    if (!string.IsNullOrEmpty(HREF))
                    {
                        LinkLabel LinkLabel = new();
                        LinkLabel.Text = Text;
                        LinkLabel.AutoSize = true;
                        LinkLabel.Cursor = Cursors.Hand;
                        if (!HREF.StartsWith("http://") && !HREF.StartsWith("https://"))
                        {
                            HREF = SearchBox.Text + HREF;
                        }
                        LinkLabel.Click += async (s, e) => await LoadWebContent(HREF);

                        DedicatedURLLayout.Controls.Add(LinkLabel);
                        DedicatedURLLayout.Visible = true;
                    }
                }
            }
        }
        //--------------------------------  SETTINGS -------------------------------------------
        private void OpenModifyURL(object sender, EventArgs e)
        {
            currentURLTextBox.Text = HomeURL;
            modifyURLPanel.Visible = true;
        }
        private void ModifyURLOKButtonClick(object sender, EventArgs e)
        {
            if (modifyURLTextBox.Text.StartsWith("http://") && modifyURLTextBox.TextLength > 11)
            {
                HomeURL = modifyURLTextBox.Text;
                modifyURLPanel.Visible = false;
            }
            else
            {
                modifyURLTextBox.Select();
                modifyURLTextBox.ResetText();
            }
        }

        private void ModifyURLCancelButtonClick(object sender, EventArgs e)
        {
            modifyURLTextBox.Text = "";
            modifyURLPanel.Visible = false;
        }

        private void CloseModifyURLPanel(object sender, EventArgs e)
        {
            modifyURLPanel.Visible = false;
        }

        private void ValidateURLModification(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // validate the new URL
            if (modifyURLTextBox.Text.StartsWith("http://"))
                HomeURL = modifyURLTextBox.Text;
            else
            {
                e.Cancel = false;
                newURLError.SetError(modifyURLTextBox, "Invalid URL!");
                modifyURLTextBox.Focus();
                modifyURLTextBox.PlaceholderText = "Provide a Valid URL";
            }
        }
        private void OpenBookmarkFromSettingsClick(object sender, EventArgs e)
        {
            BookmarkController.Dock = DockStyle.Fill;
            BookmarkController.Visible = true;
            BookmarkController.BringToFront();
            bookmarksTableContainer.Controls.Clear();
            bookmarksTableContainer.Controls.Add(BookmarkController);
            BookmarkController.Show();
            bookmarksTableContainer.Show();
        }
        //--------------------------------  SETTINGS -------------------------------------------


        //--------------------------------  BOOKMARK -------------------------------------------

        private void AddBookmarkButtonClick(object sender, EventArgs e)
        {
            if (bookmarkURLBox.Text.Length > 10)
            {
                AddToBookmark(bookmarkTitleBox.Text, bookmarkURLBox.Text);
                MessageBox.Show("Bookmarked Successfully");
            }
        }

        private void CancelBookmarkClick(object sender, EventArgs e)
        {
            bookmarkerPanel.Visible = false;
        }
        //--------------------------------  BOOKMARK -------------------------------------------


        //-----------------------------  UTILITY METHOD -------------------------------
        private async Task LoadBookmarksDataFromCSV()
        {
            BookmarkController.LoadData(Utility.GetAllBookmarks());

        }
        private void AddToBookmark(String bookmarkTitle, String url)
        {
            String bookmarkURL = Utility.ValidateURL(url);
            Bookmarks.Add(new BookmarkDTO(bookmarkTitle, bookmarkURL));
            bookmarkerPanel.Visible = false;
            bookmarkAdded.Visible = true;
            String newBookmark = $"{bookmarkTitle},{bookmarkURL}"; // format to write in CSV
            File.AppendAllText(Settings.Default.BOOKMARKS_FILE, Environment.NewLine + newBookmark);
            LoadBookmarksDataFromCSV();
        }
        private void LoadWebPage()
        {
            String searchText = SearchBox.Text;
            if (searchText == null) return;
            String searchURL = Utility.ValidateURL(searchText);
            LoadWebContent(searchURL);
        }

        internal async Task LoadWebContent(String searchURL)
        {
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(searchURL);
                String rawHTML = await response.Content.ReadAsStringAsync();
                this.Text = $"{response.StatusCode.ToString()} - {Utility.GetTitle(rawHTML)}";
                displayCodeBox.Text = response.StatusCode.ToString(); // updating the Code Box
                displayTextBox.Text = rawHTML;  // updating the main content page 
                ReloadURL = searchURL;

                ShowLinksPanel(rawHTML);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exception : " + exception);
            }

        }
        //-----------------------------  UTILITY METHOD -------------------------------

    }
}