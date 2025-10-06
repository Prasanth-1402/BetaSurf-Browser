using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetaSurf;

namespace BetaSurf
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()
        {
            InitializeComponent();
        }
        private void bookmarkTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Clicked on a cell in the bookmark table");

            if (e.RowIndex < 0) return;

            if(e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                bookmarkTable.Visible = false;
            }
            if (bookmarkTable.Columns[e.ColumnIndex].Name == "EditButton")
            {
                MessageBox.Show($"Edit clicked on row {e.RowIndex}");
            }
            else if (bookmarkTable.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                bookmarkTable.Rows.RemoveAt(e.RowIndex);
            }
        }


    }
}
