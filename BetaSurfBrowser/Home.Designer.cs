


namespace BetaSurf
{
    partial class Home
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            backward = new Button();
            forward = new Button();
            SearchBox = new TextBox();
            search = new Button();
            reload = new Button();
            displayTextBox = new RichTextBox();
            displayCodeBox = new TextBox();
            homeButton = new Button();
            settingsButton = new Button();
            settingsDropDown = new ContextMenuStrip(components);
            modifyURLOptionInSettings = new ToolStripMenuItem();
            bookmarksToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            modifyURLPanel = new Panel();
            ModifyHomeURLLabel = new Label();
            modifyURLPanelCloser = new Button();
            currentURLTextBox = new TextBox();
            currentURL = new Label();
            modifyURLLabel = new Label();
            modifyURLOKButton = new Button();
            modifyURLCancelButton = new Button();
            modifyURLTextBox = new TextBox();
            bookmarkerPanel = new Panel();
            bookmarkURLBox = new TextBox();
            bookmarkTitleBox = new TextBox();
            addBookmark = new Button();
            cancelBookmark = new Button();
            bookmarkURLLabel = new Label();
            bookmarkTitleLabel = new Label();
            addToBookmarkLabel = new Label();
            newURLError = new ErrorProvider(components);
            bookmarkButton = new Button();
            bookmarksToolTip = new ToolTip(components);
            bookmarkAdded = new NotifyIcon(components);
            bookmarksTableContainer = new Panel();
            DedicatedURLLayout = new FlowLayoutPanel();
            LoadingLabel = new Label();
            showHistory = new Button();
            historyDropdown = new ContextMenuStrip(components);
            dummyToolStripMenuItem = new ToolStripMenuItem();
            settingsDropDown.SuspendLayout();
            modifyURLPanel.SuspendLayout();
            bookmarkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newURLError).BeginInit();
            bookmarksTableContainer.SuspendLayout();
            historyDropdown.SuspendLayout();
            SuspendLayout();
            // 
            // backward
            // 
            backward.Cursor = Cursors.Hand;
            backward.Enabled = false;
            backward.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backward.Location = new Point(9, 27);
            backward.Margin = new Padding(0);
            backward.Name = "backward";
            backward.Size = new Size(41, 39);
            backward.TabIndex = 0;
            backward.Text = "←";
            backward.UseVisualStyleBackColor = true;
            backward.Click += BackwardClick;
            // 
            // forward
            // 
            forward.Enabled = false;
            forward.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forward.Location = new Point(48, 27);
            forward.Margin = new Padding(0);
            forward.Name = "forward";
            forward.Size = new Size(41, 39);
            forward.TabIndex = 1;
            forward.Text = "→";
            forward.UseVisualStyleBackColor = true;
            forward.Click += ForwardClick;
            // 
            // SearchBox
            // 
            SearchBox.AcceptsTab = true;
            SearchBox.AccessibleDescription = "A Box to type for search content";
            SearchBox.AccessibleName = "Search Box";
            SearchBox.AccessibleRole = AccessibleRole.None;
            SearchBox.CausesValidation = false;
            SearchBox.Location = new Point(205, 36);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Enter to Search";
            SearchBox.Size = new Size(599, 23);
            SearchBox.TabIndex = 2;
            // 
            // search
            // 
            search.FlatAppearance.BorderSize = 3;
            search.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(797, 31);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(40, 33);
            search.TabIndex = 4;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = true;
            search.Click += SearchButtonClick;
            // 
            // reload
            // 
            reload.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reload.Location = new Point(162, 31);
            reload.Margin = new Padding(0);
            reload.Name = "reload";
            reload.Size = new Size(40, 33);
            reload.TabIndex = 5;
            reload.Text = "⟳";
            reload.UseVisualStyleBackColor = true;
            reload.Click += ReloadButtonClick;
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(24, 103);
            displayTextBox.Margin = new Padding(3, 50, 10, 3);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(730, 356);
            displayTextBox.TabIndex = 6;
            displayTextBox.Text = "";
            // 
            // displayCodeBox
            // 
            displayCodeBox.Location = new Point(24, 74);
            displayCodeBox.Name = "displayCodeBox";
            displayCodeBox.Size = new Size(161, 23);
            displayCodeBox.TabIndex = 7;
            // 
            // homeButton
            // 
            homeButton.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeButton.Location = new Point(121, 31);
            homeButton.Margin = new Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(40, 33);
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
            settingsButton.Location = new Point(901, 22);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(56, 47);
            settingsButton.TabIndex = 9;
            settingsButton.Text = "🔧";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += SettingsButtonClick;
            // 
            // settingsDropDown
            // 
            settingsDropDown.AllowDrop = true;
            settingsDropDown.AllowMerge = false;
            settingsDropDown.Items.AddRange(new ToolStripItem[] { modifyURLOptionInSettings, bookmarksToolStripMenuItem, exitToolStripMenuItem });
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
            // bookmarksToolStripMenuItem
            // 
            bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            bookmarksToolStripMenuItem.Size = new Size(172, 22);
            bookmarksToolStripMenuItem.Text = "Bookmarks";
            bookmarksToolStripMenuItem.Click += OpenBookmarkFromSettingsClick;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(172, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // modifyURLPanel
            // 
            modifyURLPanel.BackColor = Color.MistyRose;
            modifyURLPanel.Controls.Add(ModifyHomeURLLabel);
            modifyURLPanel.Controls.Add(modifyURLPanelCloser);
            modifyURLPanel.Controls.Add(currentURLTextBox);
            modifyURLPanel.Controls.Add(currentURL);
            modifyURLPanel.Controls.Add(modifyURLLabel);
            modifyURLPanel.Controls.Add(modifyURLOKButton);
            modifyURLPanel.Controls.Add(modifyURLCancelButton);
            modifyURLPanel.Controls.Add(modifyURLTextBox);
            modifyURLPanel.Location = new Point(205, 159);
            modifyURLPanel.Name = "modifyURLPanel";
            modifyURLPanel.Size = new Size(472, 185);
            modifyURLPanel.TabIndex = 12;
            modifyURLPanel.Visible = false;
            // 
            // ModifyHomeURLLabel
            // 
            ModifyHomeURLLabel.AutoSize = true;
            ModifyHomeURLLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ModifyHomeURLLabel.Location = new Point(147, 15);
            ModifyHomeURLLabel.Name = "ModifyHomeURLLabel";
            ModifyHomeURLLabel.Size = new Size(149, 21);
            ModifyHomeURLLabel.TabIndex = 12;
            ModifyHomeURLLabel.Text = "Modify Home URL";
            // 
            // modifyURLPanelCloser
            // 
            modifyURLPanelCloser.BackColor = Color.White;
            modifyURLPanelCloser.FlatStyle = FlatStyle.Popup;
            modifyURLPanelCloser.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            modifyURLPanelCloser.ForeColor = Color.Red;
            modifyURLPanelCloser.Location = new Point(445, 3);
            modifyURLPanelCloser.Name = "modifyURLPanelCloser";
            modifyURLPanelCloser.Size = new Size(24, 23);
            modifyURLPanelCloser.TabIndex = 7;
            modifyURLPanelCloser.Text = "X";
            modifyURLPanelCloser.UseVisualStyleBackColor = false;
            modifyURLPanelCloser.Click += CloseModifyURLPanel;
            // 
            // currentURLTextBox
            // 
            currentURLTextBox.Location = new Point(147, 61);
            currentURLTextBox.Name = "currentURLTextBox";
            currentURLTextBox.ReadOnly = true;
            currentURLTextBox.Size = new Size(212, 23);
            currentURLTextBox.TabIndex = 6;
            // 
            // currentURL
            // 
            currentURL.AutoSize = true;
            currentURL.Location = new Point(47, 64);
            currentURL.Name = "currentURL";
            currentURL.Size = new Size(80, 15);
            currentURL.TabIndex = 5;
            currentURL.Text = "Current URL : ";
            // 
            // modifyURLLabel
            // 
            modifyURLLabel.AutoSize = true;
            modifyURLLabel.Location = new Point(63, 110);
            modifyURLLabel.Name = "modifyURLLabel";
            modifyURLLabel.Size = new Size(64, 15);
            modifyURLLabel.TabIndex = 3;
            modifyURLLabel.Text = "New URL : ";
            // 
            // modifyURLOKButton
            // 
            modifyURLOKButton.BackColor = SystemColors.HotTrack;
            modifyURLOKButton.ForeColor = SystemColors.ButtonFace;
            modifyURLOKButton.Location = new Point(295, 139);
            modifyURLOKButton.Name = "modifyURLOKButton";
            modifyURLOKButton.Size = new Size(83, 32);
            modifyURLOKButton.TabIndex = 2;
            modifyURLOKButton.Text = "OK";
            modifyURLOKButton.UseVisualStyleBackColor = false;
            modifyURLOKButton.Click += ModifyURLOKButtonClick;
            // 
            // modifyURLCancelButton
            // 
            modifyURLCancelButton.Location = new Point(109, 139);
            modifyURLCancelButton.Name = "modifyURLCancelButton";
            modifyURLCancelButton.Size = new Size(83, 32);
            modifyURLCancelButton.TabIndex = 1;
            modifyURLCancelButton.Text = "Cancel";
            modifyURLCancelButton.UseVisualStyleBackColor = true;
            modifyURLCancelButton.Click += ModifyURLCancelButtonClick;
            // 
            // modifyURLTextBox
            // 
            modifyURLTextBox.AcceptsReturn = true;
            modifyURLTextBox.Location = new Point(147, 102);
            modifyURLTextBox.Name = "modifyURLTextBox";
            modifyURLTextBox.PlaceholderText = "New URL";
            modifyURLTextBox.Size = new Size(212, 23);
            modifyURLTextBox.TabIndex = 0;
            modifyURLTextBox.Validating += ValidateURLModification;
            // 
            // bookmarkerPanel
            // 
            bookmarkerPanel.BackColor = Color.LightSlateGray;
            bookmarkerPanel.BorderStyle = BorderStyle.Fixed3D;
            bookmarkerPanel.Controls.Add(bookmarkURLBox);
            bookmarkerPanel.Controls.Add(bookmarkTitleBox);
            bookmarkerPanel.Controls.Add(addBookmark);
            bookmarkerPanel.Controls.Add(cancelBookmark);
            bookmarkerPanel.Controls.Add(bookmarkURLLabel);
            bookmarkerPanel.Controls.Add(bookmarkTitleLabel);
            bookmarkerPanel.Controls.Add(addToBookmarkLabel);
            newURLError.SetIconAlignment(bookmarkerPanel, ErrorIconAlignment.MiddleLeft);
            bookmarkerPanel.Location = new Point(268, 71);
            bookmarkerPanel.Name = "bookmarkerPanel";
            bookmarkerPanel.Size = new Size(350, 185);
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
            bookmarkTitleBox.Size = new Size(182, 23);
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
            // cancelBookmark
            // 
            cancelBookmark.Location = new Point(91, 132);
            cancelBookmark.Name = "cancelBookmark";
            cancelBookmark.Size = new Size(75, 23);
            cancelBookmark.TabIndex = 3;
            cancelBookmark.Text = "Cancel";
            cancelBookmark.UseVisualStyleBackColor = true;
            cancelBookmark.Click += CancelBookmarkClick;
            // 
            // bookmarkURLLabel
            // 
            bookmarkURLLabel.AutoSize = true;
            bookmarkURLLabel.Location = new Point(48, 91);
            bookmarkURLLabel.Name = "bookmarkURLLabel";
            bookmarkURLLabel.Size = new Size(28, 15);
            bookmarkURLLabel.TabIndex = 2;
            bookmarkURLLabel.Text = "URL";
            // 
            // bookmarkTitleLabel
            // 
            bookmarkTitleLabel.AutoSize = true;
            bookmarkTitleLabel.Location = new Point(48, 50);
            bookmarkTitleLabel.Name = "bookmarkTitleLabel";
            bookmarkTitleLabel.Size = new Size(30, 15);
            bookmarkTitleLabel.TabIndex = 1;
            bookmarkTitleLabel.Text = "Title";
            // 
            // addToBookmarkLabel
            // 
            addToBookmarkLabel.AutoSize = true;
            addToBookmarkLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addToBookmarkLabel.Location = new Point(102, 17);
            addToBookmarkLabel.Name = "addToBookmarkLabel";
            addToBookmarkLabel.Size = new Size(140, 20);
            addToBookmarkLabel.TabIndex = 0;
            addToBookmarkLabel.Text = "Add to Bookmarks";
            // 
            // newURLError
            // 
            newURLError.ContainerControl = this;
            // 
            // bookmarkButton
            // 
            bookmarkButton.Location = new Point(850, 31);
            bookmarkButton.Name = "bookmarkButton";
            bookmarkButton.Size = new Size(40, 33);
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
            // bookmarkAdded
            // 
            bookmarkAdded.BalloonTipIcon = ToolTipIcon.Info;
            bookmarkAdded.BalloonTipText = "Bookmark";
            bookmarkAdded.BalloonTipTitle = "Bookmark";
            bookmarkAdded.ContextMenuStrip = settingsDropDown;
            bookmarkAdded.Icon = (Icon)resources.GetObject("bookmarkAdded.Icon");
            bookmarkAdded.Text = "Bookmarked!";
            bookmarkAdded.Visible = true;
            // 
            // bookmarksTableContainer
            // 
            bookmarksTableContainer.AutoSize = true;
            bookmarksTableContainer.Controls.Add(bookmarkerPanel);
            bookmarksTableContainer.Location = new Point(0, 74);
            bookmarksTableContainer.Name = "bookmarksTableContainer";
            bookmarksTableContainer.Padding = new Padding(15);
            bookmarksTableContainer.Size = new Size(966, 385);
            bookmarksTableContainer.TabIndex = 6;
            bookmarksTableContainer.Visible = false;
            // 
            // DedicatedURLLayout
            // 
            DedicatedURLLayout.BackColor = SystemColors.GradientActiveCaption;
            DedicatedURLLayout.BackgroundImageLayout = ImageLayout.None;
            DedicatedURLLayout.BorderStyle = BorderStyle.Fixed3D;
            DedicatedURLLayout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DedicatedURLLayout.Location = new Point(759, 116);
            DedicatedURLLayout.Name = "DedicatedURLLayout";
            DedicatedURLLayout.Padding = new Padding(10);
            DedicatedURLLayout.Size = new Size(198, 122);
            DedicatedURLLayout.TabIndex = 6;
            DedicatedURLLayout.TabStop = true;
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.BackColor = Color.Yellow;
            LoadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoadingLabel.Location = new Point(362, 435);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(84, 21);
            LoadingLabel.TabIndex = 13;
            LoadingLabel.Text = "Loading...";
            LoadingLabel.Visible = false;
            // 
            // showHistory
            // 
            showHistory.ContextMenuStrip = historyDropdown;
            showHistory.Location = new Point(84, 27);
            showHistory.Name = "showHistory";
            showHistory.Size = new Size(22, 39);
            showHistory.TabIndex = 14;
            showHistory.Text = "▼";
            showHistory.UseVisualStyleBackColor = true;
            showHistory.Click += ShowHistoryDropDown;
            // 
            // historyDropdown
            // 
            historyDropdown.AllowDrop = true;
            historyDropdown.AllowMerge = false;
            historyDropdown.Name = "historyDropdown";
            historyDropdown.Size = new Size(117, 26);
            // 
            // Home
            // 
            AcceptButton = search;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 471);
            Controls.Add(showHistory);
            Controls.Add(LoadingLabel);
            Controls.Add(modifyURLPanel);
            Controls.Add(DedicatedURLLayout);
            Controls.Add(bookmarksTableContainer);
            Controls.Add(bookmarkButton);
            Controls.Add(settingsButton);
            Controls.Add(homeButton);
            Controls.Add(displayCodeBox);
            Controls.Add(displayTextBox);
            Controls.Add(reload);
            Controls.Add(search);
            Controls.Add(SearchBox);
            Controls.Add(forward);
            Controls.Add(backward);
            Cursor = Cursors.Hand;
            Name = "Home";
            Text = "Beta Surf";
            settingsDropDown.ResumeLayout(false);
            modifyURLPanel.ResumeLayout(false);
            modifyURLPanel.PerformLayout();
            bookmarkerPanel.ResumeLayout(false);
            bookmarkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)newURLError).EndInit();
            bookmarksTableContainer.ResumeLayout(false);
            historyDropdown.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
            // -----------------------------BetaSurf-----------------------------
        }


        #endregion

        private Button backward;
        private Button forward;
        private TextBox SearchBox;
        private Button search;
        private Button reload;
        private RichTextBox displayTextBox;
        private TextBox displayCodeBox;
        private Button homeButton;
        private Button settingsButton;
        private ContextMenuStrip settingsDropDown;
        private ToolStripMenuItem modifyURLOptionInSettings;
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
        private Button cancelBookmark;
        private Label bookmarkURLLabel;
        private Label bookmarkTitleLabel;
        private Label addToBookmarkLabel;
        private TextBox bookmarkURLBox;
        private TextBox bookmarkTitleBox;
        private NotifyIcon bookmarkAdded;
        private ToolStripMenuItem bookmarksToolStripMenuItem;
        private Panel bookmarksTableContainer;
        private FlowLayoutPanel DedicatedURLLayout;
        private Label LoadingLabel;
        private Button showHistory;
        private ContextMenuStrip historyDropdown;
        private ToolStripMenuItem dummyToolStripMenuItem;
    }
}
