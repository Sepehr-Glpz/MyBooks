
namespace MyApplication
{
    partial class DisplayBookForm
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
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.writerNameLabel = new System.Windows.Forms.Label();
            this.writerNameTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.bookGenreLabel = new System.Windows.Forms.Label();
            this.bookGenreTextbox = new System.Windows.Forms.TextBox();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.bookTypeTextbox = new System.Windows.Forms.TextBox();
            this.ownerUsernameLabel = new System.Windows.Forms.Label();
            this.ownerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.ownerFullnameLabel = new System.Windows.Forms.Label();
            this.ownerFullnameTextbox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bookNameLabel.Location = new System.Drawing.Point(12, 13);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(85, 17);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Book Name:";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bookNameTextbox.Location = new System.Drawing.Point(103, 10);
            this.bookNameTextbox.MaxLength = 25;
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.ReadOnly = true;
            this.bookNameTextbox.Size = new System.Drawing.Size(150, 21);
            this.bookNameTextbox.TabIndex = 1;
            // 
            // writerNameLabel
            // 
            this.writerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.writerNameLabel.AutoSize = true;
            this.writerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.writerNameLabel.Location = new System.Drawing.Point(259, 13);
            this.writerNameLabel.Name = "writerNameLabel";
            this.writerNameLabel.Size = new System.Drawing.Size(54, 17);
            this.writerNameLabel.TabIndex = 2;
            this.writerNameLabel.Text = "Author:";
            // 
            // writerNameTextbox
            // 
            this.writerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.writerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.writerNameTextbox.Location = new System.Drawing.Point(319, 10);
            this.writerNameTextbox.MaxLength = 20;
            this.writerNameTextbox.Name = "writerNameTextbox";
            this.writerNameTextbox.ReadOnly = true;
            this.writerNameTextbox.Size = new System.Drawing.Size(153, 21);
            this.writerNameTextbox.TabIndex = 3;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionTextbox.Location = new System.Drawing.Point(0, 146);
            this.descriptionTextbox.MaxLength = 1024;
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextbox.Size = new System.Drawing.Size(484, 115);
            this.descriptionTextbox.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionLabel.Location = new System.Drawing.Point(12, 126);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // bookGenreLabel
            // 
            this.bookGenreLabel.AutoSize = true;
            this.bookGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bookGenreLabel.Location = new System.Drawing.Point(12, 47);
            this.bookGenreLabel.Name = "bookGenreLabel";
            this.bookGenreLabel.Size = new System.Drawing.Size(52, 17);
            this.bookGenreLabel.TabIndex = 4;
            this.bookGenreLabel.Text = "Genre:";
            // 
            // bookGenreTextbox
            // 
            this.bookGenreTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookGenreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bookGenreTextbox.Location = new System.Drawing.Point(70, 46);
            this.bookGenreTextbox.MaxLength = 30;
            this.bookGenreTextbox.Name = "bookGenreTextbox";
            this.bookGenreTextbox.ReadOnly = true;
            this.bookGenreTextbox.Size = new System.Drawing.Size(100, 21);
            this.bookGenreTextbox.TabIndex = 5;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTypeLabel.AutoSize = true;
            this.bookTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bookTypeLabel.Location = new System.Drawing.Point(176, 47);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(80, 17);
            this.bookTypeLabel.TabIndex = 6;
            this.bookTypeLabel.Text = "Book Type:";
            // 
            // bookTypeTextbox
            // 
            this.bookTypeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bookTypeTextbox.Location = new System.Drawing.Point(262, 46);
            this.bookTypeTextbox.MaxLength = 30;
            this.bookTypeTextbox.Name = "bookTypeTextbox";
            this.bookTypeTextbox.ReadOnly = true;
            this.bookTypeTextbox.Size = new System.Drawing.Size(90, 21);
            this.bookTypeTextbox.TabIndex = 7;
            // 
            // ownerUsernameLabel
            // 
            this.ownerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ownerUsernameLabel.Location = new System.Drawing.Point(12, 79);
            this.ownerUsernameLabel.Name = "ownerUsernameLabel";
            this.ownerUsernameLabel.Size = new System.Drawing.Size(85, 35);
            this.ownerUsernameLabel.TabIndex = 10;
            this.ownerUsernameLabel.Text = "Owner Username:";
            // 
            // ownerUsernameTextbox
            // 
            this.ownerUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ownerUsernameTextbox.Location = new System.Drawing.Point(103, 93);
            this.ownerUsernameTextbox.MaxLength = 30;
            this.ownerUsernameTextbox.Name = "ownerUsernameTextbox";
            this.ownerUsernameTextbox.ReadOnly = true;
            this.ownerUsernameTextbox.Size = new System.Drawing.Size(116, 21);
            this.ownerUsernameTextbox.TabIndex = 11;
            // 
            // ownerFullnameLabel
            // 
            this.ownerFullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ownerFullnameLabel.Location = new System.Drawing.Point(225, 79);
            this.ownerFullnameLabel.Name = "ownerFullnameLabel";
            this.ownerFullnameLabel.Size = new System.Drawing.Size(75, 35);
            this.ownerFullnameLabel.TabIndex = 12;
            this.ownerFullnameLabel.Text = "Owner Fullname:";
            // 
            // ownerFullnameTextbox
            // 
            this.ownerFullnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ownerFullnameTextbox.Location = new System.Drawing.Point(306, 95);
            this.ownerFullnameTextbox.MaxLength = 30;
            this.ownerFullnameTextbox.Name = "ownerFullnameTextbox";
            this.ownerFullnameTextbox.ReadOnly = true;
            this.ownerFullnameTextbox.Size = new System.Drawing.Size(166, 21);
            this.ownerFullnameTextbox.TabIndex = 13;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.returnButton.Location = new System.Drawing.Point(397, 118);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 25);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yearLabel.Location = new System.Drawing.Point(358, 46);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(55, 35);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Publish Year:";
            // 
            // yearTextbox
            // 
            this.yearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yearTextbox.Location = new System.Drawing.Point(419, 47);
            this.yearTextbox.MaxLength = 5;
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.ReadOnly = true;
            this.yearTextbox.Size = new System.Drawing.Size(53, 21);
            this.yearTextbox.TabIndex = 9;
            // 
            // DisplayBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ownerFullnameTextbox);
            this.Controls.Add(this.ownerFullnameLabel);
            this.Controls.Add(this.ownerUsernameTextbox);
            this.Controls.Add(this.ownerUsernameLabel);
            this.Controls.Add(this.bookTypeTextbox);
            this.Controls.Add(this.bookTypeLabel);
            this.Controls.Add(this.bookGenreTextbox);
            this.Controls.Add(this.bookGenreLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.writerNameTextbox);
            this.Controls.Add(this.writerNameLabel);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.bookNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayBookForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayBookForm_FormClosing);
            this.Load += new System.EventHandler(this.DisplayBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.Label writerNameLabel;
        private System.Windows.Forms.TextBox writerNameTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label bookGenreLabel;
        private System.Windows.Forms.TextBox bookGenreTextbox;
        private System.Windows.Forms.Label bookTypeLabel;
        private System.Windows.Forms.TextBox bookTypeTextbox;
        private System.Windows.Forms.Label ownerUsernameLabel;
        private System.Windows.Forms.TextBox ownerUsernameTextbox;
        private System.Windows.Forms.Label ownerFullnameLabel;
        private System.Windows.Forms.TextBox ownerFullnameTextbox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextbox;
    }
}
