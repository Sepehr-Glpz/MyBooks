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


        }
    }
}
