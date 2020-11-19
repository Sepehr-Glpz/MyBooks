using System.Linq;
namespace MyApplication
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
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

        private void MainForm_Load(object sender, System.EventArgs e)
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

            this.Text = Resources.MainForm.MainFormText;
            this.BackColor = Infrastructure.Utility.FormBackcolor;

           
        }
    }
}
