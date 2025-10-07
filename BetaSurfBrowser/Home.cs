using System.Diagnostics;
using BetaSurf.Properties;
namespace BetaSurf
{
    public partial class Home : Form
    {
        private String? reloadURL;
        private static String homeURL = "http://hw.ac.uk";
        private BookmarkControl BookmarkController;
        public List<BookmarkDTO> bookmarks;
       
        public Home()
        {
            InitializeComponent();
            LoadWebContent(homeURL);
            BookmarkController = new();
            bookmarks = new(10);
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
            if (reloadURL == null) return;
            LoadWebPage();
            Debug.WriteLine(bookmarks.Count + " is the count");
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            LoadWebPage();
            Debug.WriteLine(bookmarks.Count + " is the count");
            BookmarkController.LoadData(bookmarks);

        }
        private void HomeButtonClick(object sender, EventArgs e)
        {
            LoadWebContent(homeURL);
        }
        private void BookmarkButtonClick(object sender, EventArgs e)
        {
            bookmarkerPanel.Visible = true;
            bookmarkURLBox.Text = searchBox.Text;
            String pageTitle = this.Text.Split(" - ")[1]; // getting page title from the current context 
            bookmarkTitleBox.Text = pageTitle;
        }
        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsDropDown.Show(settingsButton, 0, settingsButton.Height);
        }

        //--------------------------------  SETTINGS -------------------------------------------
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
                homeURL = modifyURLTextBox.Text;
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
            using var reader = new StreamReader(Settings.Default.BOOKMARKS_FILE);
            using var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
            var bookmarks = csv.GetRecords<BookmarkDTO>().ToList();
            BookmarkController.LoadData(bookmarks);

        }

        private void AddToBookmark(String bookmarkTitle, String url)
        {
            String bookmarkURL = Utility.ValidateURL(url);
            bookmarks.Add(new BookmarkDTO(bookmarkTitle, bookmarkURL));
            bookmarkerPanel.Visible = false;
            bookmarkAdded.Visible = true;
            String newBookmark = $"{bookmarkTitle},{bookmarkURL}"; // format to write in CSV
            File.AppendAllText(Settings.Default.BOOKMARKS_FILE, Environment.NewLine + newBookmark);
            LoadBookmarksDataFromCSV();
        }
        private void LoadWebPage()
        {
            String searchText = searchBox.Text;
            if (searchText == null) return;
            String searchURL = Utility.ValidateURL(searchText);
            LoadWebContent(searchURL);
        }

        private async void LoadWebContent(String searchURL)
        {
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(searchURL);
                String rawHTML = await response.Content.ReadAsStringAsync();
                this.Text = $"{response.StatusCode.ToString()} - {Utility.GetTitle(rawHTML)}";
                displayCodeBox.Text = response.StatusCode.ToString(); // updating the Code Box
                displayTextBox.Text = rawHTML;  // updating the main content page 
                reloadURL = searchURL;
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exception : " + exception);
            }

        }
        //-----------------------------  UTILITY METHOD -------------------------------

    }
}