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
            if (!IsNavFromHistory)
            {
                if (CurrentIndex < History.Count - 1)
                    History.RemoveRange(CurrentIndex + 1, History.Count - CurrentIndex - 1);
                if (History.Count == 0 || History.Last() != URL)
                {
                    if (History.Contains(URL))
                        History.Remove(URL);
                    History.Insert(0, URL);
                }
                CurrentIndex = History.Count - 1;

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
            SetLoadingState(true);
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(searchURL);
                String rawHTML = await response.Content.ReadAsStringAsync();
                this.Text = $"{response.StatusCode.ToString()} - {Utility.GetTitle(rawHTML)}";
                displayCodeBox.Text = response.StatusCode.ToString();
                displayTextBox.Text = rawHTML;  // updating the main content page 
                ReloadURL = searchURL;

                ShowLinksInDedicatedURLPanel(rawHTML);
            }
            catch (HttpRequestException httpException)
            {
                if (httpException.StatusCode == HttpStatusCode.Forbidden | // STATUS CODE : 403
                    httpException.StatusCode == HttpStatusCode.BadRequest | // STATUS CODE : 400
                    httpException.StatusCode == HttpStatusCode.NotFound) // STATUS CODE : 404
                    displayTextBox.Text = httpException.Message.ToString();
                else
                {
                    Debug.WriteLine("HTTP Exception :" + httpException);
                    displayTextBox.Text = "Something went wrong.. Kindly check the URL";
                }
                displayCodeBox.Text = httpException.StatusCode.ToString();

            }
            // General exception like TitleNotFoundException, NullPointerException if some other error occurs
            catch (Exception exception)
            {
                Debug.WriteLine(" Exception : " + exception);
                displayTextBox.Text = "Oops... " + exception.Message;
                displayCodeBox.Text = "ERROR";
            }
            finally
            {
                SetLoadingState(false);
                Debug.WriteLine("Setting loading to false..");
            }

        }
        private void SetLoadingState(Boolean shouldLoad)
        {
            loadingLabel.Visible = shouldLoad;
            displayTextBox.Visible = !shouldLoad;
            displayCodeBox.Visible = !shouldLoad;
            DedicatedURLLayout.Visible = !shouldLoad;
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
            File.AppendAllText(FileHandler.BOOKMARKS, Environment.NewLine + newBookmark);
            LoadBookmarksDataFromCSV();
        }

        internal void GoToURLFromBookMarksTable(String url)
        {
            GoToPage(url);
            BookmarkController.Hide();
            bookmarksTableContainer.Hide();
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
                        LinkLabel LinkLabel = new()
                        {
                            Text = Text,
                            AutoSize = true,
                            Cursor = Cursors.Hand
                        };
                        if (!HREF.StartsWith("http://") && !HREF.StartsWith("https://"))
                            HREF = SearchBox.Text + HREF;
                        LinkLabel.Click += (s, e) => GoToPage(HREF);

                        DedicatedURLLayout.Controls.Add(LinkLabel);
                        DedicatedURLLayout.Visible = true;
                    }
                }
            }
        }

        internal void ClickFromHistoryDropDown(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && sender != null)
                if (menuItem.Text != SearchBox.Text)
                    GoToPage(menuItem?.Text);
        }

        internal void GoodByeClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
