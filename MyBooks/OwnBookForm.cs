using System.Linq;
namespace MyApplication
{
    public partial class OwnBookForm : Infrastructure.BaseForm
    {
        public OwnBookForm()
        {
            InitializeComponent();
        }

        #region UpdateFormColors()
        public void UpdateFormColors()
        {
            this.BackColor = Infrastructure.Utility.FormBackcolor;



        }
        #endregion /UpdateFormColors()

        private void OwnBookForm_Load(object sender, System.EventArgs e)
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

            this.UpdateFormColors();
            #region FormLanguageSetting



            #endregion /FormLanguageSetting





        }
    }
}
