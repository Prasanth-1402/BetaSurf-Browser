


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
            components = new System.ComponentModel.Container();
            backward = new Button();
            forward = new Button();
            searchBox = new TextBox();
            search = new Button();
            reload = new Button();
            displayTextBox = new RichTextBox();
            displayCodeBox = new TextBox();
            homeButton = new Button();
            settingsButton = new Button();
            settingsDropDown = new ContextMenuStrip(components);
            modifyURLOptionInSettings = new ToolStripMenuItem();
            refreshPageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            modifyURLPanel = new Panel();
            bookmarkerPanel = new Panel();
            bookmarkURLBox = new TextBox();
            bookmarkTitleBox = new TextBox();
            addBookmark = new Button();
            button1 = new Button();
            bookmarkURLLabel = new Label();
            bookmarkTitleLabel = new Label();
            addToBookmarkLabel = new Label();
            ModifyHomeURLLabel = new Label();
            modifyURLPanelCloser = new Button();
            currentURLTextBox = new TextBox();
            currentURL = new Label();
            modifyURLLabel = new Label();
            modifyURLOKButton = new Button();
            modifyURLCancelButton = new Button();
            modifyURLTextBox = new TextBox();
            newURLError = new ErrorProvider(components);
            bookmarkButton = new Button();
            bookmarksToolTip = new ToolTip(components);
            settingsDropDown.SuspendLayout();
            modifyURLPanel.SuspendLayout();
            bookmarkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newURLError).BeginInit();
            SuspendLayout();
            // 
            // backward
            // 
            backward.Cursor = Cursors.Hand;
            backward.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backward.Location = new Point(9, 38);
            backward.Margin = new Padding(0);
            backward.Name = "backward";
            backward.Size = new Size(30, 30);
            backward.TabIndex = 0;
            backward.Text = "←";
            backward.UseVisualStyleBackColor = true;
            backward.Click += BackwardClick;
            // 
            // forward
            // 
            forward.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forward.Location = new Point(39, 38);
            forward.Margin = new Padding(0);
            forward.Name = "forward";
            forward.Size = new Size(30, 30);
            forward.TabIndex = 1;
            forward.Text = "→";
            forward.UseVisualStyleBackColor = true;
            forward.Click += ForwardClick;
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
            // 
            // search
            // 
            search.FlatAppearance.BorderSize = 3;
            search.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(547, 38);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(30, 23);
            search.TabIndex = 4;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = true;
            search.Click += SearchButtonClick;
            // 
            // reload
            // 
            reload.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reload.Location = new Point(127, 38);
            reload.Margin = new Padding(0);
            reload.Name = "reload";
            reload.Size = new Size(30, 30);
            reload.TabIndex = 5;
            reload.Text = "⟳";
            reload.UseVisualStyleBackColor = true;
            reload.Click += ReloadButtonClick;
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(24, 103);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(915, 356);
            displayTextBox.TabIndex = 6;
            displayTextBox.Text = "";
            // 
            // displayCodeBox
            // 
            displayCodeBox.Location = new Point(24, 74);
            displayCodeBox.Name = "displayCodeBox";
            displayCodeBox.Size = new Size(133, 23);
            displayCodeBox.TabIndex = 7;
            // 
            // homeButton
            // 
            homeButton.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeButton.Location = new Point(85, 38);
            homeButton.Margin = new Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(30, 30);
            homeButton.TabIndex = 8;
            homeButton.Text = "";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += HomeButtonClick;
            // 
            // settingsButton
            // 
            settingsButton.AllowDrop = true;
            settingsButton.ContextMenuStrip = settingsDropDown;
            settingsButton.FlatAppearance.BorderSize = 3;
            settingsButton.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsButton.Location = new Point(634, 38);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(30, 30);
            settingsButton.TabIndex = 9;
            settingsButton.Text = "🔧";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += SettingsButtonClick;
            // 
            // settingsDropDown
            // 
            settingsDropDown.AllowDrop = true;
            settingsDropDown.AllowMerge = false;
            settingsDropDown.Items.AddRange(new ToolStripItem[] { modifyURLOptionInSettings, refreshPageToolStripMenuItem, exitToolStripMenuItem });
            settingsDropDown.Name = "settingsDropDown";
            settingsDropDown.Size = new Size(173, 70);
            // 
            // modifyURLOptionInSettings
            // 
            modifyURLOptionInSettings.Name = "modifyURLOptionInSettings";
            modifyURLOptionInSettings.Size = new Size(172, 22);
            modifyURLOptionInSettings.Text = "Modify Home URL";
            modifyURLOptionInSettings.Click += OpenModifyURL;
            // 
            // refreshPageToolStripMenuItem
            // 
            refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            refreshPageToolStripMenuItem.Size = new Size(172, 22);
            refreshPageToolStripMenuItem.Text = "Refresh Page";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(172, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // modifyURLPanel
            // 
            modifyURLPanel.Controls.Add(bookmarkerPanel);
            modifyURLPanel.Controls.Add(ModifyHomeURLLabel);
            modifyURLPanel.Controls.Add(modifyURLPanelCloser);
            modifyURLPanel.Controls.Add(currentURLTextBox);
            modifyURLPanel.Controls.Add(currentURL);
            modifyURLPanel.Controls.Add(modifyURLLabel);
            modifyURLPanel.Controls.Add(modifyURLOKButton);
            modifyURLPanel.Controls.Add(modifyURLCancelButton);
            modifyURLPanel.Controls.Add(modifyURLTextBox);
            modifyURLPanel.Location = new Point(375, 177);
            modifyURLPanel.Name = "modifyURLPanel";
            modifyURLPanel.Size = new Size(328, 169);
            modifyURLPanel.TabIndex = 10;
            modifyURLPanel.Visible = false;
            // 
            // bookmarkerPanel
            // 
            bookmarkerPanel.Controls.Add(bookmarkURLBox);
            bookmarkerPanel.Controls.Add(bookmarkTitleBox);
            bookmarkerPanel.Controls.Add(addBookmark);
            bookmarkerPanel.Controls.Add(button1);
            bookmarkerPanel.Controls.Add(bookmarkURLLabel);
            bookmarkerPanel.Controls.Add(bookmarkTitleLabel);
            bookmarkerPanel.Controls.Add(addToBookmarkLabel);
            modifyURLPanel.Location = new Point(375, 177);
            bookmarkerPanel.Name = "bookmarkerPanel";
            bookmarkerPanel.Size = new Size(327, 169);
            bookmarkerPanel.TabIndex = 12;
            bookmarkerPanel.Visible = false;
            // 
            // bookmarkURLBox
            // 
            bookmarkURLBox.Location = new Point(106, 88);
            bookmarkURLBox.Name = "bookmarkURLBox";
            bookmarkURLBox.Size = new Size(182, 23);
            bookmarkURLBox.TabIndex = 6;
            // 
            // bookmarkTitleBox
            // 
            bookmarkTitleBox.Location = new Point(106, 50);
            bookmarkTitleBox.Name = "bookmarkTitleBox";
            bookmarkTitleBox.Size = new Size(149, 23);
            bookmarkTitleBox.TabIndex = 5;
            // 
            // addBookmark
            // 
            addBookmark.Location = new Point(213, 132);
            addBookmark.Name = "addBookmark";
            addBookmark.Size = new Size(75, 23);
            addBookmark.TabIndex = 4;
            addBookmark.Text = "Add";
            addBookmark.UseVisualStyleBackColor = true;
            addBookmark.Click += AddBookmarkButtonClick;
            // 
            // button1
            // 
            button1.Location = new Point(91, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // bookmarkURLLabel
            // 
            bookmarkURLLabel.AutoSize = true;
            bookmarkURLLabel.Location = new Point(24, 91);
            bookmarkURLLabel.Name = "bookmarkURLLabel";
            bookmarkURLLabel.Size = new Size(28, 15);
            bookmarkURLLabel.TabIndex = 2;
            bookmarkURLLabel.Text = "URL";
            // 
            // bookmarkTitleLabel
            // 
            bookmarkTitleLabel.AutoSize = true;
            bookmarkTitleLabel.Location = new Point(22, 50);
            bookmarkTitleLabel.Name = "bookmarkTitleLabel";
            bookmarkTitleLabel.Size = new Size(30, 15);
            bookmarkTitleLabel.TabIndex = 1;
            bookmarkTitleLabel.Text = "Title";
            // 
            // addToBookmarkLabel
            // 
            addToBookmarkLabel.AutoSize = true;
            addToBookmarkLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addToBookmarkLabel.Location = new Point(115, 19);
            addToBookmarkLabel.Name = "addToBookmarkLabel";
            addToBookmarkLabel.Size = new Size(140, 20);
            addToBookmarkLabel.TabIndex = 0;
            addToBookmarkLabel.Text = "Add to Bookmarks";
            // 
            // ModifyHomeURLLabel
            // 
            ModifyHomeURLLabel.AutoSize = true;
            ModifyHomeURLLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ModifyHomeURLLabel.Location = new Point(92, 5);
            ModifyHomeURLLabel.Name = "ModifyHomeURLLabel";
            ModifyHomeURLLabel.Size = new Size(149, 21);
            ModifyHomeURLLabel.TabIndex = 12;
            ModifyHomeURLLabel.Text = "Modify Home URL";
            // 
            // modifyURLPanelCloser
            // 
            modifyURLPanelCloser.Location = new Point(301, 3);
            modifyURLPanelCloser.Name = "modifyURLPanelCloser";
            modifyURLPanelCloser.Size = new Size(24, 23);
            modifyURLPanelCloser.TabIndex = 7;
            modifyURLPanelCloser.Text = "X";
            modifyURLPanelCloser.UseVisualStyleBackColor = true;
            modifyURLPanelCloser.Click += CloseModifyURLPanel;
            // 
            // currentURLTextBox
            // 
            currentURLTextBox.Location = new Point(92, 42);
            currentURLTextBox.Name = "currentURLTextBox";
            currentURLTextBox.ReadOnly = true;
            currentURLTextBox.Size = new Size(212, 23);
            currentURLTextBox.TabIndex = 6;
            // 
            // currentURL
            // 
            currentURL.AutoSize = true;
            currentURL.Location = new Point(13, 42);
            currentURL.Name = "currentURL";
            currentURL.Size = new Size(80, 15);
            currentURL.TabIndex = 5;
            currentURL.Text = "Current URL : ";
            // 
            // modifyURLLabel
            // 
            modifyURLLabel.AutoSize = true;
            modifyURLLabel.Location = new Point(13, 76);
            modifyURLLabel.Name = "modifyURLLabel";
            modifyURLLabel.Size = new Size(64, 15);
            modifyURLLabel.TabIndex = 3;
            modifyURLLabel.Text = "New URL : ";
            // 
            // modifyURLOKButton
            // 
            modifyURLOKButton.BackColor = SystemColors.HotTrack;
            modifyURLOKButton.ForeColor = SystemColors.ButtonFace;
            modifyURLOKButton.Location = new Point(222, 121);
            modifyURLOKButton.Name = "modifyURLOKButton";
            modifyURLOKButton.Size = new Size(75, 23);
            modifyURLOKButton.TabIndex = 2;
            modifyURLOKButton.Text = "OK";
            modifyURLOKButton.UseVisualStyleBackColor = false;
            modifyURLOKButton.Click += ModifyURLOKButtonClick;
            // 
            // modifyURLCancelButton
            // 
            modifyURLCancelButton.Location = new Point(92, 121);
            modifyURLCancelButton.Name = "modifyURLCancelButton";
            modifyURLCancelButton.Size = new Size(75, 23);
            modifyURLCancelButton.TabIndex = 1;
            modifyURLCancelButton.Text = "Cancel";
            modifyURLCancelButton.UseVisualStyleBackColor = true;
            modifyURLCancelButton.Click += ModifyURLCancelButton_Click;
            // 
            // modifyURLTextBox
            // 
            modifyURLTextBox.AcceptsReturn = true;
            modifyURLTextBox.Location = new Point(92, 76);
            modifyURLTextBox.Name = "modifyURLTextBox";
            modifyURLTextBox.PlaceholderText = "New URL";
            modifyURLTextBox.Size = new Size(212, 23);
            modifyURLTextBox.TabIndex = 0;
            modifyURLTextBox.Validating += ValidateURLModification;
            // 
            // newURLError
            // 
            newURLError.ContainerControl = this;
            // 
            // bookmarkButton
            // 
            bookmarkButton.Location = new Point(597, 38);
            bookmarkButton.Name = "bookmarkButton";
            bookmarkButton.Size = new Size(34, 30);
            bookmarkButton.TabIndex = 11;
            bookmarkButton.Text = "🔖";
            bookmarkButton.UseVisualStyleBackColor = true;
            bookmarkButton.Click += BookmarkButtonClick;
            // 
            // bookmarksToolTip
            // 
            bookmarksToolTip.BackColor = Color.LightBlue;
            bookmarksToolTip.IsBalloon = true;
            bookmarksToolTip.ShowAlways = true;
            bookmarksToolTip.Tag = "Bookmark";
            bookmarksToolTip.ToolTipIcon = ToolTipIcon.Info;
            bookmarksToolTip.ToolTipTitle = "Bookmark this Page";
            // 
            // BetaSurf
            // 
            AcceptButton = search;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 471);
            Controls.Add(bookmarkButton);
            Controls.Add(modifyURLPanel);
            Controls.Add(settingsButton);
            Controls.Add(homeButton);
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
            Load += OnBrowserLoad;
            settingsDropDown.ResumeLayout(false);
            modifyURLPanel.ResumeLayout(false);
            modifyURLPanel.PerformLayout();
            bookmarkerPanel.ResumeLayout(false);
            bookmarkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newURLError).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // -----------------------------BetaSurf-----------------------------
        }

        #endregion

        private Button backward;
        private Button forward;
        private TextBox searchBox;
        private Button search;
        private Button reload;
        private RichTextBox displayTextBox;
        private TextBox displayCodeBox;
        private Button homeButton;
        private Button settingsButton;
        private ContextMenuStrip settingsDropDown;
        private ToolStripMenuItem modifyURLOptionInSettings;
        private ToolStripMenuItem refreshPageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel modifyURLPanel;
        private Label modifyURLLabel;
        private Button modifyURLOKButton;
        private Button modifyURLCancelButton;
        private TextBox modifyURLTextBox;
        private Label currentURL;
        private TextBox currentURLTextBox;
        private Button modifyURLPanelCloser;
        private ErrorProvider newURLError;
        private Button bookmarkButton;
        private ToolTip bookmarksToolTip;
        private Label ModifyHomeURLLabel;
        private Panel bookmarkerPanel;
        private Button addBookmark;
        private Button button1;
        private Label bookmarkURLLabel;
        private Label bookmarkTitleLabel;
        private Label addToBookmarkLabel;
        private TextBox bookmarkURLBox;
        private TextBox bookmarkTitleBox;
    }
}
