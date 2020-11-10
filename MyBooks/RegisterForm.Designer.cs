﻿namespace MyApplication
{
    partial class RegisterForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordVisibleButton = new System.Windows.Forms.Button();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.usernameLabel.Location = new System.Drawing.Point(12, 13);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(78, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "&Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextbox.Location = new System.Drawing.Point(96, 12);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(382, 20);
            this.usernameTextbox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.passwordLabel.Location = new System.Drawing.Point(12, 51);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "&Password:";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.Location = new System.Drawing.Point(96, 50);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(357, 20);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordVisibleButton
            // 
            this.passwordVisibleButton.BackColor = System.Drawing.SystemColors.Window;
            this.passwordVisibleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordVisibleButton.Location = new System.Drawing.Point(453, 50);
            this.passwordVisibleButton.Name = "passwordVisibleButton";
            this.passwordVisibleButton.Size = new System.Drawing.Size(25, 20);
            this.passwordVisibleButton.TabIndex = 4;
            this.passwordVisibleButton.Text = "👁";
            this.passwordVisibleButton.UseVisualStyleBackColor = false;
            this.passwordVisibleButton.Click += new System.EventHandler(this.PasswordVisibleButton_Click);
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(12, 76);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(76, 32);
            this.repeatPasswordLabel.TabIndex = 5;
            this.repeatPasswordLabel.Text = "R&epeat\r\nPassword:";
            // 
            // repeatPasswordTextbox
            // 
            this.repeatPasswordTextbox.Location = new System.Drawing.Point(96, 88);
            this.repeatPasswordTextbox.Name = "repeatPasswordTextbox";
            this.repeatPasswordTextbox.Size = new System.Drawing.Size(382, 20);
            this.repeatPasswordTextbox.TabIndex = 6;
            this.repeatPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(490, 157);
            this.Controls.Add(this.repeatPasswordTextbox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordVisibleButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button passwordVisibleButton;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextbox;
    }
}
