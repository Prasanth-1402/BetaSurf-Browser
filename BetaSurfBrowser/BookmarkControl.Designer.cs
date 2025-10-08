
using System.Windows.Forms;

namespace BetaSurf
{
    partial class BookmarkControl
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkControl));
            BmTableControl = new DataGridView();
            BmTitle = new DataGridViewTextBoxColumn();
            BmURL = new DataGridViewTextBoxColumn();
            BmDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)BmTableControl).BeginInit();
            SuspendLayout();
            // 
            // BmTableControl
            // 
            BmTableControl.AllowUserToAddRows = false;
            BmTableControl.AutoGenerateColumns = false;
            BmTableControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BmTableControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BmTableControl.Columns.AddRange(new DataGridViewColumn[] { BmTitle, BmURL, BmDelete });
            resources.ApplyResources(BmTableControl, "BmTableControl");
            BmTableControl.Name = "BmTableControl";
            BmTableControl.CellContentClick += BmTableControl_CellContentClick;
            BmTableControl.CellValueChanged += BmTableControl_CellValueChanged;
            BmTableControl.CellBeginEdit += BmTableControl_CellBeginEdit;
            // 
            // BmTitle
            // 
            BmTitle.DataPropertyName = "Title";
            resources.ApplyResources(BmTitle, "Title");
            BmTitle.Name = "Title";
            // 
            // BmURL
            // 
            BmURL.DataPropertyName = "URL";
            resources.ApplyResources(BmURL, "URL");
            BmURL.Name = "URL";
            // 
  
            // BmDelete
            // 
            resources.ApplyResources(BmDelete, "BmDelete");
            BmDelete.Name = "BmDelete";
            BmDelete.Text = "DELETE";
            BmTableControl.Columns["BmDelete"].HeaderText = "Delete";
            ((DataGridViewButtonColumn)BmTableControl.Columns["BmDelete"]).Text = "Delete";
            ((DataGridViewButtonColumn)BmTableControl.Columns["BmDelete"]).UseColumnTextForButtonValue = true;
            // 
            // BookmarkControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BmTableControl);
            Name = "BookmarkControl";
            ((System.ComponentModel.ISupportInitialize)BmTableControl).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView BmTableControl;
        private DataGridViewTextBoxColumn BmTitle;
        private DataGridViewTextBoxColumn BmURL;
        private DataGridViewButtonColumn BmDelete;
    }
}
