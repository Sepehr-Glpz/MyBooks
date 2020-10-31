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



            string culture = 
                System.Threading.Thread.CurrentThread.CurrentUICulture.Name.Substring(startIndex: 0, 2);
            switch(culture.ToUpper())
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
            if (passwordTextBox.UseSystemPasswordChar==true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
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
            if (currentButton.Name == nameof(this.passwordVisibleButton.Name))
            {
                currentButton.BackColor = System.Drawing.SystemColors.Window;
                return;
            }
            currentButton.BackColor = Infrastructure.Utility.FormButtonBackColor;
        }
    }
}
