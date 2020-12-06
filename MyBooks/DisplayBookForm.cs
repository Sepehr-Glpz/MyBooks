using System.Linq;
namespace MyApplication
{
    public partial class DisplayBookForm : Infrastructure.BaseForm
    {
        public DisplayBookForm()
        {
            InitializeComponent();
        }

        public Models.Book SelectedBook { protected get; set; }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            bookNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            writerNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            writerNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            bookGenreLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookGenreLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            bookTypeLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            bookTypeLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            ownerUsernameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            ownerUsernameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            ownerFullnameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            ownerFullnameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            descriptionLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            descriptionLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors

        private void DisplayBookForm_Load(object sender, System.EventArgs e)
        {
            string culture =
                System.Threading.Thread.CurrentThread.CurrentUICulture.Name.Substring(startIndex: 0, 2);
            switch (culture.ToUpper())
            {
                case "FA":
                case "AR":
                    {
                        this.RightToLeftLayout = true;
                        this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        this.bookNameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.writerNameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.bookGenreTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.bookTypeTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.ownerUsernameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.ownerFullnameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.yearTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
                default:
                    {
                        this.RightToLeftLayout = false;
                        this.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
            }

            this.UpdateFormColors();

            #region FormLanguageSetting

            bookNameLabel.Text = Resources.DisplayBookForm.BookNameLabelText;

            writerNameLabel.Text = Resources.DisplayBookForm.WriterNameLabelText;

            bookGenreLabel.Text = Resources.DisplayBookForm.BookGenreLabelText;

            bookTypeLabel.Text = Resources.DisplayBookForm.BookTypeLabelText;

            yearLabel.Text = Resources.DisplayBookForm.YearLabelText;

            ownerUsernameLabel.Text = Resources.DisplayBookForm.OwnerUsernameLabelText;

            ownerFullnameLabel.Text = Resources.DisplayBookForm.OwnerFullnameLabelText;

            descriptionLabel.Text = Resources.DisplayBookForm.DescriptionLabelText;

            returnButton.Text = Resources.DisplayBookForm.ReturnButtonText;

            #endregion /FormLanguageSetting

            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var selectedBook = databaseContext.Books
                    .Where(current => current.Id == SelectedBook.Id)
                    .FirstOrDefault();
                bookNameTextbox.Text = selectedBook.BookName;
                writerNameTextbox.Text = selectedBook.WriterName;
                bookGenreTextbox.Text = 
                    System.Enum.GetName(typeof(Models.BookGenres), selectedBook.Genre);
                bookTypeTextbox.Text =
                    System.Enum.GetName(typeof(Models.BookType), selectedBook.BookType);
                if (selectedBook.PublishYear != null)
                {
                    yearTextbox.Text = selectedBook.PublishYear.ToString();
                }
                if (selectedBook.Description != null)
                {
                    descriptionTextbox.Text = selectedBook.Description;
                }
                if (selectedBook.OwnerUserId != null)
                {
                    ownerUsernameTextbox.Text = selectedBook.OwnerUser.Username;
                    ownerFullnameTextbox.Text = selectedBook.OwnerUser.DisplayFullName;
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

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void DisplayBookForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            this.Dispose();
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
