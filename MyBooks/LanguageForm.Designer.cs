namespace MyApplication
{
    public partial class LanguageForm : Infrastructure.BaseForm
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
            this.languageLabel = new System.Windows.Forms.Label();
            this.englishButton = new System.Windows.Forms.Button();
            this.persianButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.languageLabel.Location = new System.Drawing.Point(12, 9);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(202, 17);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "Please Choose your language:";
            // 
            // englishButton
            // 
            this.englishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.englishButton.BackColor = System.Drawing.Color.Khaki;
            this.englishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.englishButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.englishButton.Location = new System.Drawing.Point(100, 50);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(160, 23);
            this.englishButton.TabIndex = 1;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.LanguageButton_Click);
            this.englishButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.englishButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // persianButton
            // 
            this.persianButton.BackColor = System.Drawing.Color.Khaki;
            this.persianButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianButton.Location = new System.Drawing.Point(100, 100);
            this.persianButton.Name = "persianButton";
            this.persianButton.Size = new System.Drawing.Size(160, 23);
            this.persianButton.TabIndex = 2;
            this.persianButton.Text = "فارسی";
            this.persianButton.UseVisualStyleBackColor = false;
            this.persianButton.Click += new System.EventHandler(this.LanguageButton_Click);
            this.persianButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.persianButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(340, 157);
            this.Controls.Add(this.persianButton);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.languageLabel);
            this.MaximumSize = new System.Drawing.Size(360, 200);
            this.MinimumSize = new System.Drawing.Size(360, 200);
            this.Name = "LanguageForm";
            this.Text = "Language";
            this.Load += new System.EventHandler(this.LanguageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button persianButton;
    }
}
