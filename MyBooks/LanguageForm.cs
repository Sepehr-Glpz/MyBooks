namespace MyApplication
{
    public partial class LanguageForm : Infrastructure.BaseForm
    {
        public LanguageForm()
        {
            InitializeComponent();
            this.Focus();
        }

        private void LanguageForm_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            Infrastructure.Utility.FormBackcolor = System.Drawing.Color.LightGreen;
            Infrastructure.Utility.FormButtonBackColor = System.Drawing.Color.Khaki;
            Infrastructure.Utility.FormTextColor = System.Drawing.SystemColors.ControlText;
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

        private void LanguageButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
            switch (currentButton.Name)
            {
                case "englishButton":
                    System.Globalization.CultureInfo englishCultureInfo =
                        new System.Globalization.CultureInfo("en-US");
                    System.Threading.Thread.CurrentThread.CurrentCulture = englishCultureInfo;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = englishCultureInfo;
                    break;

                case "persianButton":
                    System.Globalization.CultureInfo persianCultureInfo =
                        new System.Globalization.CultureInfo("fa-IR");
                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCultureInfo;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCultureInfo;
                    break;

                default:
                    return;
            }

            this.Hide();

            Infrastructure.Utility.LoginForm.Show();

        }
    }
}
