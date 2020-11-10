namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

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
    }
}
