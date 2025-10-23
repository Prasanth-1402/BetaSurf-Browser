namespace BetaSurf
{
    partial class Home
    {
        //--------------------------------  SETTINGS -------------------------------------------
        internal void OpenModifyHomeURLPanel(object sender, EventArgs e)
        {
            currentURLTextBox.Text = HomeURL;
            modifyURLPanel.Visible = true;
            modifyURLPanel.BringToFront();
        }

        internal void ModifyHomeURLOkClick(object sender, EventArgs e)
        {
            if (modifyURLTextBox.Text.StartsWith("http://") && modifyURLTextBox.TextLength > 11)
            {
                Properties.Settings.Default.DEFAULT_HOME_URL = modifyURLTextBox.Text;
                FileHandler.DEFAULT_HOME_URL = modifyURLTextBox.Text;
                modifyURLPanel.Visible = false;
            }
            else
            {
                modifyURLTextBox.Select();
                modifyURLTextBox.ResetText();
            }
        }

        internal void ModifyHomeURLCancelClick(object sender, EventArgs e)
        {
            modifyURLTextBox.Text = "";
            modifyURLPanel.Visible = false;
        }

        internal void CloseModifyHomeURLPanel(object sender, EventArgs e)
        {
            modifyURLPanel.Visible = false;
        }

        internal void ValidateHomeURLModification(object sender, System.ComponentModel.CancelEventArgs e)
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

        internal void OpenBookmarkFromSettingsClick(object sender, EventArgs e)
        {
            BookmarkController.Dock = DockStyle.Fill;
            BookmarkController.Visible = true;
            BookmarkController.BringToFront();
            bookmarksTableContainer.Controls.Clear();
            bookmarksTableContainer.Controls.Add(BookmarkController);
            BookmarkController.Show();
            bookmarksTableContainer.Show();
            bookmarksTableContainer.BringToFront();
            BookmarkController.BringToFront();
        }
        //--------------------------------  SETTINGS -------------------------------------------


        //-------------------------------- MODIFY HOME URL -------------------------------------

        //--------------------------------  BOOKMARK -------------------------------------------

        internal void AddToBookmarkListClick(object sender, EventArgs e)
        {
            if (bookmarkURLBox.Text.Length > 10)
            {
                WriteToBookmarksList(bookmarkTitleBox.Text, bookmarkURLBox.Text);
                MessageBox.Show("Bookmarked Successfully");
            }
        }

        internal void CancelBookmarkClick(object sender, EventArgs e)
        {
            bookmarkerPanel.Visible = false;
        }
        //--------------------------------  BOOKMARK -------------------------------------------

    }
}
