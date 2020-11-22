﻿
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
            this.searchTextboxLabel = new System.Windows.Forms.Label();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // toolStripBookManageItem
            // 
            this.toolStripBookManageItem.Name = "toolStripBookManageItem";
            this.toolStripBookManageItem.Size = new System.Drawing.Size(186, 22);
            this.toolStripBookManageItem.Text = "Manage Your Books";
            // 
            // toolStripBookOwnItem
            // 
            this.toolStripBookOwnItem.Name = "toolStripBookOwnItem";
            this.toolStripBookOwnItem.Size = new System.Drawing.Size(186, 22);
            this.toolStripBookOwnItem.Text = "Own Unwanted Book";
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
            this.toolStripColorSettingItem.Size = new System.Drawing.Size(180, 22);
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
            this.toolStripAdminUsersItem.Size = new System.Drawing.Size(180, 22);
            this.toolStripAdminUsersItem.Text = "Manage Users";
            // 
            // toolStripAdminBooksItem
            // 
            this.toolStripAdminBooksItem.Name = "toolStripAdminBooksItem";
            this.toolStripAdminBooksItem.Size = new System.Drawing.Size(180, 22);
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
            this.toolStripLogoutItem.Size = new System.Drawing.Size(180, 22);
            this.toolStripLogoutItem.Text = "Log Out";
            // 
            // toolStripExitItem
            // 
            this.toolStripExitItem.Name = "toolStripExitItem";
            this.toolStripExitItem.Size = new System.Drawing.Size(180, 22);
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
            this.userOptionsMenuStrip.TabIndex = 2;
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
            this.messageStatusStrip.Location = new System.Drawing.Point(0, 319);
            this.messageStatusStrip.Name = "messageStatusStrip";
            this.messageStatusStrip.Size = new System.Drawing.Size(764, 22);
            this.messageStatusStrip.TabIndex = 1;
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
            this.displayBooksListbox.Size = new System.Drawing.Size(384, 289);
            this.displayBooksListbox.TabIndex = 3;
            // 
            // showAllBooksButton
            // 
            this.showAllBooksButton.Location = new System.Drawing.Point(274, 246);
            this.showAllBooksButton.Name = "showAllBooksButton";
            this.showAllBooksButton.Size = new System.Drawing.Size(100, 25);
            this.showAllBooksButton.TabIndex = 5;
            this.showAllBooksButton.Text = "Show A&ll Books";
            this.showAllBooksButton.UseVisualStyleBackColor = true;
            // 
            // searchTextboxLabel
            // 
            this.searchTextboxLabel.AutoSize = true;
            this.searchTextboxLabel.Location = new System.Drawing.Point(11, 38);
            this.searchTextboxLabel.Name = "searchTextboxLabel";
            this.searchTextboxLabel.Size = new System.Drawing.Size(102, 15);
            this.searchTextboxLabel.TabIndex = 6;
            this.searchTextboxLabel.Text = "Search By &Name:";
            // 
            // searchByNameTextbox
            // 
            this.searchByNameTextbox.Location = new System.Drawing.Point(120, 35);
            this.searchByNameTextbox.MaxLength = 25;
            this.searchByNameTextbox.Name = "searchByNameTextbox";
            this.searchByNameTextbox.Size = new System.Drawing.Size(254, 21);
            this.searchByNameTextbox.TabIndex = 7;
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(12, 246);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(75, 25);
            this.searchBookButton.TabIndex = 8;
            this.searchBookButton.Text = "&Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            // 
            // searchByAuthorLabel
            // 
            this.searchByAuthorLabel.AutoSize = true;
            this.searchByAuthorLabel.Location = new System.Drawing.Point(11, 78);
            this.searchByAuthorLabel.Name = "searchByAuthorLabel";
            this.searchByAuthorLabel.Size = new System.Drawing.Size(103, 15);
            this.searchByAuthorLabel.TabIndex = 9;
            this.searchByAuthorLabel.Text = "Search By Aut&hor:";
            // 
            // searchByAuthorTextbox
            // 
            this.searchByAuthorTextbox.Location = new System.Drawing.Point(120, 75);
            this.searchByAuthorTextbox.MaxLength = 20;
            this.searchByAuthorTextbox.Name = "searchByAuthorTextbox";
            this.searchByAuthorTextbox.Size = new System.Drawing.Size(254, 21);
            this.searchByAuthorTextbox.TabIndex = 10;
            // 
            // yearFromTextbox
            // 
            this.yearFromTextbox.Location = new System.Drawing.Point(162, 111);
            this.yearFromTextbox.MaxLength = 4;
            this.yearFromTextbox.Name = "yearFromTextbox";
            this.yearFromTextbox.Size = new System.Drawing.Size(80, 21);
            this.yearFromTextbox.TabIndex = 11;
            // 
            // searchByYearLabel
            // 
            this.searchByYearLabel.AutoSize = true;
            this.searchByYearLabel.Location = new System.Drawing.Point(11, 114);
            this.searchByYearLabel.Name = "searchByYearLabel";
            this.searchByYearLabel.Size = new System.Drawing.Size(93, 15);
            this.searchByYearLabel.TabIndex = 12;
            this.searchByYearLabel.Text = "Search By &Year:";
            // 
            // yearFromLabel
            // 
            this.yearFromLabel.AutoSize = true;
            this.yearFromLabel.Location = new System.Drawing.Point(117, 114);
            this.yearFromLabel.Name = "yearFromLabel";
            this.yearFromLabel.Size = new System.Drawing.Size(39, 15);
            this.yearFromLabel.TabIndex = 13;
            this.yearFromLabel.Text = "&From:";
            // 
            // yearToLabel
            // 
            this.yearToLabel.AutoSize = true;
            this.yearToLabel.Location = new System.Drawing.Point(248, 114);
            this.yearToLabel.Name = "yearToLabel";
            this.yearToLabel.Size = new System.Drawing.Size(24, 15);
            this.yearToLabel.TabIndex = 14;
            this.yearToLabel.Text = "&To:";
            // 
            // yearToTextbox
            // 
            this.yearToTextbox.Location = new System.Drawing.Point(278, 111);
            this.yearToTextbox.MaxLength = 5;
            this.yearToTextbox.Name = "yearToTextbox";
            this.yearToTextbox.Size = new System.Drawing.Size(96, 21);
            this.yearToTextbox.TabIndex = 15;
            // 
            // searchByGenreLabel
            // 
            this.searchByGenreLabel.AutoSize = true;
            this.searchByGenreLabel.Location = new System.Drawing.Point(11, 150);
            this.searchByGenreLabel.Name = "searchByGenreLabel";
            this.searchByGenreLabel.Size = new System.Drawing.Size(102, 15);
            this.searchByGenreLabel.TabIndex = 16;
            this.searchByGenreLabel.Text = "Search By &Genre:";
            // 
            // genresComboBox
            // 
            this.genresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(119, 147);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(255, 23);
            this.genresComboBox.Sorted = true;
            this.genresComboBox.TabIndex = 17;
            // 
            // searchByBookTypeLabel
            // 
            this.searchByBookTypeLabel.AutoSize = true;
            this.searchByBookTypeLabel.Location = new System.Drawing.Point(11, 186);
            this.searchByBookTypeLabel.Name = "searchByBookTypeLabel";
            this.searchByBookTypeLabel.Size = new System.Drawing.Size(125, 15);
            this.searchByBookTypeLabel.TabIndex = 18;
            this.searchByBookTypeLabel.Text = "Search By Book Ty&pe:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 19;
            // 
            // searchByOwnerUsernameLabel
            // 
            this.searchByOwnerUsernameLabel.AutoSize = true;
            this.searchByOwnerUsernameLabel.Location = new System.Drawing.Point(11, 222);
            this.searchByOwnerUsernameLabel.Name = "searchByOwnerUsernameLabel";
            this.searchByOwnerUsernameLabel.Size = new System.Drawing.Size(174, 15);
            this.searchByOwnerUsernameLabel.TabIndex = 20;
            this.searchByOwnerUsernameLabel.Text = "Search By O&wner\'s Username:";
            // 
            // searchByOwnerUsernameTextbox
            // 
            this.searchByOwnerUsernameTextbox.Location = new System.Drawing.Point(191, 219);
            this.searchByOwnerUsernameTextbox.MaxLength = 20;
            this.searchByOwnerUsernameTextbox.Name = "searchByOwnerUsernameTextbox";
            this.searchByOwnerUsernameTextbox.Size = new System.Drawing.Size(183, 21);
            this.searchByOwnerUsernameTextbox.TabIndex = 21;
            // 
            // pageLabel
            // 
            this.pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(93, 251);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(39, 15);
            this.pageLabel.TabIndex = 23;
            this.pageLabel.Text = "Page:";
            // 
            // pageIndexLabel
            // 
            this.pageIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageIndexLabel.AutoSize = true;
            this.pageIndexLabel.Location = new System.Drawing.Point(159, 251);
            this.pageIndexLabel.Name = "pageIndexLabel";
            this.pageIndexLabel.Size = new System.Drawing.Size(15, 15);
            this.pageIndexLabel.TabIndex = 24;
            this.pageIndexLabel.Text = "X";
            // 
            // pageDeviderLabel
            // 
            this.pageDeviderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageDeviderLabel.AutoSize = true;
            this.pageDeviderLabel.Location = new System.Drawing.Point(195, 251);
            this.pageDeviderLabel.Name = "pageDeviderLabel";
            this.pageDeviderLabel.Size = new System.Drawing.Size(10, 15);
            this.pageDeviderLabel.TabIndex = 25;
            this.pageDeviderLabel.Text = ":";
            // 
            // pageLastPageLabel
            // 
            this.pageLastPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageLastPageLabel.AutoSize = true;
            this.pageLastPageLabel.Location = new System.Drawing.Point(227, 251);
            this.pageLastPageLabel.Name = "pageLastPageLabel";
            this.pageLastPageLabel.Size = new System.Drawing.Size(15, 15);
            this.pageLastPageLabel.TabIndex = 26;
            this.pageLastPageLabel.Text = "X";
            // 
            // firstPageButton
            // 
            this.firstPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firstPageButton.Location = new System.Drawing.Point(12, 277);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(75, 25);
            this.firstPageButton.TabIndex = 27;
            this.firstPageButton.Text = "First Page";
            this.firstPageButton.UseVisualStyleBackColor = true;
            // 
            // lastPageButton
            // 
            this.lastPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastPageButton.Location = new System.Drawing.Point(299, 277);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(75, 25);
            this.lastPageButton.TabIndex = 28;
            this.lastPageButton.Text = "Last Page";
            this.lastPageButton.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextPageButton.Location = new System.Drawing.Point(210, 277);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 25);
            this.nextPageButton.TabIndex = 29;
            this.nextPageButton.Text = "Next Page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // previousPageButton
            // 
            this.previousPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousPageButton.Location = new System.Drawing.Point(96, 277);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(100, 25);
            this.previousPageButton.TabIndex = 30;
            this.previousPageButton.Text = "Previous Page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(764, 341);
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
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.searchTextboxLabel);
            this.Controls.Add(this.showAllBooksButton);
            this.Controls.Add(this.displayBooksListbox);
            this.Controls.Add(this.messageStatusStrip);
            this.Controls.Add(this.userOptionsMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.userOptionsMenuStrip;
            this.MinimumSize = new System.Drawing.Size(580, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Library Management";
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
        private System.Windows.Forms.Label searchTextboxLabel;
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
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}