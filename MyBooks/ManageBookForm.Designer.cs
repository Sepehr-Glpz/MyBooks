
namespace MyApplication
{
    partial class ManageBookForm
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
            this.userBooksListbox = new System.Windows.Forms.ListBox();
            this.descriptionTextbox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.writerNameTextbox = new System.Windows.Forms.TextBox();
            this.writerNameLabel = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreCombobox = new System.Windows.Forms.ComboBox();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.bookTypeCombobox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userBooksListbox
            // 
            this.userBooksListbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.userBooksListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userBooksListbox.FormattingEnabled = true;
            this.userBooksListbox.HorizontalScrollbar = true;
            this.userBooksListbox.ItemHeight = 15;
            this.userBooksListbox.Location = new System.Drawing.Point(0, 0);
            this.userBooksListbox.Name = "userBooksListbox";
            this.userBooksListbox.ScrollAlwaysVisible = true;
            this.userBooksListbox.Size = new System.Drawing.Size(330, 261);
            this.userBooksListbox.TabIndex = 15;
            this.userBooksListbox.SelectedIndexChanged += new System.EventHandler(this.UserBooksListbox_SelectedIndexChanged);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.descriptionTextbox.Location = new System.Drawing.Point(330, 147);
            this.descriptionTextbox.MaxLength = 1024;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(354, 114);
            this.descriptionTextbox.TabIndex = 11;
            this.descriptionTextbox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.descriptionLabel.Location = new System.Drawing.Point(336, 129);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Des&cription:";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bookNameLabel.Location = new System.Drawing.Point(336, 13);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(75, 15);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Book &Name:";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookNameTextbox.Location = new System.Drawing.Point(417, 12);
            this.bookNameTextbox.MaxLength = 30;
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(255, 20);
            this.bookNameTextbox.TabIndex = 1;
            // 
            // writerNameTextbox
            // 
            this.writerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writerNameTextbox.Location = new System.Drawing.Point(417, 38);
            this.writerNameTextbox.MaxLength = 30;
            this.writerNameTextbox.Name = "writerNameTextbox";
            this.writerNameTextbox.Size = new System.Drawing.Size(255, 20);
            this.writerNameTextbox.TabIndex = 3;
            // 
            // writerNameLabel
            // 
            this.writerNameLabel.AutoSize = true;
            this.writerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.writerNameLabel.Location = new System.Drawing.Point(363, 39);
            this.writerNameLabel.Name = "writerNameLabel";
            this.writerNameLabel.Size = new System.Drawing.Size(45, 15);
            this.writerNameLabel.TabIndex = 2;
            this.writerNameLabel.Text = "&Author:";
            // 
            // yearTextbox
            // 
            this.yearTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yearTextbox.Location = new System.Drawing.Point(417, 64);
            this.yearTextbox.MaxLength = 5;
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.ShortcutsEnabled = false;
            this.yearTextbox.Size = new System.Drawing.Size(70, 21);
            this.yearTextbox.TabIndex = 5;
            this.yearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTextbox_KeyPress);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yearLabel.Location = new System.Drawing.Point(332, 67);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(79, 15);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Publish &Year:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.genreLabel.Location = new System.Drawing.Point(493, 67);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(44, 15);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "&Genre:";
            // 
            // genreCombobox
            // 
            this.genreCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genreCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCombobox.FormattingEnabled = true;
            this.genreCombobox.Location = new System.Drawing.Point(543, 66);
            this.genreCombobox.Name = "genreCombobox";
            this.genreCombobox.Size = new System.Drawing.Size(129, 21);
            this.genreCombobox.TabIndex = 7;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.AutoSize = true;
            this.bookTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bookTypeLabel.Location = new System.Drawing.Point(341, 94);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.bookTypeLabel.TabIndex = 8;
            this.bookTypeLabel.Text = "Book &Type:";
            // 
            // bookTypeCombobox
            // 
            this.bookTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCombobox.FormattingEnabled = true;
            this.bookTypeCombobox.Location = new System.Drawing.Point(417, 93);
            this.bookTypeCombobox.Name = "bookTypeCombobox";
            this.bookTypeCombobox.Size = new System.Drawing.Size(120, 21);
            this.bookTypeCombobox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(417, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "&Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.Location = new System.Drawing.Point(597, 118);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "R&eturn";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(513, 118);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ManageBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bookTypeCombobox);
            this.Controls.Add(this.bookTypeLabel);
            this.Controls.Add(this.genreCombobox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.writerNameLabel);
            this.Controls.Add(this.writerNameTextbox);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.userBooksListbox);
            this.MaximumSize = new System.Drawing.Size(700, 750);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "ManageBookForm";
            this.Text = "Manage Your Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageBookForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userBooksListbox;
        private System.Windows.Forms.RichTextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.TextBox writerNameTextbox;
        private System.Windows.Forms.Label writerNameLabel;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreCombobox;
        private System.Windows.Forms.Label bookTypeLabel;
        private System.Windows.Forms.ComboBox bookTypeCombobox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
