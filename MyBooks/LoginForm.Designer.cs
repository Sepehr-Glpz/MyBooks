namespace MyApplication
{
    partial class LoginForm
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
            this.usernameLable = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordVisibleButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLable.Location = new System.Drawing.Point(12, 13);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(78, 16);
            this.usernameLable.TabIndex = 0;
            this.usernameLable.Text = "&Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(96, 12);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(382, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.passwordLabel.Location = new System.Drawing.Point(12, 38);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "&Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(96, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(357, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordVisibleButton
            // 
            this.passwordVisibleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordVisibleButton.BackColor = System.Drawing.SystemColors.Window;
            this.passwordVisibleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVisibleButton.Location = new System.Drawing.Point(453, 38);
            this.passwordVisibleButton.Name = "passwordVisibleButton";
            this.passwordVisibleButton.Size = new System.Drawing.Size(25, 20);
            this.passwordVisibleButton.TabIndex = 4;
            this.passwordVisibleButton.Text = "👁";
            this.passwordVisibleButton.UseVisualStyleBackColor = false;
            this.passwordVisibleButton.Click += new System.EventHandler(this.PasswordVisibleButton_Click);
            this.passwordVisibleButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.passwordVisibleButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Khaki;
            this.loginButton.Location = new System.Drawing.Point(96, 64);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(70, 25);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Khaki;
            this.resetButton.Location = new System.Drawing.Point(200, 64);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(70, 25);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Re&set";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Khaki;
            this.registerButton.Location = new System.Drawing.Point(304, 64);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(70, 25);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "&Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Khaki;
            this.exitButton.Location = new System.Drawing.Point(408, 64);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 25);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(490, 97);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordVisibleButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaximumSize = new System.Drawing.Size(810, 140);
            this.MinimumSize = new System.Drawing.Size(510, 140);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button passwordVisibleButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
    }
}
