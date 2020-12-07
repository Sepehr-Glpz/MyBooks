
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.displayBookListbox = new System.Windows.Forms.ListBox();
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
            this.searchByNameLabel.Text = "Search by Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // displayBookListbox
            // 
            this.displayBookListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayBookListbox.FormattingEnabled = true;
            this.displayBookListbox.HorizontalScrollbar = true;
            this.displayBookListbox.Location = new System.Drawing.Point(303, 0);
            this.displayBookListbox.Name = "displayBookListbox";
            this.displayBookListbox.ScrollAlwaysVisible = true;
            this.displayBookListbox.Size = new System.Drawing.Size(311, 311);
            this.displayBookListbox.TabIndex = 2;
            // 
            // OwnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(614, 311);
            this.Controls.Add(this.displayBookListbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchByNameLabel);
            this.Name = "OwnBookForm";
            this.Text = "Own Unwanted Book";
            this.Load += new System.EventHandler(this.OwnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox displayBookListbox;
    }
}
