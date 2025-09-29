namespace BetaSurf
{
    partial class BetaSurf
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backward = new Button();
            forward = new Button();
            searchBox = new TextBox();
            search = new Button();
            reload = new Button();
            displayTextBox = new RichTextBox();
            displayCodeBox = new TextBox();
            SuspendLayout();
            // 
            // backward
            // 
            backward.Cursor = Cursors.Hand;
            backward.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backward.Location = new Point(24, 38);
            backward.Margin = new Padding(0);
            backward.Name = "backward";
            backward.Size = new Size(30, 30);
            backward.TabIndex = 0;
            backward.Text = "←";
            backward.UseVisualStyleBackColor = true;
            backward.Click += backwardClick;
            // 
            // forward
            // 
            forward.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forward.Location = new Point(67, 38);
            forward.Margin = new Padding(0);
            forward.Name = "forward";
            forward.Size = new Size(30, 30);
            forward.TabIndex = 1;
            forward.Text = "→";
            forward.UseVisualStyleBackColor = true;
            forward.Click += forwardClick;
            // 
            // searchBox
            // 
            searchBox.AcceptsTab = true;
            searchBox.AccessibleDescription = "A Box to type for search content";
            searchBox.AccessibleName = "Search Box";
            searchBox.AccessibleRole = AccessibleRole.None;
            searchBox.CausesValidation = false;
            searchBox.Location = new Point(164, 38);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Enter to Search";
            searchBox.Size = new Size(413, 23);
            searchBox.TabIndex = 2;
            searchBox.TextChanged += searchTextChanged;
            // 
            // search
            // 
            search.FlatAppearance.BorderSize = 3;
            search.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(598, 38);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(30, 30);
            search.TabIndex = 4;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = true;
            search.Click += searchButtonClick;
            // 
            // reload
            // 
            reload.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reload.Location = new Point(112, 38);
            reload.Margin = new Padding(0);
            reload.Name = "reload";
            reload.Size = new Size(30, 30);
            reload.TabIndex = 5;
            reload.Text = "⟳";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reloadButtonClick;
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(24, 126);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(464, 246);
            displayTextBox.TabIndex = 6;
            displayTextBox.Text = "";
            // 
            // textBox1
            // 
            displayCodeBox.Location = new Point(24, 86);
            displayCodeBox.Name = "textBox1";
            displayCodeBox.Size = new Size(100, 23);
            displayCodeBox.TabIndex = 7;
            // 
            // BetaSurf
            // 
            AcceptButton = search;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 444);
            Controls.Add(displayCodeBox);
            Controls.Add(displayTextBox);
            Controls.Add(reload);
            Controls.Add(search);
            Controls.Add(searchBox);
            Controls.Add(forward);
            Controls.Add(backward);
            Cursor = Cursors.Hand;
            Name = "BetaSurf";
            Text = "Beta Surf";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backward;
        private Button forward;
        private TextBox searchBox;
        private Button search;
        private Button reload;
        private RichTextBox displayTextBox;
        private TextBox displayCodeBox;
    }
}
