using System.Linq;

namespace MyApplication
{
    public partial class StartupLanguageForm : Models.BaseForm
    {
        public StartupLanguageForm()
        {
            InitializeComponent();
        }

        private void StartupLanguageForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext= null;
            try
            {
               databaseContext = new Models.DatabaseContext();
                bool anyUser = databaseContext.Users.Any();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
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
