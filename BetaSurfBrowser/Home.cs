using BetaSurf.Properties;
using System.Diagnostics;
using System.Net;

namespace BetaSurf
{
    public partial class Home : Form
    {
        private String? ReloadURL;
        private static String HomeURL = "http://hw.ac.uk";
        private String CurrentURL = HomeURL;
        private Boolean IsNavFromHistory = false;
        private int CurrentIndex = -1;

        private BookmarkControl BookmarkController;
        public List<BookmarkDTO> Bookmarks;
        private List<String> History;
        public Home()
        {
            InitializeComponent();
            SearchBox.Text = HomeURL;
            LoadWebPage(HomeURL);
            BookmarkController = new();
            Bookmarks = new(10);
            History = new();
            this.Load += async (s, e) => await LoadBookmarksDataFromCSV();
            BookmarkController.BookmarkSelected += url => GoToURLFromBookMarksTable(url);
        }

        // -------------------------  HOME PAGE BUTTONS --------------------------=----------
        private void BackwardClick(object sender, EventArgs e)
        {
            Debug.WriteLine("History from backward -> " + String.Join(" ", History));
            Debug.WriteLine(CurrentIndex);

            if (CurrentIndex > 0)
            {
                IsNavFromHistory = true;
                CurrentIndex--;
                GoToPage(History[CurrentIndex]);
                IsNavFromHistory = false;
                forward.Enabled = true;
                showHistory.Enabled = true;
            }
        }
        private void ForwardClick(object sender, EventArgs e)
        {
            if (CurrentIndex < History.Count - 1)
            {
                IsNavFromHistory = true;
                CurrentIndex++;
                Debug.WriteLine("History from forward -> " + String.Join(" ", History));
                Debug.WriteLine(CurrentIndex);
                GoToPage(History[CurrentIndex]);
                IsNavFromHistory = false;
                backward.Enabled = History.Count > 0;
                showHistory.Enabled = History.Count > 0;
            }
        }
        private void HistoryDropdownClick(object sender, EventArgs e) {
            historyDropdown.Items.Clear();
            Debug.WriteLine("Show history drop down clicked " + String.Join(" ", History));

            if(History.Capacity > 0)
                foreach(var historyValues in History.Take(5))
                if (historyDropdown.Items.IndexOfKey(historyValues) <= 0)
                {
                    ToolStripMenuItem historyMenuItem = new(historyValues);
                    historyMenuItem.Click += ClickFromHistoryDropDown; // Attach the handler here
                    historyDropdown.Items.Add(historyMenuItem);
                }

            historyDropdown.Show(showHistory, 0, showHistory.Height);
        }
        private void ReloadClick(object sender, EventArgs e)
        {
            if (ReloadURL == null) return;
            LoadWebPage();
        }
        private void SearchClick(object sender, EventArgs e)
        {
            IsNavFromHistory = false;
            CurrentURL = SearchBox.Text;
            GoToPage(CurrentURL);
            LoadWebPage();
            BookmarkController.LoadData(Bookmarks);
            backward.Enabled = true;
            showHistory.Enabled = true;

        }
        private void HomeClick(object sender, EventArgs e)
        {
            LoadWebPage(HomeURL);
            SearchBox.Text = HomeURL;
        }
        private void AddBookmarkClick(object sender, EventArgs e)
        {
            bookmarkerPanel.Visible = true;
            bookmarkURLBox.Text = SearchBox.Text;
            String pageTitle = this.Text.Split(" - ")[1]; // getting page title from the current context 
            bookmarkTitleBox.Text = pageTitle;
        }
        private void SettingsClick(object sender, EventArgs e)
        {
            settingsDropDown.Show(settingsButton, 0, settingsButton.Height);
        }
        // -------------------------  HOME PAGE BUTTONS ---------------------------------------

    }
}