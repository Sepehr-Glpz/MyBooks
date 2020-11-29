using System.Linq;
namespace MyApplication
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsHidden = false;
            CurrentBooks = new System.Collections.Generic.List<Models.Book>();
        }

        public new void Show()
        {
            base.Show();
            IsHidden = false;
            this.CenterToScreen();
        }
        public new void Hide()
        {
            base.Hide();
            IsHidden = true;
        }

        protected int PageSize { get; set; }

        protected int PageIndex { get; set; }

        private System.Collections.Generic.List<Models.Book> CurrentBooks { get; set; }

        private Models.DatabaseContext databaseContext;

        public void UpdateForm()
        {
            this.toolStripAdminOption.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            this.toolStripAdminOption.Enabled = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            string usersFullname = Infrastructure.Utility.AuthenticatedUser.DisplayFullName;
            string usersUsername = Infrastructure.Utility.AuthenticatedUser.Username;
            string result = string.Format(Resources.MainForm.UserWelcomeMessageText, usersFullname, usersUsername);
            this.userWelcomeMessageLabel.Text = result;
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            this.toolStripBooksOption.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripBookAddItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripBookManageItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripBookOwnItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripUserOption.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripUserUpdateItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripUserChangePassItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripSettingOption.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripColorSettingItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripAdminOption.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripAdminUsersItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripAdminBooksItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.exitToolStripMenuItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripLogoutItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.toolStripExitItem.ForeColor = Infrastructure.Utility.FormTextColor;
            this.userWelcomeMessageLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchByAuthorLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByAuthorLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchByYearLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByYearLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.yearFromLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.yearFromLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.yearToLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.yearToLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchByGenreLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByGenreLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchByBookTypeLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByBookTypeLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchByOwnerUsernameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchByOwnerUsernameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.searchBookButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.searchBookButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.pageLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.pageLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.pageIndexLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.pageIndexLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.pageDeviderLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.pageDeviderLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.pageLastPageLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.pageLastPageLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.showAllBooksButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.showAllBooksButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.firstPageButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.firstPageButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.previousPageButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.previousPageButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.nextPageButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.nextPageButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.lastPageButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.lastPageButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
        }
        #endregion /UpdateFormColors()

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            string culture =
                System.Threading.Thread.CurrentThread.CurrentUICulture.Name.Substring(startIndex: 0, 2);
            switch (culture.ToUpper())
            {
                case "FA":
                case "AR":
                    {
                        RightToLeftLayout = true;
                        RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        displayBooksListbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        genresComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        bookTypeCombobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
                default:
                    {
                        RightToLeftLayout = false;
                        RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
            }

            this.UpdateForm();

            this.UpdateFormColors();

            var genreList = System.Enum.GetNames(typeof(Models.BookGenres)).ToList();
            genreList.Insert(0, string.Empty);
            genresComboBox.DataSource = genreList;

            var bookTypeList = System.Enum.GetNames(typeof(Models.BookType)).ToList();
            bookTypeList.Insert(0, string.Empty);
            bookTypeCombobox.DataSource = bookTypeList;

            #region Form Language Setting

            this.Text = Resources.MainForm.MainFormText;

            this.toolStripBooksOption.Text = Resources.MainForm.ToolStripBooksOptionText;

            this.toolStripBookAddItem.Text = Resources.MainForm.ToolStripBookAddItemText;

            this.toolStripBookManageItem.Text = Resources.MainForm.ToolStripBookManageItemText;

            this.toolStripBookOwnItem.Text = Resources.MainForm.ToolStripBookOwnItemText;

            this.toolStripUserOption.Text = Resources.MainForm.ToolStripUserOptionText;

            this.toolStripUserUpdateItem.Text = Resources.MainForm.ToolStripUserUpdateItemText;

            this.toolStripUserChangePassItem.Text = Resources.MainForm.ToolStripUserChangePassItemText;

            this.toolStripSettingOption.Text = Resources.MainForm.ToolStripSettingOptionText;

            this.toolStripColorSettingItem.Text = Resources.MainForm.ToolStripColorSettingItem;

            this.toolStripAdminOption.Text = Resources.MainForm.ToolStripAdminOptionText;

            this.toolStripAdminUsersItem.Text = Resources.MainForm.ToolStripAdminUsersItemText;

            this.toolStripAdminBooksItem.Text = Resources.MainForm.ToolStripAdminBooksItemText;

            this.exitToolStripMenuItem.Text = Resources.MainForm.ExitToolStripMenuItemText;

            this.toolStripLogoutItem.Text = Resources.MainForm.ToolStripLogoutItemText;

            this.toolStripExitItem.Text = Resources.MainForm.ToolStripExitItemText;

            this.searchByNameLabel.Text = Resources.MainForm.SearchByNameLabelText;

            this.searchByAuthorLabel.Text = Resources.MainForm.SearchByAuthorLabelText;

            this.searchByYearLabel.Text = Resources.MainForm.SearchByYearLabelText;

            this.yearFromLabel.Text = Resources.MainForm.YearFromLabelText;

            this.yearToLabel.Text = Resources.MainForm.YearToLabelText;

            this.searchByGenreLabel.Text = Resources.MainForm.SearchByGenreLabelText;

            this.searchByBookTypeLabel.Text = Resources.MainForm.SearchByBookTypeLabelText;

            this.searchByOwnerUsernameLabel.Text = Resources.MainForm.SearchByOwnerUsernameLabelText;

            this.searchBookButton.Text = Resources.MainForm.SearchBookButtonText;

            this.pageLabel.Text = Resources.MainForm.PageLabelText;

            this.showAllBooksButton.Text = Resources.MainForm.ShowAllBooksButtonText;

            this.firstPageButton.Text = Resources.MainForm.FirstPageButtonText;

            this.previousPageButton.Text = Resources.MainForm.PreviousPageButtonText;

            this.nextPageButton.Text = Resources.MainForm.NextPageButtonText;

            this.lastPageButton.Text = Resources.MainForm.LastPageButtonText;

            this.resetButton.Text = Resources.MainForm.ResetButtonText;

            #endregion /Form Language Setting

            PageIndex = 0;

        }

        private void YearTextbox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true;
            }
        }

        private void ShowAllBooksButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                databaseContext = new Models.DatabaseContext();

                this.CurrentBooks = databaseContext.Books
                    .ToList();

                DisplayBooks(CurrentBooks);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Unexpected Error:{ex.Message}",
                    caption: "ERROR", buttons: System.Windows.Forms.MessageBoxButtons.OK,
                    icon: System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        private void DisplayBooks(System.Collections.Generic.List<Models.Book> Books)
        {
            PageSize = (displayBooksListbox.Height / displayBooksListbox.ItemHeight);

            pageIndexLabel.Text = (PageIndex + 1).ToString();
            pageLastPageLabel.Text = (GetLastPageIndex(Books) + 1).ToString();

            var books = Books
                .OrderBy(current => current.BookName)
                .Skip(PageIndex * PageSize)
                .Take(PageSize)
                .ToList();

            displayBooksListbox.DataSource = null;
            displayBooksListbox.DisplayMember = nameof(Models.Book.ListDisplayName);
            displayBooksListbox.ValueMember = nameof(Models.Book.Id);
            displayBooksListbox.DataSource = books;

        }

        private int GetCountryCount(System.Collections.Generic.List<Models.Book> Books)
        {
            int count =
                Books
                .Count();

            return count;
        }

        private int GetLastPageIndex(System.Collections.Generic.List<Models.Book> Books)
        {
            int count =
                GetCountryCount(Books);

            if (count % PageSize == 0)
            {
                return (count / PageSize) - 1;
            }
            else
            {
                return count / PageSize;
            }
        }

        private void PageButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
            switch (currentButton.Name)
            {
                case "firstPageButton":
                    {
                        if (CurrentBooks.Count != 0)
                        {
                            PageIndex = 0;
                            DisplayBooks(CurrentBooks);
                        }
                        break;
                    }
                case "previousPageButton":
                    {
                        if (CurrentBooks.Count != 0)
                        {
                            if (PageIndex > 0)
                            {
                                PageIndex--;
                                DisplayBooks(CurrentBooks);
                            }
                        }
                        break;
                    }
                case "nextPageButton":
                    {
                        if (CurrentBooks.Count != 0)
                        {
                            if (PageIndex < GetLastPageIndex(CurrentBooks))
                            {
                                PageIndex++;
                                DisplayBooks(CurrentBooks);
                            }
                        }

                        break;
                    }
                case "lastPageButton":
                    {
                        if (CurrentBooks.Count != 0)
                        {
                            PageIndex = GetLastPageIndex(CurrentBooks);
                            DisplayBooks(CurrentBooks);
                        }

                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        private void SearchBookButton_Click(object sender, System.EventArgs e)
        {
            searchByNameTextbox.Text = searchByNameTextbox.Text.Trim();
            while (searchByNameTextbox.Text.Contains("  ") == true)
            {
                searchByNameTextbox.Text = searchByNameTextbox.Text.Replace("  ", " ");
            }
            searchByAuthorTextbox.Text = searchByAuthorTextbox.Text.Trim();
            while (searchByAuthorTextbox.Text.Contains("  ") == true)
            {
                searchByAuthorTextbox.Text = searchByAuthorTextbox.Text.Replace("  ", " ");
            }
            foreach (char item in yearFromTextbox.Text)
            {
                if (char.IsLetter(item) == true)
                {
                    yearFromTextbox.Text = string.Empty;
                    break;
                }
            }
            foreach (char item in yearToTextbox.Text)
            {
                if (char.IsLetter(item))
                {
                    yearToTextbox.Text = string.Empty;
                    break;
                }
            }
            searchByOwnerUsernameTextbox.Text = searchByOwnerUsernameTextbox.Text.Trim();
            while (searchByOwnerUsernameTextbox.Text.Contains("  ") == true)
            {
                searchByOwnerUsernameTextbox.Text = searchByOwnerUsernameTextbox.Text.Replace("  ", " ");
            }

            try
            {
                databaseContext = new Models.DatabaseContext();

                var data = databaseContext.Books.AsQueryable();

                if (string.IsNullOrWhiteSpace(searchByOwnerUsernameTextbox.Text) == false)
                {
                    data = databaseContext.Books
                        .Where(current => current.OwnerUser.Username.ToLower()
                        .Contains(searchByOwnerUsernameTextbox.Text.ToLower()))
                        .AsQueryable();
                }
                if (string.IsNullOrWhiteSpace(searchByNameTextbox.Text) == false)
                {
                    data = data.Where(current => current.BookName.ToLower()
                    .Contains(searchByNameTextbox.Text.ToLower()));
                }
                if (string.IsNullOrWhiteSpace(yearFromTextbox.Text) == false)
                {
                    int yearFrom = System.Convert.ToInt32(yearFromTextbox.Text);
                    data = data.Where(current => current.PublishYear >= yearFrom);
                }
                if (string.IsNullOrWhiteSpace(yearToTextbox.Text) == false && yearToTextbox.Text != yearFromTextbox.Text)
                {
                    int yearTo = System.Convert.ToInt32(yearToTextbox.Text);
                    data = data.Where(current => current.PublishYear <= yearTo);
                }
                string comboboxGenre = genresComboBox.SelectedItem as string;
                if (string.IsNullOrEmpty(comboboxGenre) == false)
                {
                    Models.BookGenres selectedGenre =
                        (Models.BookGenres)System.Enum.Parse(typeof(Models.BookGenres), comboboxGenre);
                    data = data.Where(current => current.Genre == selectedGenre);
                }
                string comboboxBookType = bookTypeCombobox.SelectedItem as string;
                if (string.IsNullOrEmpty(comboboxBookType) == false)
                {
                    Models.BookType selectedType =
                        (Models.BookType)System.Enum.Parse(typeof(Models.BookType), comboboxBookType);
                    data = data.Where(current => current.BookType == selectedType);
                }

                data = data.OrderBy(current => current.BookName);

                CurrentBooks = data.ToList();

                PageIndex = 0;

                DisplayBooks(CurrentBooks);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Unexpected Error:{ex.Message}",
                    caption: "ERROR", buttons: System.Windows.Forms.MessageBoxButtons.OK,
                    icon: System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            searchByNameTextbox.Text = string.Empty;
            searchByAuthorTextbox.Text = string.Empty;
            searchByOwnerUsernameTextbox.Text = string.Empty;
            genresComboBox.SelectedItem = null;
            bookTypeCombobox.SelectedItem = null;
            yearFromTextbox.Text = string.Empty;
            yearToTextbox.Text = string.Empty;
            pageIndexLabel.Text = "0";
            pageLastPageLabel.Text = "0";
            displayBooksListbox.DataSource = null;
            searchByNameTextbox.Focus();
        }

        private void Button_MouseEnter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
            currentButton.BackColor = System.Drawing.Color.LightBlue;
        }

        private void Button_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
            currentButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (IsHidden == true)
            {
                return;
            }
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(text: Resources.MainForm.FormClosingMessage,
                    caption: Resources.MainForm.FormClosingMessageCaption,
                    buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                    icon: System.Windows.Forms.MessageBoxIcon.Question,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
            }
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                result =
                     System.Windows.Forms.MessageBox.Show(text: Resources.MainForm.FormClosingMessage,
                     caption: Resources.MainForm.FormClosingMessageCaption,
                     buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                     icon: System.Windows.Forms.MessageBoxIcon.Question,
                     defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                     options: System.Windows.Forms.MessageBoxOptions.RightAlign
                     | System.Windows.Forms.MessageBoxOptions.RtlReading);
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.FormClosing -= MainForm_FormClosing;
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
                System.Windows.Forms.Application.Exit();
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }

        }
        private AddBookForm addBookForm;
        private void ToolStripBookAddItem_Click(object sender, System.EventArgs e)
        {
            if (addBookForm == null || addBookForm.IsDisposed == true)
            {
                addBookForm = new AddBookForm();
            }
            addBookForm.Show();
            this.Enabled = false;
        }
    }
}
