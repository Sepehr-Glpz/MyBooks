using System.Linq;
namespace MyApplication
{
    public partial class AddBookForm : Infrastructure.BaseForm
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColor()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            bookNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            descriptionLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            descriptionLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            writerNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            writerNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            yearLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            yearLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            genreLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            genreLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            ownerLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            ownerLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            bookTypeLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookTypeLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            addBookButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            addBookButton.ForeColor = Infrastructure.Utility.FormTextColor;
            resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColor()


        private void AddBookForm_Load(object sender, System.EventArgs e)
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
                        descriptionTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        genresCombobox.RightToLeft = System.Windows.Forms.RightToLeft.No;
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

            this.UpdateFormColors();

            #region Form Language Setting
            this.Text = Resources.AddBookForm.FormText;

            bookNameLabel.Text = Resources.AddBookForm.BookNameLabelText;

            descriptionLabel.Text = Resources.AddBookForm.DescriptionLabelText;

            writerNameLabel.Text = Resources.AddBookForm.WriterNameLabelText;

            yearLabel.Text = Resources.AddBookForm.YearLabelText;

            genreLabel.Text = Resources.AddBookForm.GenreLabelText;

            ownerLabel.Text = Resources.AddBookForm.OwnerLabelText;

            bookTypeLabel.Text = Resources.AddBookForm.BookTypeLabelText;

            addBookButton.Text = Resources.AddBookForm.AddBookButtonText;

            resetButton.Text = Resources.AddBookForm.ResetButtonText;

            #endregion /Form Language Setting

            var genres = System.Enum.GetNames(typeof(Models.BookGenres)).ToList();
            genresCombobox.DataSource = genres;
            var types = System.Enum.GetNames(typeof(Models.BookType)).ToList();
            bookTypeCombobox.DataSource = types;
            System.Collections.Generic.List<string> owners = new System.Collections.Generic.List<string>()
            {
                $"{Infrastructure.Utility.AuthenticatedUser.Username}",
                "NONE",
            };
            ownerCombobox.DataSource = owners;
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

        private void AddBookForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            bookNameTextbox.Text = string.Empty;
            writerNameTextbox.Text = string.Empty;
            yearTextbox.Text = string.Empty;
            descriptionTextbox.Text = string.Empty;
            ownerCombobox.SelectedItem = null;
        }

        private void AddBookButton_Click(object sender, System.EventArgs e)
        {
            string errorMessage = string.Empty;
            bookNameTextbox.Text = bookNameTextbox.Text.Trim();
            while(bookNameTextbox.Text.Contains("  "))
            {
                bookNameTextbox.Text = bookNameTextbox.Text.Replace("  ", " ");
            }
            writerNameTextbox.Text = writerNameTextbox.Text.Trim();
            while (writerNameTextbox.Text.Contains("  "))
            {
                bookNameTextbox.Text = bookNameTextbox.Text.Replace("  ", " ");
            }
            foreach(char character in yearTextbox.Text)
            {
                if(char.IsDigit(character) == false)
                {
                    yearTextbox.Text = string.Empty;
                    break;
                }
            }
            descriptionTextbox.Text = descriptionTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(bookNameTextbox.Text) == true)
            {
                errorMessage += Resources.AddBookForm.BooknameTextBoxError;
                errorMessage += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(bookNameTextbox.Text)==false)
                 if(bookNameTextbox.Text.Length > 25 || bookNameTextbox.Text.Length < 2)
            {
                errorMessage += Resources.AddBookForm.BooknameLengthError;
                errorMessage += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(writerNameTextbox.Text)==false)
                if (writerNameTextbox.Text.Length > 20 || writerNameTextbox.Text.Length < 3)
            {
                errorMessage += Resources.AddBookForm.WriternameLengthError;
                errorMessage += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(yearTextbox.Text) == false)
            {
                int selectedYear = System.Convert.ToInt32(yearTextbox.Text);
                if (selectedYear > 10000 || selectedYear < 0)
                {
                    errorMessage += Resources.AddBookForm.YearError;
                    errorMessage += System.Environment.NewLine;
                }
            }

            if (errorMessage != string.Empty)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessage,
                        caption: Resources.AddBookForm.MessageboxCaptionError,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessage,
                        caption: Resources.AddBookForm.MessageboxCaptionError,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
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
                bool bookExists = databaseContext.Books
                    .Where(current => current.BookName.ToLower() == bookNameTextbox.Text.ToLower())
                    .Any();
                if (bookExists == true)
                {
                    if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookexistMessage,
                            caption: Resources.AddBookForm.MessageboxCaptionError,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookexistMessage,
                            caption: Resources.AddBookForm.MessageboxCaptionError,
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
                        System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookAddMessage,
                        caption: Resources.AddBookForm.MessageBoxCaptionQuestion,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookAddMessage,
                        caption: Resources.AddBookForm.MessageBoxCaptionQuestion,
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



                string selectedGenreString = genresCombobox.SelectedItem as string;
                Models.BookGenres selectedGenre =
                    (Models.BookGenres)System.Enum.Parse(typeof(Models.BookGenres), selectedGenreString);
                string selectedTypeString = bookTypeCombobox.SelectedItem as string;
                Models.BookType selectedBookType =
                    (Models.BookType)System.Enum.Parse(typeof(Models.BookType), selectedTypeString);
                string selectedUsername = ownerCombobox.SelectedItem as string;
                Models.Book newBook = new Models.Book()
                {
                    BookName = bookNameTextbox.Text,
                    Genre = selectedGenre,
                    BookType = selectedBookType,
                };
                if (string.IsNullOrWhiteSpace(writerNameTextbox.Text)==false)
                {
                    newBook.WriterName = writerNameTextbox.Text;
                }
                if (string.IsNullOrWhiteSpace(yearTextbox.Text) == false)
                {
                    newBook.PublishYear = System.Convert.ToInt32(yearTextbox.Text);
                }

                Models.User existingUser =
                    databaseContext.Users
                    .Where(current => current.Username == selectedUsername)
                    .FirstOrDefault();

                if (existingUser != null)
                {
                    newBook.OwnerUser = existingUser;
                    newBook.OwnerUserId = existingUser.Id;
                    newBook.OwnerUser.Books.Add(newBook);
                }

                if (string.IsNullOrWhiteSpace(descriptionTextbox.Text)==false)
                {
                    newBook.Description = descriptionTextbox.Text;
                }

                databaseContext.Books.Add(newBook);
                databaseContext.SaveChanges();
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookAddedMessage,
                        caption: Resources.AddBookForm.MessageBoxCaptionMessage,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.AddBookForm.BookAddedMessage,
                        caption: Resources.AddBookForm.MessageBoxCaptionMessage,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
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

        private void YearTextbox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true;
            }
        }
    }
}
