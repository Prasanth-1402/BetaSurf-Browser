using System.Diagnostics;

namespace BetaSurf
{
    public partial class BookmarkControl : UserControl
    {
        private String _previousValue = "";
        public event Action<string> BookmarkSelected;
        public BookmarkControl()
        {
            InitializeComponent();
        }

        public void LoadData(List<BookmarkDTO> bookmarks)
        {
            BmTableControl.DataSource = bookmarks;
        }

        private void BmTableControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                BmTableControl.Visible = false;
                return;
            }

            var Row = BmTableControl.Rows[e.RowIndex];
            var Title = Row.Cells["Title"].Value?.ToString();
            var URL = Row.Cells["URL"].Value?.ToString();
            if (BmTableControl.Columns[e.ColumnIndex].Name == "BmDelete")
            {
                var IsDelete = MessageBox.Show($"Are you sure want to delete the bookmark '{Title}'? ",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                //Deleting only after successful confirmation
                if (IsDelete == DialogResult.OK)   
                    DeleteBookmark(Row); 
            }
        }
        private void BmTableControl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var Row = BmTableControl.Rows[e.RowIndex];
                var Title = Row.Cells["Title"].Value?.ToString();
                var URL = Row.Cells["URL"].Value?.ToString();
                if (BmTableControl.Columns[e.ColumnIndex].Name == "Title")
                {
                    BookmarkSelected?.Invoke(URL);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("EXception while clicking a cell in Bookmarks Table : "+exception.Source);
            }
        }

        private void DeleteBookmark(DataGridViewRow Row)
        {

            List<BookmarkDTO> allBookmarks = Utility.GetAllBookmarks();
            var RowToDelete = allBookmarks?.FirstOrDefault(bookmark => bookmark.URL.Equals(Row.Cells["URL"].Value));
            if (RowToDelete != null)
            {
                allBookmarks?.Remove(RowToDelete); // removing from the list
                BmTableControl.DataSource = allBookmarks;  // removing from the UI
                if (allBookmarks?.Count > 0) Utility.WriteToBookmarks(allBookmarks); // writing the updated list to CSV
            }
        }

        private void BmTableControl_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Storing the previous value just in case if something went wrong and need to replace the old value
            _previousValue = BmTableControl.Rows[e.RowIndex]?.Cells[e.ColumnIndex]?.Value + ""; 
        }

        private void BmTableControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var cell = BmTableControl.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var value = cell.Value?.ToString()?.Trim();

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("This field cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cell.Value = _previousValue;

            }
            else
            {
                var BookmarksList = (List<BookmarkDTO>)BmTableControl.DataSource;
                Utility.WriteToBookmarks(BookmarksList);
            }
        }
    }
}
