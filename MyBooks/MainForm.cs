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

        public void UpdateForm()
        {
            this.toolStripAdminOption.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            this.toolStripAdminOption.Enabled = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            string usersFullname = Infrastructure.Utility.AuthenticatedUser.DisplayFullName;
            string usersUsername = Infrastructure.Utility.AuthenticatedUser.Username;
            string result = string.Format(Resources.MainForm.UserWelcomeMessageText, usersFullname, usersUsername);
            this.userWelcomeMessageLabel.Text = result;
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

            this.UpdateForm();

            #region Form Language/Color Setting
            this.Text = Resources.MainForm.MainFormText;
            this.BackColor = Infrastructure.Utility.FormBackcolor;

            this.toolStripBooksOption.Text = Resources.MainForm.ToolStripBooksOptionText;
            this.toolStripBooksOption.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripBookAddItem.Text = Resources.MainForm.ToolStripBookAddItemText;
            this.toolStripBookAddItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripBookManageItem.Text = Resources.MainForm.ToolStripBookManageItemText;
            this.toolStripBookManageItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripBookOwnItem.Text = Resources.MainForm.ToolStripBookOwnItemText;
            this.toolStripBookOwnItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripUserOption.Text = Resources.MainForm.ToolStripUserOptionText;
            this.toolStripUserOption.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripUserUpdateItem.Text = Resources.MainForm.ToolStripUserUpdateItemText;
            this.toolStripUserUpdateItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripUserChangePassItem.Text = Resources.MainForm.ToolStripUserChangePassItemText;
            this.toolStripUserChangePassItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripSettingOption.Text = Resources.MainForm.ToolStripSettingOptionText;
            this.toolStripSettingOption.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripColorSettingItem.Text = Resources.MainForm.ToolStripColorSettingItem;
            this.toolStripColorSettingItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripAdminOption.Text = Resources.MainForm.ToolStripAdminOptionText;
            this.toolStripAdminOption.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripAdminUsersItem.Text = Resources.MainForm.ToolStripAdminUsersItemText;
            this.toolStripAdminUsersItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripAdminBooksItem.Text = Resources.MainForm.ToolStripAdminBooksItemText;
            this.toolStripAdminBooksItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.exitToolStripMenuItem.Text = Resources.MainForm.ExitToolStripMenuItemText;
            this.exitToolStripMenuItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripLogoutItem.Text = Resources.MainForm.ToolStripLogoutItemText;
            this.toolStripLogoutItem.ForeColor = Infrastructure.Utility.FormTextColor;

            this.toolStripExitItem.Text = Resources.MainForm.ToolStripExitItemText;
            this.toolStripExitItem.ForeColor = Infrastructure.Utility.FormTextColor;

            

            #endregion /Form Language/Color Setting

            

        }
    }
}
