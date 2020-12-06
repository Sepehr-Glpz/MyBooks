using System.Linq;
namespace MyApplication
{
    public partial class ManageBookForm : Infrastructure.BaseForm
    {
        public ManageBookForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            bookNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            writerNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            writerNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            yearLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            yearLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            genreLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            genreLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            bookTypeLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookTypeLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            descriptionLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            descriptionLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            saveButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            saveButton.ForeColor = Infrastructure.Utility.FormTextColor;
            deleteButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            deleteButton.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors()

        private void DisplayOwnedBooks()
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var ownedBooks = databaseContext.Books
                    .Where(current => current.OwnerUserId == Infrastructure.Utility.AuthenticatedUser.Id)
                    .OrderBy(current => current.BookName)
                    .ToList();
                userBooksListbox.DataSource = ownedBooks;
                userBooksListbox.DisplayMember = nameof(Models.Book.ListDisplayName);
                userBooksListbox.ValueMember = nameof(Models.Book.Id);
                var selectedBook = userBooksListbox.SelectedItem as Models.Book;
                bookNameTextbox.Text = selectedBook.BookName;
                writerNameTextbox.Text = selectedBook.WriterName;
                yearTextbox.Text = selectedBook.PublishYear.ToString();
                genreCombobox.SelectedIndex = 
                    genreCombobox.FindStringExact(System.Enum.GetName(typeof(Models.BookGenres), selectedBook.Genre));
                bookTypeCombobox.SelectedIndex =
                    bookTypeCombobox.FindStringExact(System.Enum.GetName(typeof(Models.BookType), selectedBook.BookType));
                descriptionTextbox.Text = selectedBook.Description;
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


        private void ManageBookForm_Load(object sender, System.EventArgs e)
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
                        genreCombobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        bookTypeCombobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        userBooksListbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
                default:
                    {
                        RightToLeftLayout = false;
                        RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
            }

            #region Form Language Setting
            this.Text = Resources.ManageBookForm.FormText;

            bookNameLabel.Text = Resources.ManageBookForm.BookNameLabelText;

            writerNameLabel.Text = Resources.ManageBookForm.WriterNameLabelText;

            yearLabel.Text = Resources.ManageBookForm.YearLabelText;

            genreLabel.Text = Resources.ManageBookForm.GenreLabelText;

            bookTypeLabel.Text = Resources.ManageBookForm.BookTypeLabelText;

            descriptionLabel.Text = Resources.ManageBookForm.DescriptionLabelText;

            saveButton.Text = Resources.ManageBookForm.SaveButtonText;

            deleteButton.Text = Resources.ManageBookForm.DeleteButtonText;

            returnButton.Text = Resources.ManageBookForm.ReturnButtonText;

            #endregion /Form Language Setting

            this.UpdateFormColors();
            genreCombobox.DataSource = System.Enum.GetNames(typeof(Models.BookGenres)).ToList();
            bookTypeCombobox.DataSource = System.Enum.GetNames(typeof(Models.BookType)).ToList();
            this.DisplayOwnedBooks();

        }
        private void ManageBookForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            this.Dispose();
        }

        private void YearTextbox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true;
            }
        }
    }
}
