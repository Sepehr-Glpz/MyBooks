
namespace MyApplication
{
    partial class OwnBookForm
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
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.searchByNameTextbox = new System.Windows.Forms.TextBox();
            this.displayBookListbox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ownButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchByNameLabel.Location = new System.Drawing.Point(12, 13);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(101, 15);
            this.searchByNameLabel.TabIndex = 0;
            this.searchByNameLabel.Text = "Search by &Name:";
            // 
            // searchByNameTextbox
            // 
            this.searchByNameTextbox.Location = new System.Drawing.Point(119, 12);
            this.searchByNameTextbox.MaxLength = 30;
            this.searchByNameTextbox.Name = "searchByNameTextbox";
            this.searchByNameTextbox.Size = new System.Drawing.Size(178, 20);
            this.searchByNameTextbox.TabIndex = 1;
            // 
            // displayBookListbox
            // 
            this.displayBookListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayBookListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.displayBookListbox.FormattingEnabled = true;
            this.displayBookListbox.HorizontalScrollbar = true;
            this.displayBookListbox.ItemHeight = 15;
            this.displayBookListbox.Location = new System.Drawing.Point(303, 0);
            this.displayBookListbox.Name = "displayBookListbox";
            this.displayBookListbox.ScrollAlwaysVisible = true;
            this.displayBookListbox.Size = new System.Drawing.Size(311, 191);
            this.displayBookListbox.TabIndex = 2;
            this.displayBookListbox.DoubleClick += new System.EventHandler(this.DisplayBookListbox_DoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(222, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ownButton
            // 
            this.ownButton.Location = new System.Drawing.Point(119, 38);
            this.ownButton.Name = "ownButton";
            this.ownButton.Size = new System.Drawing.Size(97, 23);
            this.ownButton.TabIndex = 4;
            this.ownButton.Text = "&Own Book";
            this.ownButton.UseVisualStyleBackColor = true;
            this.ownButton.Click += new System.EventHandler(this.OwnButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnButton.Location = new System.Drawing.Point(222, 156);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "&Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // OwnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(614, 191);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ownButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.displayBookListbox);
            this.Controls.Add(this.searchByNameTextbox);
            this.Controls.Add(this.searchByNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 530);
            this.MinimumSize = new System.Drawing.Size(630, 230);
            this.Name = "OwnBookForm";
            this.Text = "Own Unwanted Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnBookForm_FormClosing);
            this.Load += new System.EventHandler(this.OwnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.TextBox searchByNameTextbox;
        private System.Windows.Forms.ListBox displayBookListbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button ownButton;
        private System.Windows.Forms.Button returnButton;
    }
}
