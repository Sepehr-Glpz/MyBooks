
namespace MyApplication
{
    partial class AddBookForm
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
            this.descriptionTextbox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.writerNameLabel = new System.Windows.Forms.Label();
            this.writerNameTextbox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genresCombobox = new System.Windows.Forms.ComboBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.ownerCombobox = new System.Windows.Forms.ComboBox();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.bookTypeCombobox = new System.Windows.Forms.ComboBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.bookNameLabel.Location = new System.Drawing.Point(4, 15);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(83, 16);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Book Name:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.descriptionTextbox.Location = new System.Drawing.Point(445, 0);
            this.descriptionTextbox.MaxLength = 1024;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(259, 166);
            this.descriptionTextbox.TabIndex = 1;
            this.descriptionTextbox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(367, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookNameTextbox.Location = new System.Drawing.Point(93, 12);
            this.bookNameTextbox.MaxLength = 25;
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(268, 21);
            this.bookNameTextbox.TabIndex = 3;
            // 
            // writerNameLabel
            // 
            this.writerNameLabel.AutoSize = true;
            this.writerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.writerNameLabel.Location = new System.Drawing.Point(12, 42);
            this.writerNameLabel.Name = "writerNameLabel";
            this.writerNameLabel.Size = new System.Drawing.Size(49, 16);
            this.writerNameLabel.TabIndex = 4;
            this.writerNameLabel.Text = "Author:";
            // 
            // writerNameTextbox
            // 
            this.writerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writerNameTextbox.Location = new System.Drawing.Point(93, 39);
            this.writerNameTextbox.MaxLength = 20;
            this.writerNameTextbox.Name = "writerNameTextbox";
            this.writerNameTextbox.Size = new System.Drawing.Size(346, 21);
            this.writerNameTextbox.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(4, 69);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(79, 15);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Publish Year:";
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(93, 66);
            this.yearTextbox.MaxLength = 5;
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.ShortcutsEnabled = false;
            this.yearTextbox.Size = new System.Drawing.Size(97, 21);
            this.yearTextbox.TabIndex = 7;
            this.yearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTextbox_KeyPress);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.genreLabel.Location = new System.Drawing.Point(196, 69);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(48, 16);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genre:";
            // 
            // genresCombobox
            // 
            this.genresCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genresCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genresCombobox.FormattingEnabled = true;
            this.genresCombobox.Location = new System.Drawing.Point(250, 66);
            this.genresCombobox.Name = "genresCombobox";
            this.genresCombobox.Size = new System.Drawing.Size(189, 23);
            this.genresCombobox.TabIndex = 9;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(4, 96);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(77, 15);
            this.ownerLabel.TabIndex = 10;
            this.ownerLabel.Text = "Book Owner:";
            // 
            // ownerCombobox
            // 
            this.ownerCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerCombobox.FormattingEnabled = true;
            this.ownerCombobox.Location = new System.Drawing.Point(93, 93);
            this.ownerCombobox.Name = "ownerCombobox";
            this.ownerCombobox.Size = new System.Drawing.Size(97, 23);
            this.ownerCombobox.TabIndex = 11;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTypeLabel.AutoSize = true;
            this.bookTypeLabel.Location = new System.Drawing.Point(196, 98);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.bookTypeLabel.TabIndex = 12;
            this.bookTypeLabel.Text = "Book Type:";
            // 
            // bookTypeCombobox
            // 
            this.bookTypeCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCombobox.FormattingEnabled = true;
            this.bookTypeCombobox.Location = new System.Drawing.Point(269, 95);
            this.bookTypeCombobox.Name = "bookTypeCombobox";
            this.bookTypeCombobox.Size = new System.Drawing.Size(170, 23);
            this.bookTypeCombobox.TabIndex = 13;
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBookButton.Location = new System.Drawing.Point(93, 129);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(90, 25);
            this.addBookButton.TabIndex = 14;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            this.addBookButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.addBookButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(269, 129);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(704, 166);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.bookTypeCombobox);
            this.Controls.Add(this.bookTypeLabel);
            this.Controls.Add(this.ownerCombobox);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.genresCombobox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.writerNameTextbox);
            this.Controls.Add(this.writerNameLabel);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.bookNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MaximumSize = new System.Drawing.Size(840, 375);
            this.MinimumSize = new System.Drawing.Size(720, 205);
            this.Name = "AddBookForm";
            this.Text = "Add a new Book";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBookForm_FormClosing);
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.RichTextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.Label writerNameLabel;
        private System.Windows.Forms.TextBox writerNameTextbox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genresCombobox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.ComboBox ownerCombobox;
        private System.Windows.Forms.Label bookTypeLabel;
        private System.Windows.Forms.ComboBox bookTypeCombobox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button resetButton;
    }
}
