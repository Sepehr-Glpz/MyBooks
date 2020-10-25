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






            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordVisibleButton_Click(object sender, System.EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar==false)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
