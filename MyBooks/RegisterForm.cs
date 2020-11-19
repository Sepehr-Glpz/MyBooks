using System.Linq;
namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
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

        private Models.DatabaseContext databaseContext;

        private void RegisterForm_Load(object sender, System.EventArgs e)
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

            this.Text = Resources.RegisterForm.RegisterFormText;
            this.BackColor = Infrastructure.Utility.FormBackcolor;

            this.usernameLabel.Text = Resources.RegisterForm.UsernameLabelText;
            this.usernameLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.usernameLabel.ForeColor = Infrastructure.Utility.FormTextColor;

            this.passwordLabel.Text = Resources.RegisterForm.PasswordLabelText;
            this.passwordLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.passwordLabel.ForeColor = Infrastructure.Utility.FormTextColor;

            this.repeatPasswordLabel.Text = Resources.RegisterForm.RepeatPasswordLabelText;
            this.repeatPasswordLabel.BackColor = Infrastructure.Utility.FormBackcolor;
            this.repeatPasswordLabel.ForeColor = Infrastructure.Utility.FormTextColor;

            this.registerButton.Text = Resources.RegisterForm.RegisterButtonText;
            this.registerButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.registerButton.ForeColor = Infrastructure.Utility.FormTextColor;

            this.resetButton.Text = Resources.RegisterForm.ResetButtonText;
            this.resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.resetButton.ForeColor = Infrastructure.Utility.FormTextColor;

            this.loginButton.Text = Resources.RegisterForm.LoginButtonText;
            this.loginButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.loginButton.ForeColor = Infrastructure.Utility.FormTextColor;

            this.exitButton.Text = Resources.RegisterForm.ExitButtonText;
            this.exitButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
            this.exitButton.ForeColor = Infrastructure.Utility.FormTextColor;
        }

        private void PasswordVisibleButton_Click(object sender, System.EventArgs e)
        {
            if (passwordTextbox.UseSystemPasswordChar == true && repeatPasswordTextbox.UseSystemPasswordChar == true)
            {
                passwordTextbox.UseSystemPasswordChar = false;
                repeatPasswordTextbox.UseSystemPasswordChar = false;
                passwordTextbox.Focus();
            }
            else
            {
                passwordTextbox.UseSystemPasswordChar = true;
                repeatPasswordTextbox.UseSystemPasswordChar = true;
                passwordTextbox.Focus();
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
            if (currentButton.Name == passwordVisibleButton.Name)
            {
                currentButton.BackColor = System.Drawing.SystemColors.Window;
                return;
            }
            currentButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }
        public void ResetForm()
        {
            this.usernameTextbox.Text = string.Empty;
            this.passwordTextbox.Text = string.Empty;
            this.repeatPasswordTextbox.Text = string.Empty;
            this.usernameTextbox.Focus();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            this.ResetForm();
            this.Hide();
            Infrastructure.Utility.LoginForm.Show();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.IsHidden == true)
            {
                return;
            }
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(
                        text: Resources.RegisterForm.FormClosingMessageBoxText,
                        caption: Resources.RegisterForm.FormClosingMessageBoxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                        System.Windows.Forms.MessageBoxOptions.RtlReading);
            }
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                result =
                    System.Windows.Forms.MessageBox.Show(
                        text: Resources.RegisterForm.FormClosingMessageBoxText,
                        caption: Resources.RegisterForm.FormClosingMessageBoxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                        icon: System.Windows.Forms.MessageBoxIcon.Question,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);    
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.FormClosing -= RegisterForm_FormClosing;
                System.Windows.Forms.Application.Exit();
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            usernameTextbox.Text=usernameTextbox.Text.Trim();
            passwordTextbox.Text = passwordTextbox.Text.Trim();
            repeatPasswordTextbox.Text = repeatPasswordTextbox.Text.Trim();
            string result = string.Empty;
            if (string.IsNullOrWhiteSpace(usernameTextbox.Text) == true)
            {
                result += Resources.RegisterForm.UsernameTextboxEmptyError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                result += Resources.RegisterForm.PasswordTextboxEmptyError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(repeatPasswordTextbox.Text)==true 
                && string.IsNullOrWhiteSpace(passwordTextbox.Text)==false)
            {
                result += Resources.RegisterForm.RepeatPasswordTextboxEmptyError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(usernameTextbox.Text)==false && usernameTextbox.Text.Length < 3 
                || usernameTextbox.Text.Length > 20)
            {
                result += Resources.RegisterForm.UsernameTextboxLengthError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(passwordTextbox.Text) == false && passwordTextbox.Text.Length < 5 
                || passwordTextbox.Text.Length > 25)
            {
                result += Resources.RegisterForm.PasswordTextboxLengthError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(passwordTextbox.Text)==false 
                && string.IsNullOrWhiteSpace(repeatPasswordTextbox.Text)==false
                && passwordTextbox.Text != repeatPasswordTextbox.Text)
            {
                result += Resources.RegisterForm.RepeatPasswordTextboxError;
                result += System.Environment.NewLine;
            }
            if (usernameTextbox.Text.Contains(" ") == true || passwordTextbox.Text.Contains(" ")==true)
            {
                result += Resources.RegisterForm.TextboxWhitespaceError;
                result += System.Environment.NewLine;
            }
            if (string.IsNullOrEmpty(result) != true)
            {
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: result,
                        caption: Resources.RegisterForm.ErrorMessageboxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        icon: System.Windows.Forms.MessageBoxIcon.Error);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: result,
                        caption: Resources.RegisterForm.ErrorMessageboxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign 
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                usernameTextbox.Focus();
                return;
            }
            try
            {
                databaseContext = new Models.DatabaseContext();
                bool userExists = databaseContext.Users
                    .Where(current => current.Username.ToLower() == usernameTextbox.Text.ToLower())
                    .Any();
                if (userExists == true)
                {
                    if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.RegisterForm.UserExistsError,
                            caption: Resources.RegisterForm.FormClosingMessageBoxCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Warning);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.RegisterForm.UserExistsError,
                            caption: Resources.RegisterForm.FormClosingMessageBoxCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Warning,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign 
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }
                    usernameTextbox.Focus();
                    return;
                }
                if (userExists == false)
                {
                    Models.User newUser = new Models.User()
                    {
                        Username = usernameTextbox.Text,
                        Password = passwordTextbox.Text,
                        IsActive = true,
                        IsAdmin = false,
                    };
                    databaseContext.Users.Add(newUser);
                    databaseContext.SaveChanges();
                    if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.RegisterForm.RegisterSuccessfulMessage,
                            caption: Resources.RegisterForm.MessageboxCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Information);
                    }
                    if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.RegisterForm.RegisterSuccessfulMessage,
                            caption: Resources.RegisterForm.MessageboxCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Information,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }
                    Infrastructure.Utility.AuthenticatedUser = newUser;
                    this.ResetForm();
                    this.Hide();

                    Infrastructure.Utility.MainForm.Show();

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
                    databaseContext = null;
                }
            }

        }
    }
}
