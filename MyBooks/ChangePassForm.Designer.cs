
namespace MyApplication
{
    partial class ChangePassForm
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
            this.oldPasswordTextbox = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextbox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPasswordTextbox
            // 
            this.oldPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextbox.Location = new System.Drawing.Point(104, 12);
            this.oldPasswordTextbox.MaxLength = 25;
            this.oldPasswordTextbox.Name = "oldPasswordTextbox";
            this.oldPasswordTextbox.Size = new System.Drawing.Size(304, 20);
            this.oldPasswordTextbox.TabIndex = 1;
            this.oldPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.oldPasswordLabel.Location = new System.Drawing.Point(12, 13);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(86, 15);
            this.oldPasswordLabel.TabIndex = 0;
            this.oldPasswordLabel.Text = "Old Password:";
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextbox.Location = new System.Drawing.Point(104, 39);
            this.newPasswordTextbox.MaxLength = 25;
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(287, 20);
            this.newPasswordTextbox.TabIndex = 3;
            this.newPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newPasswordLabel.Location = new System.Drawing.Point(6, 40);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(92, 15);
            this.newPasswordLabel.TabIndex = 2;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // repeatPasswordTextbox
            // 
            this.repeatPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPasswordTextbox.Location = new System.Drawing.Point(104, 80);
            this.repeatPasswordTextbox.MaxLength = 25;
            this.repeatPasswordTextbox.Name = "repeatPasswordTextbox";
            this.repeatPasswordTextbox.Size = new System.Drawing.Size(304, 20);
            this.repeatPasswordTextbox.TabIndex = 5;
            this.repeatPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(12, 70);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(85, 35);
            this.repeatPasswordLabel.TabIndex = 4;
            this.repeatPasswordLabel.Text = "Repeat New\r\nPassword:";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.saveButton.Location = new System.Drawing.Point(104, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.resetButton.Location = new System.Drawing.Point(185, 106);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.returnButton.Location = new System.Drawing.Point(337, 106);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.Window;
            this.viewButton.Location = new System.Drawing.Point(392, 39);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(20, 20);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "👁";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 132);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.repeatPasswordTextbox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.oldPasswordTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 175);
            this.MinimumSize = new System.Drawing.Size(440, 175);
            this.Name = "ChangePassForm";
            this.Text = "Change Your Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangePassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPasswordTextbox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextbox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button viewButton;
    }
}
