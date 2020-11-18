using System.Linq;
namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
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


        private void LoginForm_Load(object sender, System.EventArgs e)
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

            this.Text = Resources.LoginForm.LoginFormText;
            this.BackColor = Infrastructure.Utility.FormBackcolor;

            this.usernameLable.Text = Resources.LoginForm.usernameLabel;
            this.usernameLable.ForeColor = Infrastructure.Utility.FormTextColor;
            this.usernameLable.BackColor = Infrastructure.Utility.FormBackcolor;

            this.passwordLabel.Text = Resources.LoginForm.passwordLabel;
            this.passwordLabel.ForeColor = Infrastructure.Utility.FormTextColor;
            this.passwordLabel.BackColor = Infrastructure.Utility.FormBackcolor;

            this.loginButton.Text = Resources.LoginForm.loginButton;
            this.loginButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.loginButton.BackColor = Infrastructure.Utility.FormButtonBackColor;

            this.resetButton.Text = Resources.LoginForm.resetButton;
            this.resetButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.resetButton.BackColor = Infrastructure.Utility.FormButtonBackColor;

            this.registerButton.Text = Resources.LoginForm.registerButton;
            this.registerButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.registerButton.BackColor = Infrastructure.Utility.FormButtonBackColor;

            this.exitButton.Text = Resources.LoginForm.exitButton;
            this.exitButton.ForeColor = Infrastructure.Utility.FormTextColor;
            this.exitButton.BackColor = Infrastructure.Utility.FormButtonBackColor;


        }


        private void PasswordVisibleButton_Click(object sender, System.EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.Focus();
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.Focus();
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

        public void ResetForm()
        {
            this.usernameTextBox.Text = string.Empty;
            this.passwordTextBox.Text = string.Empty;
            this.usernameTextBox.Focus();
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (IsHidden == true)
            {
                return;
            }

            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                result =
                      System.Windows.Forms.MessageBox.Show(
                      text: Resources.LoginForm.formClosingMessage,
                      caption: Resources.LoginForm.formClosingMessageCaption,
                      buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                      icon: System.Windows.Forms.MessageBoxIcon.Question,
                      defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
            }
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                result =
                      System.Windows.Forms.MessageBox.Show(
                          text: Resources.LoginForm.formClosingMessage,
                          caption: Resources.LoginForm.formClosingMessageCaption,
                          buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                          icon: System.Windows.Forms.MessageBoxIcon.Question,
                          defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                          options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                          System.Windows.Forms.MessageBoxOptions.RtlReading);
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.FormClosing -= LoginForm_FormClosing;
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
            this.ResetForm();
            this.Hide();
            Infrastructure.Utility.RegisterForm.Show();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Text = usernameTextBox.Text.Trim();
            passwordTextBox.Text = passwordTextBox.Text.Trim();
            string errorResult = string.Empty;
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) == true)
            {
                errorResult += Resources.LoginForm.UsernameTextboxErrorMessage;
                errorResult += System.Environment.NewLine;
            }
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) == true)
            {
                
                errorResult += Resources.LoginForm.PasswordTextboxErrorMessage;
                errorResult += System.Environment.NewLine;
            }
            if (usernameTextBox.Text.Length >= 1 && usernameTextBox.Text.Length < 3 || usernameTextBox.Text.Length > 20)
                
            {
                errorResult += Resources.LoginForm.UsernameTextboxLengthError;
                errorResult += System.Environment.NewLine;
            }
            if (passwordTextBox.Text.Length >= 1 && passwordTextBox.Text.Length < 5 || passwordTextBox.Text.Length > 25)
                
            {
                errorResult += Resources.LoginForm.PasswordTextboxLengthError;
                errorResult += System.Environment.NewLine;
            }
            if (usernameTextBox.Text.Contains(" ") || passwordTextBox.Text.Contains(" "))
            {
                errorResult += Resources.LoginForm.TextboxWhitespaceError;
                errorResult += System.Environment.NewLine;
            }
            if (string.IsNullOrEmpty(errorResult) != true)
            {
                if (this.RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(errorResult,
                        caption: Resources.LoginForm.formClosingMessageCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1);
                }
                if (this.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(errorResult,
                        caption: Resources.LoginForm.formClosingMessageCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Warning,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                        System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                return;
            }

            
            try
            {
                databaseContext = new Models.DatabaseContext();
                var foundUser = databaseContext.Users
                    .Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
                    .Where(current => current.Password == passwordTextBox.Text)
                    .FirstOrDefault();
                if (foundUser == null)
                {
                    if (this.RightToLeft == System.Windows.Forms.RightToLeft.No)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.LoginForm.UserNotFoundError,
                            caption: Resources.LoginForm.formClosingMessageCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Error);
                    }
                    if (this.RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                    {
                        System.Windows.Forms.MessageBox.Show(text: Resources.LoginForm.UserNotFoundError,
                            caption: Resources.LoginForm.formClosingMessageCaption,
                            buttons: System.Windows.Forms.MessageBoxButtons.OK,
                            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                            icon: System.Windows.Forms.MessageBoxIcon.Error,
                            options: System.Windows.Forms.MessageBoxOptions.RightAlign 
                            | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    }
                    usernameTextBox.Focus();
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.LoginForm.LoginSuccessfulMessage,
                        caption: Resources.LoginForm.MessageboxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        icon: System.Windows.Forms.MessageBoxIcon.Information);
                }
                if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
                {
                    System.Windows.Forms.MessageBox.Show(text: Resources.LoginForm.LoginSuccessfulMessage,
                        caption: Resources.LoginForm.MessageboxCaption,
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                        icon: System.Windows.Forms.MessageBoxIcon.Information,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign
                        | System.Windows.Forms.MessageBoxOptions.RtlReading);
                }
                Infrastructure.Utility.AuthenticatedUser = foundUser;
                this.ResetForm();
                this.Hide();
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
