using System.Linq;
namespace MyApplication
{
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            usernameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            usernameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            firstNamelabel.BackColor = Infrastructure.Utility.FormBackcolor;
            firstNamelabel.ForeColor = Infrastructure.Utility.FormTextColor;
            lastNameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            lastNameLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            descriptionLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            descriptionLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            saveButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            saveButton.ForeColor = Infrastructure.Utility.FormTextColor;
            resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors()

        private void displayUser()
        {
            usernameTextbox.Text = Infrastructure.Utility.AuthenticatedUser.Username;
            firstNameTextbox.Text = Infrastructure.Utility.AuthenticatedUser.FullName.FirstName;
            lastNameTextbox.Text = Infrastructure.Utility.AuthenticatedUser.FullName.LastName;
            descriptionTextbox.Text = Infrastructure.Utility.AuthenticatedUser.Description;
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
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

            this.UpdateFormColors();

            #region FormLanguageSetting
            this.Text = Resources.UpdateProfileForm.FormText;

            usernameLabel.Text = Resources.UpdateProfileForm.UsernameLabelText;

            firstNamelabel.Text = Resources.UpdateProfileForm.FirstNamelabelText;

            lastNameLabel.Text = Resources.UpdateProfileForm.LastNameLabelText;

            descriptionLabel.Text = Resources.UpdateProfileForm.DescriptionLabelText;

            saveButton.Text = Resources.UpdateProfileForm.SaveButtonText;

            resetButton.Text = Resources.UpdateProfileForm.ResetButtonText;

            returnButton.Text = Resources.UpdateProfileForm.ReturnButtonText;


            #endregion /FormLanguageSetting

            this.displayUser();

        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.displayUser();
            firstNameTextbox.Focus();
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void UpdateProfileForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Infrastructure.Utility.MainForm.Enabled = true;
            Infrastructure.Utility.MainForm.UpdateForm();
            this.Dispose();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            firstNameTextbox.Text = firstNameTextbox.Text.Trim();
            lastNameTextbox.Text = lastNameTextbox.Text.Trim();
            descriptionTextbox.Text = descriptionTextbox.Text.Trim();
            while (firstNameTextbox.Text.Contains("  "))
            {
                firstNameTextbox.Text = firstNameTextbox.Text.Replace("  ", " ");
            }
            while (lastNameTextbox.Text.Contains("  "))
            {
                lastNameTextbox.Text = lastNameTextbox.Text.Replace("  ", " ");
            }

            string selectedFirstnName = null;
            if (string.IsNullOrWhiteSpace(firstNameTextbox.Text)==false)
            {
                selectedFirstnName = firstNameTextbox.Text;
            }
            string selectedLastName = null;
            if (string.IsNullOrWhiteSpace(lastNameTextbox.Text)==false)
            {
                selectedLastName = lastNameTextbox.Text;
            }
            string selectedDescription = null;
            if (string.IsNullOrWhiteSpace(descriptionTextbox.Text) == false)
            {
                selectedDescription = descriptionTextbox.Text;
            }


            if (selectedFirstnName == Infrastructure.Utility.AuthenticatedUser.FullName.FirstName
                && selectedLastName == Infrastructure.Utility.AuthenticatedUser.FullName.LastName
                && selectedDescription == Infrastructure.Utility.AuthenticatedUser.Description)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.UpdateProfileForm.UserNotChangedError,
                        caption: Resources.UpdateProfileForm.MessageboxWarningCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.UpdateProfileForm.UserNotChangedError,
                        caption: Resources.UpdateProfileForm.MessageboxWarningCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                return;
            }

            string errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(firstNameTextbox.Text) == false)
            {
                if (firstNameTextbox.Text.Length > 10 || firstNameTextbox.Text.Length < 3)
                {
                    errorMessage += Resources.UpdateProfileForm.FirstNameLengthError;
                    errorMessage += System.Environment.NewLine;
                }
            }
            if (string.IsNullOrWhiteSpace(lastNameTextbox.Text) == false)
            {
                if (lastNameTextbox.Text.Length > 15 || lastNameTextbox.Text.Length < 2)
                {
                    errorMessage += Resources.UpdateProfileForm.LastNameLengthError;
                    errorMessage += System.Environment.NewLine;
                }
            }
            if (string.IsNullOrWhiteSpace(descriptionTextbox.Text) == false)
            {
                if (descriptionTextbox.Text.Length > 1024)
                {
                    errorMessage += Resources.UpdateProfileForm.DescriptionLengthError;
                    errorMessage += System.Environment.NewLine;
                }
            }
            if (errorMessage != string.Empty)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessage,
                        caption: Resources.UpdateProfileForm.MessageboxErrorCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessage,
                        caption: Resources.UpdateProfileForm.MessageboxErrorCaption,
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
                var selectedUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                selectedUser.FullName.FirstName = selectedFirstnName;
                selectedUser.FullName.LastName = selectedLastName;
                selectedUser.Description = selectedDescription;
                Infrastructure.Utility.AuthenticatedUser = selectedUser;
                databaseContext.SaveChanges();
                this.displayUser();
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.UpdateProfileForm.UserUpdatedMessage,
                        caption: Resources.UpdateProfileForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.UpdateProfileForm.UserUpdatedMessage,
                        caption: Resources.UpdateProfileForm.MessageboxQuestionCaption,
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
