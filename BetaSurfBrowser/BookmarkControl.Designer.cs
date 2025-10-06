
using System.Windows.Forms;

namespace BetaSurf
{
    partial class BookmarkControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkControl));
            BmTableControl = new DataGridView();
            BmTitle = new DataGridViewTextBoxColumn();
            BmURL = new DataGridViewTextBoxColumn();
            BmEdit = new DataGridViewButtonColumn();
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
            BmTableControl.Columns.AddRange(new DataGridViewColumn[] { BmTitle, BmURL, BmEdit, BmDelete });
            resources.ApplyResources(BmTableControl, "BmTableControl");
            BmTableControl.Name = "BmTableControl";
            BmTableControl.CellContentClick += BmTableControl_CellContentClick;
            BmTableControl.Click += BmTableControl_CellContentClick;
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
            // BmEdit
            // 
            resources.ApplyResources(BmEdit, "BmEdit");
            BmEdit.Name = "BmEdit";
            BmEdit.Text = "EDIT";
            BmTableControl.Columns["BmEdit"].HeaderText = "Edit";
            ((DataGridViewButtonColumn)BmTableControl.Columns["BmEdit"]).Text = "Edit";
            ((DataGridViewButtonColumn)BmTableControl.Columns["BmEdit"]).UseColumnTextForButtonValue = true;
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
        private DataGridViewButtonColumn BmEdit;
        private DataGridViewButtonColumn BmDelete;
    }
}
