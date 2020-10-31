using System.Linq;
namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
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

            passwordTextBox.UseSystemPasswordChar = true;
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
            if (currentButton.Name == "passwordVisibleButton")
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
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            if (RightToLeftLayout == false)
            {
                result =
                      System.Windows.Forms.MessageBox.Show(
                      text: Resources.LoginForm.formClosingMessage,
                      caption: Resources.LoginForm.formClosingMessageCaption,
                      buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                      icon: System.Windows.Forms.MessageBoxIcon.Question,
                      defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);
            }
            if (RightToLeftLayout == true)
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
                System.Windows.Forms.Application.Exit();
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
