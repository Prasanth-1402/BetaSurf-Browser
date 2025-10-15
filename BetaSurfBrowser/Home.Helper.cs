using AngleSharp.Browser.Dom;
using BetaSurf;
using BetaSurf.Properties;
using System;
using System.Diagnostics;
using System.Net;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace BetaSurf
{
    partial class Home
    {
        internal void GoToPage(String GoToPageURL)
        {
            var URL = Utility.ValidateURL(GoToPageURL);
            Debug.WriteLine(" Going to ... " + URL + " " + IsNavFromHistory);
            if (!IsNavFromHistory)
            {
                if (CurrentIndex < History.Count - 1)
                    History.RemoveRange(CurrentIndex + 1, History.Count - CurrentIndex - 1);
                if (History.Count == 0 || History.Last() != URL)
                    History.Insert(0, URL);

                CurrentIndex = History.Count - 1;

                Debug.WriteLine("History -> " + String.Join(" ", History));
                Debug.WriteLine(CurrentIndex);
            }
            SearchBox.Text = URL;
            LoadWebPage();
            backward.Enabled = CurrentIndex > 0;
            forward.Enabled = CurrentIndex < History.Count - 1;
        }

        internal void LoadWebPage()
        {
            String searchText = SearchBox.Text;
            if (searchText == null) return;
            String searchURL = Utility.ValidateURL(searchText);
            LoadWebPage(searchURL);
        }

        internal async Task LoadWebPage(String searchURL)
        {
            LoadingLabel.Visible = true;
            displayTextBox.Visible = false;
            displayCodeBox.Visible = false;
            DedicatedURLLayout.Visible = false;
            HttpResponseMessage response = await new HttpClient().GetAsync(searchURL);
            try
            {
                String rawHTML = await response.Content.ReadAsStringAsync();
                this.Text = $"{response.StatusCode.ToString()} - {Utility.GetTitle(rawHTML)}";
                displayCodeBox.Text = response.StatusCode.ToString();
                displayTextBox.Text = rawHTML;  // updating the main content page 
                ReloadURL = searchURL;

                ShowLinksInDedicatedURLPanel(rawHTML);
            }
            catch (HttpRequestException httpException)
            {
                if (httpException.StatusCode == HttpStatusCode.Forbidden |
                    httpException.StatusCode == HttpStatusCode.BadRequest |
                    httpException.StatusCode == HttpStatusCode.NotFound)

                    displayTextBox.Text = response.RequestMessage.ToString();
                displayCodeBox.Text = response.StatusCode.ToString();

            }
            catch (Exception exception)
            {
                Debug.WriteLine("Not a HTTP Exception : " + exception);
            }
            finally
            {
                LoadingLabel.Visible = false;
                displayTextBox.Visible = true;
                displayCodeBox.Visible = true;
                DedicatedURLLayout.Visible = true;
            }

        }

        internal async Task LoadBookmarksDataFromCSV()
        {
            BookmarkController.LoadData(Utility.GetAllBookmarks());

        }

        internal void WriteToBookmarksList(String bookmarkTitle, String url)
        {
            String bookmarkURL = Utility.ValidateURL(url);
            Bookmarks.Add(new BookmarkDTO(bookmarkTitle, bookmarkURL));
            bookmarkerPanel.Visible = false;
            bookmarkAdded.Visible = true;
            String newBookmark = $"{bookmarkTitle},{bookmarkURL}"; // format to write in CSV
            File.AppendAllText(Settings.Default.BOOKMARKS_FILE, Environment.NewLine + newBookmark);
            LoadBookmarksDataFromCSV();
        }

        internal void GoToURLFromBookMarksTable(String url)
        {
            GoToPage(url);
            BookmarkController.Hide();
            bookmarksTableContainer.Hide();
        }

        internal void GoodByeClick(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void ShowLinksInDedicatedURLPanel(string RawHTML)
        {
            DedicatedURLLayout.Controls.Clear();
            HtmlDocument Document = new();
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
                        LinkLabel.Click += (s, e) => GoToPage(HREF);

                        DedicatedURLLayout.Controls.Add(LinkLabel);
                        DedicatedURLLayout.Visible = true;
                    }
                }
            }
        }

        internal void ClickFromHistoryDropDown(object sender, EventArgs e)
        {
            Debug.WriteLine(sender + " = sender ~~ event = " + e);
            if (sender is ToolStripMenuItem menuItem && sender != null)
            {
                GoToPage(menuItem.Text);
            }
        }
    }
}
