using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BetaSurf
{
    public partial class BookmarkControl : UserControl
    {
        public BookmarkControl()
        {
            InitializeComponent();
        }

        public void LoadData(List<BookmarkDTO> bookmarks)
        {
            BmTableControl.DataSource = bookmarks;

            Debug.WriteLine($"Bookmarks: {bookmarks.Count}");
            Debug.WriteLine("Loading Data..."+bookmarks);
        }

        public void getTableData()
        {
            Debug.WriteLine("COULMNSSSS --- " + BmTableControl.ColumnCount);
            Debug.WriteLine(BmTableControl.RowCount);
        }
        private void BmTableControl_CellContentClick(object sender, EventArgs e)
        {

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

            switch (BmTableControl.Columns[e.ColumnIndex].Name)
            {
                case "BmDelete":
                    var IsDelete = MessageBox.Show($"Are you sure want to delete the bookmark '{Title}'? ",
                        "Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);

                    //Deleting only after successful confirmation
                    if (IsDelete == DialogResult.OK)
                        DeleteBookmark(Title); 
                    break;

                case "BmEdit":
                    MessageBox.Show($"You are going to edit the bookmark '{Title}' ",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    EditBookmark(Title, URL); // Editing after warning 
                    break;
            }
        }

        private void DeleteBookmark(String Title) { }

        private void EditBookmark(String Title, string URL) { }

    }
}
