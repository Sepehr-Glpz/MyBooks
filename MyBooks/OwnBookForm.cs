using System.Linq;
namespace MyApplication
{
    public partial class OwnBookForm : Infrastructure.BaseForm
    {
        public OwnBookForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            searchByNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            searchByNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            searchButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            searchButton.ForeColor = Infrastructure.Utility.FormTextColor;
            ownButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            ownButton.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors()

        private Models.DatabaseContext databaseContext { get; set; }

        private void displayBooks()
        {
            try
            {
                databaseContext = new Models.DatabaseContext();
                var books = databaseContext.Books
                    .Where(current => current.OwnerUserId == null)
                    .OrderBy(current => current.BookName)
                    .ToList();
                displayBookListbox.DataSource = books;
                displayBookListbox.DisplayMember = nameof(Models.Book.ListDisplayName);
                displayBookListbox.ValueMember = nameof(Models.Book.BookName);
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
                }
            }
        }
        private void displayBooks(string name)
        {
            try
            {
                databaseContext = new Models.DatabaseContext();
                var books = databaseContext.Books
                    .Where(current => current.BookName.Contains(name))
                    .ToList();
                displayBookListbox.DataSource = books;
                displayBookListbox.DisplayMember = nameof(Models.Book.ListDisplayName);
                displayBookListbox.ValueMember = nameof(Models.Book.BookName);
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
                }
            }
        }


        private void OwnBookForm_Load(object sender, System.EventArgs e)
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
                        displayBookListbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
                default:
                    {
                        RightToLeftLayout = false;
                        RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
            }

            this.UpdateFormColors();

            #region FormLanguageSetting
            this.Text = Resources.OwnBookForm.FormText;

            searchByNameLabel.Text = Resources.OwnBookForm.SearchByNameLabelText;

            searchButton.Text = Resources.OwnBookForm.SearchButtonText;

            ownButton.Text = Resources.OwnBookForm.OwnButtonText;

            returnButton.Text = Resources.OwnBookForm.ReturnButtonText;

            #endregion /FormLanguageSetting

            this.displayBookListbox.DataSource = null;
            this.displayBooks();

        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            searchByNameTextbox.Text = searchByNameTextbox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchByNameTextbox.Text) == false)
            {
                displayBooks(searchByNameTextbox.Text);
            }
            else
            {
                displayBooks();
            }
        }

        private void OwnBookForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            if (databaseContext != null)
            {
                databaseContext.Dispose();
                databaseContext = null;
            }

        }

        private void OwnButton_Click(object sender, System.EventArgs e)
        {
            var selectedBook = displayBookListbox.SelectedItem as Models.Book;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var wantedBook = databaseContext.Books
                    .Where(current => current.Id == selectedBook.Id)
                    .FirstOrDefault();
                if (wantedBook.OwnerUserId != null)
                {
                    searchByNameTextbox.Text = string.Empty;
                    displayBooks();
                    return;
                }
                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.OwnBookForm.BookOwnMessage,
                        caption: Resources.OwnBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.OwnBookForm.BookOwnMessage,
                        caption: Resources.OwnBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                var UpdatedUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                wantedBook.OwnerUser = UpdatedUser;
                wantedBook.OwnerUserId = UpdatedUser.Id;
                UpdatedUser.Books.Add(wantedBook);
                databaseContext.SaveChanges();
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.OwnBookForm.BookOwnedMessage,
                        caption: Resources.OwnBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.OwnBookForm.BookOwnedMessage,
                        caption: Resources.OwnBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                searchByNameTextbox.Text = string.Empty;
                displayBooks();
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
                }
            }

        }

        private void DisplayBookListbox_DoubleClick(object sender, System.EventArgs e)
        {
            if (displayBookListbox.SelectedItem is Models.Book selectedBook)
            {
                DisplayBookForm displayBookForm = new DisplayBookForm()
                {
                    SelectedBook = selectedBook,
                    FatherForm = this,
                    TopMost = true,
                };
                this.Enabled = false;
                displayBookForm.Show();
            }
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
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
    }
}
