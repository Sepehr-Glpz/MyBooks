using System.Linq;
namespace MyApplication
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsHidden = false;
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

            #endregion /Form Language Setting

            

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
