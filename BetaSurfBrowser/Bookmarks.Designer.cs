using System.ComponentModel;
using System.Diagnostics;

namespace BetaSurf
{
    partial class Bookmarks
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            bookmarkTable = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            bmURL = new DataGridViewTextBoxColumn();
            bmEdit = new DataGridViewButtonColumn();
            bmDelete = new DataGridViewButtonColumn();
            ((ISupportInitialize)bookmarkTable).BeginInit();
            SuspendLayout();
            // 
            // bookmarkTable
            // 
            bookmarkTable.AllowUserToAddRows = false;
            bookmarkTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookmarkTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bookmarkTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookmarkTable.Columns.AddRange(new DataGridViewColumn[] { Title, bmURL, bmEdit, bmDelete });
            bookmarkTable.Dock = DockStyle.Fill;
            bookmarkTable.Location = new Point(0, 0);
            bookmarkTable.Name = "bookmarkTable";
            bookmarkTable.Size = new Size(731, 415);
            bookmarkTable.TabIndex = 0;
            bookmarkTable.CellContentClick += bookmarkTable_CellContentClick;
            // 
            // Title
            // 
            Debug.WriteLine("Mouting table headers/....");
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // bmURL
            // 
            bmURL.HeaderText = "URL";
            bmURL.Name = "bmURL";
            // 
            // bmEdit
            // 
            bmEdit.HeaderText = "Edit";
            bmEdit.Name = "bmEdit";
            // 
            // bmDelete
            // 
            bmDelete.HeaderText = "Delete";
            bmDelete.Name = "bmDelete";
            // 
            // Bookmarks
            // 
            ClientSize = new Size(731, 415);
            Controls.Add(bookmarkTable);
            Name = "Bookmarks";
            ((ISupportInitialize)bookmarkTable).EndInit();
            ResumeLayout(false);

            bookmarkTable.TopLeftHeaderCell.Value = "X";

        }
        protected DataGridView bookmarkTable;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn bmURL;
        private DataGridViewButtonColumn bmEdit;
        private DataGridViewButtonColumn bmDelete;
    }
}