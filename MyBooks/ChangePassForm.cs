using System.Linq;
namespace MyApplication
{
    public partial class ChangePassForm : Infrastructure.BaseForm
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        #region UpdaateFromColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;
            oldPasswordLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            oldPasswordLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            newPasswordLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            newPasswordLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            repeatPasswordLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            repeatPasswordLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            saveButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            saveButton.ForeColor = Infrastructure.Utility.FormTextColor;
            resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
            returnButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            returnButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }
        #endregion /UpdateFormColors()

        private void ResetForm()
        {
            oldPasswordTextbox.Text = string.Empty;
            newPasswordTextbox.Text = string.Empty;
            repeatPasswordTextbox.Text = string.Empty;
            oldPasswordTextbox.Focus();
        }

        private void ChangePassForm_Load(object sender, System.EventArgs e)
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
            this.Text = Resources.ChangePassForm.FormText;

            oldPasswordLabel.Text = Resources.ChangePassForm.OldPasswordTextboxText;

            newPasswordLabel.Text = Resources.ChangePassForm.NewPasswordLabelText;

            repeatPasswordLabel.Text = Resources.ChangePassForm.RepeatPasswordLabelText;

            saveButton.Text = Resources.ChangePassForm.SaveButtonText;

            resetButton.Text = Resources.ChangePassForm.ResetButtonText;

            returnButton.Text = Resources.ChangePassForm.ReturnButtonText;

            #endregion /FormLanguageSetting

        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.ResetForm();
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ChangePassForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
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
            if (currentButton.Name == viewButton.Name)
            {
                currentButton.BackColor = System.Drawing.SystemColors.Window;
            }
            currentButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            oldPasswordTextbox.Text = oldPasswordTextbox.Text.Trim();
            newPasswordTextbox.Text = newPasswordTextbox.Text.Trim();
            repeatPasswordTextbox.Text = repeatPasswordTextbox.Text.Trim();
            string errorMessages = string.Empty;
            if(string.IsNullOrWhiteSpace(oldPasswordTextbox.Text)==true)
            {
                errorMessages += Resources.ChangePassForm.OldPassEmptyError;
                errorMessages += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(oldPasswordTextbox.Text) == false 
                && string.IsNullOrWhiteSpace(newPasswordTextbox.Text) == true)
            {
                errorMessages += Resources.ChangePassForm.NewPassEmptyError;
                errorMessages += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(oldPasswordTextbox.Text) == false 
                && string.IsNullOrWhiteSpace(newPasswordTextbox.Text) == false
                && string.IsNullOrWhiteSpace(repeatPasswordTextbox.Text) == true)
            {
                errorMessages += Resources.ChangePassForm.RepeatPassEmptyError;
                errorMessages += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(oldPasswordTextbox.Text) == false)
            {
                if (oldPasswordTextbox.Text != Infrastructure.Utility.AuthenticatedUser.Password)
                {
                    errorMessages += Resources.ChangePassForm.OldPassNotCorrectError;
                    errorMessages += System.Environment.NewLine;
                }
            }
            if (string.IsNullOrWhiteSpace(newPasswordTextbox.Text) == false)
            {
                if (newPasswordTextbox.Text.Length < 5 || newPasswordTextbox.Text.Length > 25)
                {
                    errorMessages += Resources.ChangePassForm.NewPassLengthError;
                    errorMessages += System.Environment.NewLine;
                }
                if (newPasswordTextbox.Text == Infrastructure.Utility.AuthenticatedUser.Password
                    && newPasswordTextbox.Text == oldPasswordTextbox.Text)
                {
                    errorMessages += Resources.ChangePassForm.NewPassRepeatError;
                    errorMessages += System.Environment.NewLine;
                }
                if (string.IsNullOrWhiteSpace(repeatPasswordTextbox.Text) == false)
                {
                    if (repeatPasswordTextbox.Text != newPasswordTextbox.Text)
                    {
                        errorMessages += Resources.ChangePassForm.RepeatPassNotCorrect;
                        errorMessages += System.Environment.NewLine;
                    }
                }
            }
            if (errorMessages != string.Empty)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessages,
                        caption: Resources.ChangePassForm.MessageboxErrorCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: errorMessages,
                        caption: Resources.ChangePassForm.MessageboxErrorCaption,
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
                var foundUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                if (foundUser.Id != Infrastructure.Utility.AuthenticatedUser.Id)
                {
                    errorMessages += Resources.ChangePassForm.PassAlreadyChangedError;
                }
                if (errorMessages != string.Empty)
                {
                    if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: errorMessages,
                            caption: Resources.ChangePassForm.MessageboxErrorCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: errorMessages,
                            caption: Resources.ChangePassForm.MessageboxErrorCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }

                    Infrastructure.Utility.AuthenticatedUser = null;
                    Infrastructure.Utility.MainForm.Hide();
                    Infrastructure.Utility.LoginForm.Enabled = true;
                    Infrastructure.Utility.LoginForm.Show();
                    this.Close();
                    Infrastructure.Utility.MainForm.Enabled = false;
                    return;
                }

                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.ChangePassForm.ChangePassQuestion,
                        caption: Resources.ChangePassForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
                        
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    result =
                        System.Windows.Forms.MessageBox.Show(text: Resources.ChangePassForm.ChangePassQuestion,
                        caption: Resources.ChangePassForm.MessageboxQuestionCaption,
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

                foundUser.Password = newPasswordTextbox.Text;
                databaseContext.SaveChanges();

                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ChangePassForm.PassChangedMessage,
                        caption: Resources.ChangePassForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.ChangePassForm.PassChangedMessage,
                        caption: Resources.ChangePassForm.MessageboxQuestionCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                this.ResetForm();

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

        private void ViewButton_Click(object sender, System.EventArgs e)
        {
            if (oldPasswordTextbox.UseSystemPasswordChar == true)
            {
                oldPasswordTextbox.UseSystemPasswordChar = false;
                newPasswordTextbox.UseSystemPasswordChar = false;
                repeatPasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                oldPasswordTextbox.UseSystemPasswordChar = true;
                newPasswordTextbox.UseSystemPasswordChar = true;
                repeatPasswordTextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
