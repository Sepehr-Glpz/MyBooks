using System.Linq;
namespace MyApplication
{
    public partial class ManageUsersForm : Infrastructure.BaseForm
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            searchByUsernameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            searchByUsernameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            filterAdminCheckbox.BackColor = Infrastructure.Utility.FormBackcolor;
            filterAdminCheckbox.ForeColor = Infrastructure.Utility.FormTextColor;
            filterByActiveCheckbox.BackColor = Infrastructure.Utility.FormBackcolor;
            filterByActiveCheckbox.ForeColor = Infrastructure.Utility.FormTextColor;
            resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
            viewUserButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            viewUserButton.ForeColor = Infrastructure.Utility.FormTextColor;
            searchButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            searchButton.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors()

        private void DisplayUsers(bool wantAdmin, bool wantDeactive)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var data = databaseContext.Users.AsQueryable();
                if (wantAdmin == true)
                {
                    data = data.Where(current => current.IsAdmin == true)
                        .OrderBy(current => current.Username);
                }
                if (wantDeactive == true)
                {
                    data = data.Where(current => current.IsActive == false)
                        .OrderBy(current => current.Username);
                }
                var Users = data.ToList();
                displayUsersListbox.DataSource = null;
                displayUsersListbox.DataSource = Users;
                displayUsersListbox.DisplayMember = nameof(Models.User.DisplayListName);
                displayUsersListbox.ValueMember = nameof(Models.User.Username);

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
        private void DisplayUsers(string Name, bool wantAdmin, bool wantDeactive)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                var data = databaseContext.Users
                    .Where(current => current.Username.ToLower().Contains(Name.ToLower()) == true
                    || current.FullName.FirstName.ToLower().Contains(Name.ToLower()) == true
                    || current.FullName.LastName.ToLower().Contains(Name.ToLower()))
                    .OrderBy(current => current.Username)
                    .AsQueryable();
                if (wantAdmin == true)
                {
                    data = data.Where(current => current.IsAdmin == true)
                        .OrderBy(current => current.Username);
                }
                if (wantDeactive == true)
                {
                    data = data.Where(current => current.IsActive == false)
                        .OrderBy(current => current.Username);
                }
                var Users = data.ToList();
                displayUsersListbox.DataSource = Users;
                displayUsersListbox.DisplayMember = nameof(Models.User.DisplayListName);
                displayUsersListbox.ValueMember = nameof(Models.User.Username);
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

        public void ShowUsers()
        {
            bool wantAdmin = this.filterAdminCheckbox.Checked;
            bool wantDeactive = this.filterByActiveCheckbox.Checked;
            if (string.IsNullOrWhiteSpace(searchByNameTextbox.Text) == false)
            {
                string name = searchByNameTextbox.Text.Trim();
                while (name.Contains("  "))
                {
                    name.Replace("  ", " ");
                }
                DisplayUsers(name, wantAdmin, wantDeactive);
                return;
            }
            DisplayUsers(wantAdmin, wantDeactive);
            return;
        }

        private void ManageUsersForm_Load(object sender, System.EventArgs e)
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
                        filterAdminCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        filterByActiveCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        break;
                    }
                default:
                    {
                        RightToLeftLayout = false;
                        RightToLeft = System.Windows.Forms.RightToLeft.No;
                        filterByActiveCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        filterAdminCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        break;
                    }
            }

            this.UpdateFormColors();

            #region FormLanguageSetting

            this.Text = Resources.ManageUsersForm.FormText;

            searchByUsernameLabel.Text = Resources.ManageUsersForm.SearchByUsernameLabelText;

            filterAdminCheckbox.Text = Resources.ManageUsersForm.FilterAdminCheckboxText;

            filterByActiveCheckbox.Text = Resources.ManageUsersForm.FilterByActiveCheckboxText;

            resetButton.Text = Resources.ManageUsersForm.ResetButtonText;

            viewUserButton.Text = Resources.ManageUsersForm.ViewUserButtonText;

            searchButton.Text = Resources.ManageUsersForm.SearchButtonText;

            returnButton.Text = Resources.ManageBookForm.ReturnButtonText;

            #endregion /FormLanguageSetting



        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            searchByNameTextbox.Text = string.Empty;
            searchByNameTextbox.Focus();
            displayUsersListbox.DataSource = null;
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            this.ShowUsers();
        }

        private void ViewUserButton_Click(object sender, System.EventArgs e)
        {
             





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

        private void ManageUsersForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            this.Dispose();
        }
    }
}
