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
            this.BackColor = Infrastructure.Utility.FormBackcolor;
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
            disownButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            disownButton.ForeColor = Infrastructure.Utility.FormTextColor;
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
                userBooksListbox.ValueMember = nameof(Models.Book.BookName);
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

            disownButton.Text = Resources.ManageBookForm.DisownButtonText;

            #endregion /Form Language Setting

            this.UpdateFormColors();
            genreCombobox.DataSource = System.Enum.GetNames(typeof(Models.BookGenres)).ToList();
            bookTypeCombobox.DataSource = System.Enum.GetNames(typeof(Models.BookType)).ToList();
            this.DisplayOwnedBooks();

        }
        private void ManageBookForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            Infrastructure.Utility.MainForm.ResetForm();
            this.Dispose();
        }

        private void YearTextbox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true;
            }
        }

        private void UserBooksListbox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedBook = userBooksListbox.SelectedItem as Models.Book;
            bookNameTextbox.Text = selectedBook.BookName;
            writerNameTextbox.Text = selectedBook.WriterName;
            yearTextbox.Text = selectedBook.PublishYear.ToString();
            descriptionTextbox.Text = selectedBook.Description;
            genreCombobox.SelectedIndex =
                genreCombobox.FindStringExact(System.Enum.GetName(typeof(Models.BookGenres), selectedBook.Genre));
            bookTypeCombobox.SelectedIndex =
                bookTypeCombobox.FindStringExact(System.Enum.GetName(typeof(Models.BookType), selectedBook.BookType));
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            bookNameTextbox.Text = bookNameTextbox.Text.Trim();
            while (bookNameTextbox.Text.Contains("  "))
            {
                bookNameTextbox.Text = bookNameTextbox.Text.Replace("  ", " ");
            }
            writerNameTextbox.Text = writerNameTextbox.Text.Trim();
            while (writerNameTextbox.Text.Contains("  "))
            {
                writerNameTextbox.Text = writerNameTextbox.Text.Replace("  ", " ");
            }
            yearTextbox.Text = yearTextbox.Text.Trim();
            foreach (char item in yearTextbox.Text)
            {
                if (char.IsDigit(item) == false)
                {
                    yearTextbox.Text = string.Empty;
                    break;
                }
            }
            string errorMessage = string.Empty;
            Models.Book selectedBook = userBooksListbox.SelectedItem as Models.Book;
            int? selectedYear = null;
            if (string.IsNullOrWhiteSpace(yearTextbox.Text) == false)
            {
                selectedYear = System.Convert.ToInt32(yearTextbox.Text);
            }
            string selectedWriter = null;
            if (string.IsNullOrWhiteSpace(writerNameTextbox.Text) == false)
            {
                selectedWriter = writerNameTextbox.Text;
            }
            string selectedDescription = null;
            if (string.IsNullOrWhiteSpace(descriptionTextbox.Text) == false)
            {
                selectedDescription = descriptionTextbox.Text;
            }
            string selectedGenreString = genreCombobox.SelectedItem as string;
            string selectedTypeString = bookTypeCombobox.SelectedItem as string;
            var selectedGenre =
                (Models.BookGenres)System.Enum.Parse(typeof(Models.BookGenres), selectedGenreString);
            var selectedType =
                (Models.BookType)System.Enum.Parse(typeof(Models.BookType), selectedTypeString);

            if (bookNameTextbox.Text == selectedBook.BookName && selectedWriter == selectedBook.WriterName
                && selectedYear == selectedBook.PublishYear && selectedBook.Genre == selectedGenre
                && selectedBook.BookType == selectedType && selectedBook.Description == selectedDescription)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookNotChangedError,
                        caption: Resources.ManageBookForm.MessageBoxWarningCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookNotChangedError,
                        caption: Resources.ManageBookForm.MessageBoxWarningCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                return;
            }

            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                bool bookexists = databaseContext.Books
                    .Where(current => current.BookName.ToLower() == bookNameTextbox.Text.ToLower())
                    .Where(current => current.BookName.ToLower() != selectedBook.BookName.ToLower())
                    .Any();
                if (bookexists == true)
                {
                    errorMessage += Resources.ManageBookForm.NewBookExistsError;
                    errorMessage += System.Environment.NewLine;
                    bookNameTextbox.Text = selectedBook.BookName;
                }
                if (string.IsNullOrWhiteSpace(bookNameTextbox.Text))
                {
                    errorMessage += Resources.ManageBookForm.EmptyNameError;
                    errorMessage += System.Environment.NewLine;
                    bookNameTextbox.Text = selectedBook.BookName;
                }
                if (bookNameTextbox.Text.Length > 25 || bookNameTextbox.Text.Length < 2)
                {
                    errorMessage += Resources.ManageBookForm.NameLengthError;
                    errorMessage += System.Environment.NewLine;
                    bookNameTextbox.Text = selectedBook.BookName;
                }
                if (string.IsNullOrWhiteSpace(selectedWriter) == false)
                {
                    if (selectedWriter.Length > 20 || selectedWriter.Length < 3)
                    {
                        errorMessage += Resources.ManageBookForm.WriterNameLengthError;
                        errorMessage += System.Environment.NewLine;
                        writerNameTextbox.Text = selectedBook.WriterName;
                    }
                }
                if (selectedYear > 10000 || selectedYear < 0)
                {
                    errorMessage += Resources.ManageBookForm.YearError;
                    errorMessage += System.Environment.NewLine;
                    yearTextbox.Text = selectedBook.PublishYear.ToString();
                }
                if (string.IsNullOrWhiteSpace(selectedDescription) == false
                    && selectedDescription.Length > 1024)
                {
                    errorMessage += Resources.ManageBookForm.DescriptionError;
                    errorMessage += System.Environment.NewLine;
                    descriptionTextbox.Text = selectedBook.Description;
                }
                if (errorMessage != string.Empty)
                {
                    if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: errorMessage,
                            caption: Resources.ManageBookForm.MessageboxErrorCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: errorMessage,
                            caption: Resources.ManageBookForm.MessageboxErrorCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }
                    return;
                }

                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.ChangeBookQuestion,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
                        
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.ChangeBookQuestion,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
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
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var wantedBook = databaseContext.Books
                        .Where(current => current.Id == selectedBook.Id)
                        .FirstOrDefault();
                    wantedBook.BookName = bookNameTextbox.Text;
                    wantedBook.WriterName = selectedWriter;
                    wantedBook.PublishYear = selectedYear;
                    wantedBook.Genre = selectedGenre;
                    wantedBook.BookType = selectedType;
                    wantedBook.Description = selectedDescription;
                    databaseContext.SaveChanges();
                    this.DisplayOwnedBooks();
                    if(RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.SuccessMessage,
                            caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Information,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.SuccessMessage,
                            caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Information,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign 
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }

                }
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

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.DeleteQuestion,
                    caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                    buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                    icon: System.Windows.Forms.MessageBoxIcon.Question,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
            }
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.DeleteQuestion,
                    caption: Resources.ManageBookForm.MessageboxQuestionCaption,
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
            Models.Book selectedBook = userBooksListbox.SelectedItem as Models.Book;
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var deletedBook = databaseContext.Books
                    .Where(current => current.Id == selectedBook.Id)
                    .FirstOrDefault();
                var updatedUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                updatedUser.Books.Remove(deletedBook);
                databaseContext.Books.Remove(deletedBook);
                databaseContext.SaveChanges();
                this.DisplayOwnedBooks();
                
                if(RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookDeletedMessage,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if(RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookDeletedMessage,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }

            }
            catch(System.Exception ex)
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

        private void DisownButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.DisownQuestion,
                    caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                    buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                    icon: System.Windows.Forms.MessageBoxIcon.Question,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
            }
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.DisownQuestion,
                    caption: Resources.ManageBookForm.MessageboxQuestionCaption,
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
            Models.Book selectedBook = userBooksListbox.SelectedItem as Models.Book;
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var disownedBook = databaseContext.Books
                    .Where(current => current.Id == selectedBook.Id)
                    .FirstOrDefault();
                disownedBook.OwnerUser = null;
                disownedBook.OwnerUserId = null;
                var updatedUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                updatedUser.Books.Remove(selectedBook);
                databaseContext.SaveChanges();
                this.DisplayOwnedBooks();
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookDisownedMessage,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if(RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ManageBookForm.BookDisownedMessage,
                        caption: Resources.ManageBookForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
            }
            catch(System.Exception ex)
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
    }
}
