
namespace MyApplication
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripBooksOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBookAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBookManageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBookOwnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserUpdateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserChangePassItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettingOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripColorSettingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdminOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdminUsersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdminBooksItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLogoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userWelcomeMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.messageStatusStrip = new System.Windows.Forms.StatusStrip();
            this.displayBooksListbox = new System.Windows.Forms.ListBox();
            this.showAllBooksButton = new System.Windows.Forms.Button();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.searchByNameTextbox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchByAuthorLabel = new System.Windows.Forms.Label();
            this.searchByAuthorTextbox = new System.Windows.Forms.TextBox();
            this.yearFromTextbox = new System.Windows.Forms.TextBox();
            this.searchByYearLabel = new System.Windows.Forms.Label();
            this.yearFromLabel = new System.Windows.Forms.Label();
            this.yearToLabel = new System.Windows.Forms.Label();
            this.yearToTextbox = new System.Windows.Forms.TextBox();
            this.searchByGenreLabel = new System.Windows.Forms.Label();
            this.genresComboBox = new System.Windows.Forms.ComboBox();
            this.searchByBookTypeLabel = new System.Windows.Forms.Label();
            this.bookTypeCombobox = new System.Windows.Forms.ComboBox();
            this.searchByOwnerUsernameLabel = new System.Windows.Forms.Label();
            this.searchByOwnerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.pageLabel = new System.Windows.Forms.Label();
            this.pageIndexLabel = new System.Windows.Forms.Label();
            this.pageDeviderLabel = new System.Windows.Forms.Label();
            this.pageLastPageLabel = new System.Windows.Forms.Label();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.lastPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.userOptionsMenuStrip.SuspendLayout();
            this.messageStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBooksOption
            // 
            this.toolStripBooksOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBookAddItem,
            this.toolStripBookManageItem,
            this.toolStripBookOwnItem});
            this.toolStripBooksOption.Name = "toolStripBooksOption";
            this.toolStripBooksOption.Size = new System.Drawing.Size(51, 20);
            this.toolStripBooksOption.Text = "&Books";
            // 
            // toolStripBookAddItem
            // 
            this.toolStripBookAddItem.Name = "toolStripBookAddItem";
            this.toolStripBookAddItem.Size = new System.Drawing.Size(186, 22);
            this.toolStripBookAddItem.Text = "Add a New Book";
            this.toolStripBookAddItem.Click += new System.EventHandler(this.ToolStripBookAddItem_Click);
            // 
            // toolStripBookManageItem
            // 
            this.toolStripBookManageItem.Name = "toolStripBookManageItem";
            this.toolStripBookManageItem.Size = new System.Drawing.Size(186, 22);
            this.toolStripBookManageItem.Text = "Manage Your Books";
            this.toolStripBookManageItem.Click += new System.EventHandler(this.ToolStripBookManageItem_Click);
            // 
            // toolStripBookOwnItem
            // 
            this.toolStripBookOwnItem.Name = "toolStripBookOwnItem";
            this.toolStripBookOwnItem.Size = new System.Drawing.Size(186, 22);
            this.toolStripBookOwnItem.Text = "Own Unwanted Book";
            this.toolStripBookOwnItem.Click += new System.EventHandler(this.ToolStripBookOwnItem_Click);
            // 
            // toolStripUserOption
            // 
            this.toolStripUserOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUserUpdateItem,
            this.toolStripUserChangePassItem});
            this.toolStripUserOption.Name = "toolStripUserOption";
            this.toolStripUserOption.Size = new System.Drawing.Size(82, 20);
            this.toolStripUserOption.Text = "&User Setting";
            // 
            // toolStripUserUpdateItem
            // 
            this.toolStripUserUpdateItem.Name = "toolStripUserUpdateItem";
            this.toolStripUserUpdateItem.Size = new System.Drawing.Size(195, 22);
            this.toolStripUserUpdateItem.Text = "Update Your Profile";
            // 
            // toolStripUserChangePassItem
            // 
            this.toolStripUserChangePassItem.Name = "toolStripUserChangePassItem";
            this.toolStripUserChangePassItem.Size = new System.Drawing.Size(195, 22);
            this.toolStripUserChangePassItem.Text = "Change Your Password";
            // 
            // toolStripSettingOption
            // 
            this.toolStripSettingOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripColorSettingItem});
            this.toolStripSettingOption.Name = "toolStripSettingOption";
            this.toolStripSettingOption.Size = new System.Drawing.Size(61, 20);
            this.toolStripSettingOption.Text = "S&ettings";
            // 
            // toolStripColorSettingItem
            // 
            this.toolStripColorSettingItem.Name = "toolStripColorSettingItem";
            this.toolStripColorSettingItem.Size = new System.Drawing.Size(177, 22);
            this.toolStripColorSettingItem.Text = "Personalize Colours";
            // 
            // toolStripAdminOption
            // 
            this.toolStripAdminOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdminUsersItem,
            this.toolStripAdminBooksItem});
            this.toolStripAdminOption.Name = "toolStripAdminOption";
            this.toolStripAdminOption.Size = new System.Drawing.Size(55, 20);
            this.toolStripAdminOption.Text = "&Admin";
            // 
            // toolStripAdminUsersItem
            // 
            this.toolStripAdminUsersItem.Name = "toolStripAdminUsersItem";
            this.toolStripAdminUsersItem.Size = new System.Drawing.Size(152, 22);
            this.toolStripAdminUsersItem.Text = "Manage Users";
            // 
            // toolStripAdminBooksItem
            // 
            this.toolStripAdminBooksItem.Name = "toolStripAdminBooksItem";
            this.toolStripAdminBooksItem.Size = new System.Drawing.Size(152, 22);
            this.toolStripAdminBooksItem.Text = "Manage Books";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLogoutItem,
            this.toolStripExitItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolStripLogoutItem
            // 
            this.toolStripLogoutItem.Name = "toolStripLogoutItem";
            this.toolStripLogoutItem.Size = new System.Drawing.Size(156, 22);
            this.toolStripLogoutItem.Text = "Log Out";
            // 
            // toolStripExitItem
            // 
            this.toolStripExitItem.Name = "toolStripExitItem";
            this.toolStripExitItem.Size = new System.Drawing.Size(156, 22);
            this.toolStripExitItem.Text = "Exit Application";
            // 
            // userOptionsMenuStrip
            // 
            this.userOptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBooksOption,
            this.toolStripUserOption,
            this.toolStripSettingOption,
            this.toolStripAdminOption,
            this.exitToolStripMenuItem});
            this.userOptionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.userOptionsMenuStrip.Name = "userOptionsMenuStrip";
            this.userOptionsMenuStrip.Size = new System.Drawing.Size(764, 24);
            this.userOptionsMenuStrip.TabIndex = 0;
            this.userOptionsMenuStrip.Text = "---";
            // 
            // userWelcomeMessageLabel
            // 
            this.userWelcomeMessageLabel.Name = "userWelcomeMessageLabel";
            this.userWelcomeMessageLabel.Size = new System.Drawing.Size(22, 17);
            this.userWelcomeMessageLabel.Text = "---";
            // 
            // messageStatusStrip
            // 
            this.messageStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userWelcomeMessageLabel});
            this.messageStatusStrip.Location = new System.Drawing.Point(0, 349);
            this.messageStatusStrip.Name = "messageStatusStrip";
            this.messageStatusStrip.Size = new System.Drawing.Size(764, 22);
            this.messageStatusStrip.TabIndex = 27;
            this.messageStatusStrip.Text = "statusStrip1";
            // 
            // displayBooksListbox
            // 
            this.displayBooksListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBooksListbox.FormattingEnabled = true;
            this.displayBooksListbox.HorizontalScrollbar = true;
            this.displayBooksListbox.ItemHeight = 15;
            this.displayBooksListbox.Location = new System.Drawing.Point(380, 27);
            this.displayBooksListbox.Name = "displayBooksListbox";
            this.displayBooksListbox.Size = new System.Drawing.Size(384, 319);
            this.displayBooksListbox.TabIndex = 22;
            this.displayBooksListbox.DoubleClick += new System.EventHandler(this.DisplayBooksListbox_DoubleClick);
            // 
            // showAllBooksButton
            // 
            this.showAllBooksButton.Location = new System.Drawing.Point(274, 246);
            this.showAllBooksButton.Name = "showAllBooksButton";
            this.showAllBooksButton.Size = new System.Drawing.Size(100, 25);
            this.showAllBooksButton.TabIndex = 17;
            this.showAllBooksButton.Text = "Show A&ll Books";
            this.showAllBooksButton.UseVisualStyleBackColor = true;
            this.showAllBooksButton.Click += new System.EventHandler(this.ShowAllBooksButton_Click);
            this.showAllBooksButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.showAllBooksButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.Location = new System.Drawing.Point(11, 38);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(102, 15);
            this.searchByNameLabel.TabIndex = 1;
            this.searchByNameLabel.Text = "Search By &Name:";
            // 
            // searchByNameTextbox
            // 
            this.searchByNameTextbox.Location = new System.Drawing.Point(120, 35);
            this.searchByNameTextbox.MaxLength = 25;
            this.searchByNameTextbox.Name = "searchByNameTextbox";
            this.searchByNameTextbox.Size = new System.Drawing.Size(254, 21);
            this.searchByNameTextbox.TabIndex = 2;
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(12, 246);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(75, 25);
            this.searchBookButton.TabIndex = 16;
            this.searchBookButton.Text = "&Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            this.searchBookButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.searchBookButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // searchByAuthorLabel
            // 
            this.searchByAuthorLabel.AutoSize = true;
            this.searchByAuthorLabel.Location = new System.Drawing.Point(11, 78);
            this.searchByAuthorLabel.Name = "searchByAuthorLabel";
            this.searchByAuthorLabel.Size = new System.Drawing.Size(103, 15);
            this.searchByAuthorLabel.TabIndex = 3;
            this.searchByAuthorLabel.Text = "Search By Aut&hor:";
            // 
            // searchByAuthorTextbox
            // 
            this.searchByAuthorTextbox.Location = new System.Drawing.Point(120, 75);
            this.searchByAuthorTextbox.MaxLength = 20;
            this.searchByAuthorTextbox.Name = "searchByAuthorTextbox";
            this.searchByAuthorTextbox.Size = new System.Drawing.Size(254, 21);
            this.searchByAuthorTextbox.TabIndex = 4;
            // 
            // yearFromTextbox
            // 
            this.yearFromTextbox.Location = new System.Drawing.Point(162, 111);
            this.yearFromTextbox.MaxLength = 4;
            this.yearFromTextbox.Name = "yearFromTextbox";
            this.yearFromTextbox.ShortcutsEnabled = false;
            this.yearFromTextbox.Size = new System.Drawing.Size(80, 21);
            this.yearFromTextbox.TabIndex = 7;
            this.yearFromTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTextbox_KeyPress);
            // 
            // searchByYearLabel
            // 
            this.searchByYearLabel.AutoSize = true;
            this.searchByYearLabel.Location = new System.Drawing.Point(11, 114);
            this.searchByYearLabel.Name = "searchByYearLabel";
            this.searchByYearLabel.Size = new System.Drawing.Size(93, 15);
            this.searchByYearLabel.TabIndex = 5;
            this.searchByYearLabel.Text = "Search By &Year:";
            // 
            // yearFromLabel
            // 
            this.yearFromLabel.AutoSize = true;
            this.yearFromLabel.Location = new System.Drawing.Point(117, 114);
            this.yearFromLabel.Name = "yearFromLabel";
            this.yearFromLabel.Size = new System.Drawing.Size(39, 15);
            this.yearFromLabel.TabIndex = 6;
            this.yearFromLabel.Text = "&From:";
            // 
            // yearToLabel
            // 
            this.yearToLabel.AutoSize = true;
            this.yearToLabel.Location = new System.Drawing.Point(248, 114);
            this.yearToLabel.Name = "yearToLabel";
            this.yearToLabel.Size = new System.Drawing.Size(24, 15);
            this.yearToLabel.TabIndex = 8;
            this.yearToLabel.Text = "&To:";
            // 
            // yearToTextbox
            // 
            this.yearToTextbox.Location = new System.Drawing.Point(278, 111);
            this.yearToTextbox.MaxLength = 5;
            this.yearToTextbox.Name = "yearToTextbox";
            this.yearToTextbox.ShortcutsEnabled = false;
            this.yearToTextbox.Size = new System.Drawing.Size(96, 21);
            this.yearToTextbox.TabIndex = 9;
            this.yearToTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTextbox_KeyPress);
            // 
            // searchByGenreLabel
            // 
            this.searchByGenreLabel.AutoSize = true;
            this.searchByGenreLabel.Location = new System.Drawing.Point(11, 150);
            this.searchByGenreLabel.Name = "searchByGenreLabel";
            this.searchByGenreLabel.Size = new System.Drawing.Size(102, 15);
            this.searchByGenreLabel.TabIndex = 10;
            this.searchByGenreLabel.Text = "Search By &Genre:";
            // 
            // genresComboBox
            // 
            this.genresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(119, 147);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(255, 23);
            this.genresComboBox.TabIndex = 11;
            // 
            // searchByBookTypeLabel
            // 
            this.searchByBookTypeLabel.AutoSize = true;
            this.searchByBookTypeLabel.Location = new System.Drawing.Point(11, 186);
            this.searchByBookTypeLabel.Name = "searchByBookTypeLabel";
            this.searchByBookTypeLabel.Size = new System.Drawing.Size(125, 15);
            this.searchByBookTypeLabel.TabIndex = 12;
            this.searchByBookTypeLabel.Text = "Search By Book Ty&pe:";
            // 
            // bookTypeCombobox
            // 
            this.bookTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCombobox.FormattingEnabled = true;
            this.bookTypeCombobox.Location = new System.Drawing.Point(142, 183);
            this.bookTypeCombobox.Name = "bookTypeCombobox";
            this.bookTypeCombobox.Size = new System.Drawing.Size(232, 23);
            this.bookTypeCombobox.TabIndex = 13;
            // 
            // searchByOwnerUsernameLabel
            // 
            this.searchByOwnerUsernameLabel.AutoSize = true;
            this.searchByOwnerUsernameLabel.Location = new System.Drawing.Point(11, 222);
            this.searchByOwnerUsernameLabel.Name = "searchByOwnerUsernameLabel";
            this.searchByOwnerUsernameLabel.Size = new System.Drawing.Size(174, 15);
            this.searchByOwnerUsernameLabel.TabIndex = 14;
            this.searchByOwnerUsernameLabel.Text = "Search By O&wner\'s Username:";
            // 
            // searchByOwnerUsernameTextbox
            // 
            this.searchByOwnerUsernameTextbox.Location = new System.Drawing.Point(191, 219);
            this.searchByOwnerUsernameTextbox.MaxLength = 20;
            this.searchByOwnerUsernameTextbox.Name = "searchByOwnerUsernameTextbox";
            this.searchByOwnerUsernameTextbox.Size = new System.Drawing.Size(183, 21);
            this.searchByOwnerUsernameTextbox.TabIndex = 15;
            // 
            // pageLabel
            // 
            this.pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(93, 281);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(39, 15);
            this.pageLabel.TabIndex = 23;
            this.pageLabel.Text = "Page:";
            // 
            // pageIndexLabel
            // 
            this.pageIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageIndexLabel.AutoSize = true;
            this.pageIndexLabel.Location = new System.Drawing.Point(159, 281);
            this.pageIndexLabel.Name = "pageIndexLabel";
            this.pageIndexLabel.Size = new System.Drawing.Size(15, 15);
            this.pageIndexLabel.TabIndex = 24;
            this.pageIndexLabel.Text = "X";
            // 
            // pageDeviderLabel
            // 
            this.pageDeviderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageDeviderLabel.AutoSize = true;
            this.pageDeviderLabel.Location = new System.Drawing.Point(195, 281);
            this.pageDeviderLabel.Name = "pageDeviderLabel";
            this.pageDeviderLabel.Size = new System.Drawing.Size(10, 15);
            this.pageDeviderLabel.TabIndex = 25;
            this.pageDeviderLabel.Text = ":";
            // 
            // pageLastPageLabel
            // 
            this.pageLastPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageLastPageLabel.AutoSize = true;
            this.pageLastPageLabel.Location = new System.Drawing.Point(227, 281);
            this.pageLastPageLabel.Name = "pageLastPageLabel";
            this.pageLastPageLabel.Size = new System.Drawing.Size(15, 15);
            this.pageLastPageLabel.TabIndex = 26;
            this.pageLastPageLabel.Text = "X";
            // 
            // firstPageButton
            // 
            this.firstPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firstPageButton.Location = new System.Drawing.Point(12, 307);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(75, 25);
            this.firstPageButton.TabIndex = 18;
            this.firstPageButton.Text = "First Page";
            this.firstPageButton.UseVisualStyleBackColor = true;
            this.firstPageButton.Click += new System.EventHandler(this.PageButton_Click);
            this.firstPageButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.firstPageButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lastPageButton
            // 
            this.lastPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastPageButton.Location = new System.Drawing.Point(299, 307);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(75, 25);
            this.lastPageButton.TabIndex = 21;
            this.lastPageButton.Text = "Last Page";
            this.lastPageButton.UseVisualStyleBackColor = true;
            this.lastPageButton.Click += new System.EventHandler(this.PageButton_Click);
            this.lastPageButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.lastPageButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextPageButton.Location = new System.Drawing.Point(210, 307);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 25);
            this.nextPageButton.TabIndex = 20;
            this.nextPageButton.Text = "Next Page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.PageButton_Click);
            this.nextPageButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.nextPageButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousPageButton.Location = new System.Drawing.Point(96, 307);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(100, 25);
            this.previousPageButton.TabIndex = 19;
            this.previousPageButton.Text = "Previous Page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.PageButton_Click);
            this.previousPageButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.previousPageButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(142, 246);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(764, 371);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.lastPageButton);
            this.Controls.Add(this.firstPageButton);
            this.Controls.Add(this.pageLastPageLabel);
            this.Controls.Add(this.pageDeviderLabel);
            this.Controls.Add(this.pageIndexLabel);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.searchByOwnerUsernameTextbox);
            this.Controls.Add(this.searchByOwnerUsernameLabel);
            this.Controls.Add(this.bookTypeCombobox);
            this.Controls.Add(this.searchByBookTypeLabel);
            this.Controls.Add(this.genresComboBox);
            this.Controls.Add(this.searchByGenreLabel);
            this.Controls.Add(this.yearToTextbox);
            this.Controls.Add(this.yearToLabel);
            this.Controls.Add(this.yearFromLabel);
            this.Controls.Add(this.searchByYearLabel);
            this.Controls.Add(this.yearFromTextbox);
            this.Controls.Add(this.searchByAuthorTextbox);
            this.Controls.Add(this.searchByAuthorLabel);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.searchByNameTextbox);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.showAllBooksButton);
            this.Controls.Add(this.displayBooksListbox);
            this.Controls.Add(this.messageStatusStrip);
            this.Controls.Add(this.userOptionsMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.userOptionsMenuStrip;
            this.MinimumSize = new System.Drawing.Size(580, 410);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Library Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.userOptionsMenuStrip.ResumeLayout(false);
            this.userOptionsMenuStrip.PerformLayout();
            this.messageStatusStrip.ResumeLayout(false);
            this.messageStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bool IsHidden;
        private System.Windows.Forms.ToolStripMenuItem toolStripBooksOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettingOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdminOption;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip userOptionsMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel userWelcomeMessageLabel;
        private System.Windows.Forms.StatusStrip messageStatusStrip;
        private System.Windows.Forms.ListBox displayBooksListbox;
        private System.Windows.Forms.Button showAllBooksButton;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.TextBox searchByNameTextbox;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Label searchByAuthorLabel;
        private System.Windows.Forms.TextBox searchByAuthorTextbox;
        private System.Windows.Forms.TextBox yearFromTextbox;
        private System.Windows.Forms.Label searchByYearLabel;
        private System.Windows.Forms.Label yearFromLabel;
        private System.Windows.Forms.Label yearToLabel;
        private System.Windows.Forms.TextBox yearToTextbox;
        private System.Windows.Forms.Label searchByGenreLabel;
        private System.Windows.Forms.ComboBox genresComboBox;
        private System.Windows.Forms.Label searchByBookTypeLabel;
        private System.Windows.Forms.ComboBox bookTypeCombobox;
        private System.Windows.Forms.Label searchByOwnerUsernameLabel;
        private System.Windows.Forms.TextBox searchByOwnerUsernameTextbox;
        private System.Windows.Forms.ToolStripMenuItem toolStripBookAddItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBookManageItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBookOwnItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserUpdateItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserChangePassItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripColorSettingItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripLogoutItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripExitItem;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label pageIndexLabel;
        private System.Windows.Forms.Label pageDeviderLabel;
        private System.Windows.Forms.Label pageLastPageLabel;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdminUsersItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdminBooksItem;
        private System.Windows.Forms.Button resetButton;
    }
}