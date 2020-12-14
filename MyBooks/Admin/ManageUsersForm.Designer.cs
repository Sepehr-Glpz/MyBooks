
namespace MyApplication
{
    partial class ManageUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayUsersListbox = new System.Windows.Forms.ListBox();
            this.searchByNameTextbox = new System.Windows.Forms.TextBox();
            this.searchByUsernameLabel = new System.Windows.Forms.Label();
            this.filterAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.filterByActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.viewUserButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayUsersListbox
            // 
            this.displayUsersListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayUsersListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.displayUsersListbox.FormattingEnabled = true;
            this.displayUsersListbox.HorizontalScrollbar = true;
            this.displayUsersListbox.ItemHeight = 15;
            this.displayUsersListbox.Location = new System.Drawing.Point(0, 97);
            this.displayUsersListbox.Name = "displayUsersListbox";
            this.displayUsersListbox.Size = new System.Drawing.Size(384, 214);
            this.displayUsersListbox.TabIndex = 0;
            // 
            // searchByNameTextbox
            // 
            this.searchByNameTextbox.Location = new System.Drawing.Point(120, 12);
            this.searchByNameTextbox.MaxLength = 25;
            this.searchByNameTextbox.Name = "searchByNameTextbox";
            this.searchByNameTextbox.Size = new System.Drawing.Size(252, 20);
            this.searchByNameTextbox.TabIndex = 1;
            // 
            // searchByUsernameLabel
            // 
            this.searchByUsernameLabel.AutoSize = true;
            this.searchByUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.searchByUsernameLabel.Location = new System.Drawing.Point(12, 15);
            this.searchByUsernameLabel.Name = "searchByUsernameLabel";
            this.searchByUsernameLabel.Size = new System.Drawing.Size(102, 15);
            this.searchByUsernameLabel.TabIndex = 2;
            this.searchByUsernameLabel.Text = "Search By Name:";
            // 
            // filterAdminCheckbox
            // 
            this.filterAdminCheckbox.AutoSize = true;
            this.filterAdminCheckbox.Location = new System.Drawing.Point(120, 38);
            this.filterAdminCheckbox.Name = "filterAdminCheckbox";
            this.filterAdminCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filterAdminCheckbox.Size = new System.Drawing.Size(85, 17);
            this.filterAdminCheckbox.TabIndex = 4;
            this.filterAdminCheckbox.Text = "Filter Admins";
            this.filterAdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // filterByActiveCheckbox
            // 
            this.filterByActiveCheckbox.AutoSize = true;
            this.filterByActiveCheckbox.Location = new System.Drawing.Point(211, 38);
            this.filterByActiveCheckbox.Name = "filterByActiveCheckbox";
            this.filterByActiveCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filterByActiveCheckbox.Size = new System.Drawing.Size(157, 17);
            this.filterByActiveCheckbox.TabIndex = 5;
            this.filterByActiveCheckbox.Text = "Filter Deavtivated Accounts";
            this.filterByActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(297, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // viewUserButton
            // 
            this.viewUserButton.Location = new System.Drawing.Point(210, 61);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(75, 23);
            this.viewUserButton.TabIndex = 7;
            this.viewUserButton.Text = "View";
            this.viewUserButton.UseVisualStyleBackColor = true;
            this.viewUserButton.Click += new System.EventHandler(this.ViewUserButton_Click);
            this.viewUserButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.viewUserButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(120, 61);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(15, 61);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.viewUserButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filterByActiveCheckbox);
            this.Controls.Add(this.filterAdminCheckbox);
            this.Controls.Add(this.searchByUsernameLabel);
            this.Controls.Add(this.searchByNameTextbox);
            this.Controls.Add(this.displayUsersListbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUsersForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox displayUsersListbox;
        private System.Windows.Forms.TextBox searchByNameTextbox;
        private System.Windows.Forms.Label searchByUsernameLabel;
        private System.Windows.Forms.CheckBox filterAdminCheckbox;
        private System.Windows.Forms.CheckBox filterByActiveCheckbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button viewUserButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button returnButton;
    }
}
