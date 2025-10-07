using System.Diagnostics;

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
        }

        public void getTableData()
        {
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
            }
        }
        //TODO - Write Delete Logic
        private void DeleteBookmark(String Title) { }


        private void BmTableControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var Row = BmTableControl.Rows[e.RowIndex];
            var Column = BmTableControl.Columns[e.ColumnIndex].Name;
            var NewValue = Row.Cells[e.ColumnIndex].Value;
            //TODO - Update the exact column/row value in the CSV file
        }
    }
}
