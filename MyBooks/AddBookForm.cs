using System.Linq;
namespace MyApplication
{
    public partial class AddBookForm : Infrastructure.BaseForm
    {
        public AddBookForm()
        {
            InitializeComponent();
        }


        #region UpdateFormColor()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;


        }
        #endregion /UpdateFormColor()


        private void AddBookForm_Load(object sender, System.EventArgs e)
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

            #region Form Language Setting
            this.Text = Resources.AddBookForm.FormText;


            #endregion /Form Language Setting



        }
    }
}
