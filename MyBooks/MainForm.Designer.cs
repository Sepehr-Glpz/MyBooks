
namespace MyApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripBooksOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettingOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdminOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userWelcomeMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.messageStatusStrip = new System.Windows.Forms.StatusStrip();
            this.displayBooksListbox = new System.Windows.Forms.ListBox();
            this.userOptionsMenuStrip.SuspendLayout();
            this.messageStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBooksOption
            // 
            this.toolStripBooksOption.Name = "toolStripBooksOption";
            this.toolStripBooksOption.Size = new System.Drawing.Size(51, 20);
            this.toolStripBooksOption.Text = "&Books";
            // 
            // toolStripUserOption
            // 
            this.toolStripUserOption.Name = "toolStripUserOption";
            this.toolStripUserOption.Size = new System.Drawing.Size(87, 20);
            this.toolStripUserOption.Text = "&User Options";
            // 
            // toolStripSettingOptions
            // 
            this.toolStripSettingOptions.Name = "toolStripSettingOptions";
            this.toolStripSettingOptions.Size = new System.Drawing.Size(56, 20);
            this.toolStripSettingOptions.Text = "&Setting";
            // 
            // toolStripAdminOptions
            // 
            this.toolStripAdminOptions.Name = "toolStripAdminOptions";
            this.toolStripAdminOptions.Size = new System.Drawing.Size(55, 20);
            this.toolStripAdminOptions.Text = "&Admin";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // userOptionsMenuStrip
            // 
            this.userOptionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBooksOption,
            this.toolStripUserOption,
            this.toolStripSettingOptions,
            this.toolStripAdminOptions,
            this.exitToolStripMenuItem});
            this.userOptionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.userOptionsMenuStrip.Name = "userOptionsMenuStrip";
            this.userOptionsMenuStrip.Size = new System.Drawing.Size(564, 24);
            this.userOptionsMenuStrip.TabIndex = 2;
            this.userOptionsMenuStrip.Text = "---";
            // 
            // userWelcomeMessageLabel
            // 
            this.userWelcomeMessageLabel.Name = "userWelcomeMessageLabel";
            this.userWelcomeMessageLabel.Size = new System.Drawing.Size(22, 17);
            this.userWelcomeMessageLabel.Text = "---";
            // 
            // messageStatusStrip
            // 
            this.messageStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userWelcomeMessageLabel});
            this.messageStatusStrip.Location = new System.Drawing.Point(0, 319);
            this.messageStatusStrip.Name = "messageStatusStrip";
            this.messageStatusStrip.Size = new System.Drawing.Size(564, 22);
            this.messageStatusStrip.TabIndex = 1;
            this.messageStatusStrip.Text = "statusStrip1";
            // 
            // displayBooksListbox
            // 
            this.displayBooksListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBooksListbox.FormattingEnabled = true;
            this.displayBooksListbox.HorizontalScrollbar = true;
            this.displayBooksListbox.ItemHeight = 15;
            this.displayBooksListbox.Location = new System.Drawing.Point(0, 27);
            this.displayBooksListbox.Name = "displayBooksListbox";
            this.displayBooksListbox.Size = new System.Drawing.Size(303, 289);
            this.displayBooksListbox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(564, 341);
            this.Controls.Add(this.displayBooksListbox);
            this.Controls.Add(this.messageStatusStrip);
            this.Controls.Add(this.userOptionsMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.userOptionsMenuStrip;
            this.MinimumSize = new System.Drawing.Size(580, 380);
            this.Name = "MainForm";
            this.Text = "Book Library Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.userOptionsMenuStrip.ResumeLayout(false);
            this.userOptionsMenuStrip.PerformLayout();
            this.messageStatusStrip.ResumeLayout(false);
            this.messageStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bool IsHidden;
        private System.Windows.Forms.ToolStripMenuItem toolStripBooksOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettingOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdminOptions;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip userOptionsMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel userWelcomeMessageLabel;
        private System.Windows.Forms.StatusStrip messageStatusStrip;
        private System.Windows.Forms.ListBox displayBooksListbox;
    }
}