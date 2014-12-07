namespace MovieOrganizer
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
            this.panel_MovieListing = new System.Windows.Forms.Panel();
            this.link_LOSI = new System.Windows.Forms.LinkLabel();
            this.lbl_LOSI = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlStrp_Genre = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Actor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Director = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Rating = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_RecentlyViewed = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_TimesWatched = new System.Windows.Forms.ToolStripMenuItem();
            this.label_panel = new System.Windows.Forms.Panel();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.link_pMain_pLibrary = new System.Windows.Forms.LinkLabel();
            this.pic_pMain_pLibrary = new System.Windows.Forms.PictureBox();
            this.link_pMain_pDataEntry = new System.Windows.Forms.LinkLabel();
            this.pic_pMain_pDataEntry = new System.Windows.Forms.PictureBox();
            this.pic_pMain_frmSuggest = new System.Windows.Forms.PictureBox();
            this.pic_pMain_pTagged = new System.Windows.Forms.PictureBox();
            this.link_pMain_frmSuggest = new System.Windows.Forms.LinkLabel();
            this.link_pMain_pTaggedSearch = new System.Windows.Forms.LinkLabel();
            this.lbl_WelcomeBanner = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.label_panel.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pDataEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_frmSuggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pTagged)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MovieListing
            // 
            this.panel_MovieListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MovieListing.AutoScroll = true;
            this.panel_MovieListing.Location = new System.Drawing.Point(127, 113);
            this.panel_MovieListing.Name = "panel_MovieListing";
            this.panel_MovieListing.Size = new System.Drawing.Size(467, 499);
            this.panel_MovieListing.TabIndex = 3;
            // 
            // link_LOSI
            // 
            this.link_LOSI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_LOSI.AutoSize = true;
            this.link_LOSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_LOSI.Location = new System.Drawing.Point(531, 6);
            this.link_LOSI.Name = "link_LOSI";
            this.link_LOSI.Size = new System.Drawing.Size(59, 17);
            this.link_LOSI.TabIndex = 0;
            this.link_LOSI.TabStop = true;
            this.link_LOSI.Text = "Log Out";
            // 
            // lbl_LOSI
            // 
            this.lbl_LOSI.AutoSize = true;
            this.lbl_LOSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LOSI.Location = new System.Drawing.Point(12, 6);
            this.lbl_LOSI.Name = "lbl_LOSI";
            this.lbl_LOSI.Size = new System.Drawing.Size(94, 17);
            this.lbl_LOSI.TabIndex = 1;
            this.lbl_LOSI.Text = "Logged in as:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(99, 6);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(101, 17);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Jack Harkness";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.lbl_Username);
            this.LoginPanel.Controls.Add(this.lbl_LOSI);
            this.LoginPanel.Controls.Add(this.link_LOSI);
            this.LoginPanel.Location = new System.Drawing.Point(0, 48);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(605, 33);
            this.LoginPanel.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(127, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 20);
            this.textBox1.TabIndex = 4;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(121, 500);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 87);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(121, 525);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrp_Genre,
            this.tlStrp_Actor,
            this.tlStrp_Director,
            this.tlStrp_Year,
            this.tlStrp_Rating,
            this.tlStrp_RecentlyViewed,
            this.tlStrp_TimesWatched});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(111, 139);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlStrp_Genre
            // 
            this.tlStrp_Genre.Name = "tlStrp_Genre";
            this.tlStrp_Genre.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Genre.Text = "Genre";
            this.tlStrp_Genre.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Actor
            // 
            this.tlStrp_Actor.Name = "tlStrp_Actor";
            this.tlStrp_Actor.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Actor.Text = "Actor";
            this.tlStrp_Actor.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Director
            // 
            this.tlStrp_Director.Name = "tlStrp_Director";
            this.tlStrp_Director.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Director.Text = "Director";
            this.tlStrp_Director.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Year
            // 
            this.tlStrp_Year.Name = "tlStrp_Year";
            this.tlStrp_Year.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Year.Text = "Year";
            this.tlStrp_Year.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Rating
            // 
            this.tlStrp_Rating.Name = "tlStrp_Rating";
            this.tlStrp_Rating.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Rating.Text = "Rating";
            this.tlStrp_Rating.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_RecentlyViewed
            // 
            this.tlStrp_RecentlyViewed.Name = "tlStrp_RecentlyViewed";
            this.tlStrp_RecentlyViewed.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_RecentlyViewed.Text = "Recently Viewed";
            this.tlStrp_RecentlyViewed.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_TimesWatched
            // 
            this.tlStrp_TimesWatched.Name = "tlStrp_TimesWatched";
            this.tlStrp_TimesWatched.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_TimesWatched.Text = "Times Watched";
            this.tlStrp_TimesWatched.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // label_panel
            // 
            this.label_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_panel.Controls.Add(this.lbl_SortBy);
            this.label_panel.Location = new System.Drawing.Point(0, 84);
            this.label_panel.Name = "label_panel";
            this.label_panel.Size = new System.Drawing.Size(121, 26);
            this.label_panel.TabIndex = 6;
            // 
            // lbl_SortBy
            // 
            this.lbl_SortBy.AutoSize = true;
            this.lbl_SortBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_SortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortBy.Location = new System.Drawing.Point(20, 3);
            this.lbl_SortBy.Name = "lbl_SortBy";
            this.lbl_SortBy.Size = new System.Drawing.Size(58, 17);
            this.lbl_SortBy.TabIndex = 1;
            this.lbl_SortBy.Text = "Sort By:";
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryPanel.Controls.Add(this.label_panel);
            this.LibraryPanel.Controls.Add(this.toolStripContainer1);
            this.LibraryPanel.Controls.Add(this.textBox1);
            this.LibraryPanel.Controls.Add(this.panel_MovieListing);
            this.LibraryPanel.Controls.Add(this.NavigationPanel);
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(605, 615);
            this.LibraryPanel.TabIndex = 2;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(605, 48);
            this.NavigationPanel.TabIndex = 2;
            // 
            // link_pMain_pLibrary
            // 
            this.link_pMain_pLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_pMain_pLibrary.AutoSize = true;
            this.link_pMain_pLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pMain_pLibrary.Location = new System.Drawing.Point(174, 138);
            this.link_pMain_pLibrary.Name = "link_pMain_pLibrary";
            this.link_pMain_pLibrary.Size = new System.Drawing.Size(340, 39);
            this.link_pMain_pLibrary.TabIndex = 2;
            this.link_pMain_pLibrary.TabStop = true;
            this.link_pMain_pLibrary.Text = "View Library / Search";
            this.link_pMain_pLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pMain_pLibrary_LinkClicked);
            // 
            // pic_pMain_pLibrary
            // 
            this.pic_pMain_pLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pLibrary.Location = new System.Drawing.Point(102, 125);
            this.pic_pMain_pLibrary.Name = "pic_pMain_pLibrary";
            this.pic_pMain_pLibrary.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pLibrary.TabIndex = 3;
            this.pic_pMain_pLibrary.TabStop = false;
            // 
            // link_pMain_pDataEntry
            // 
            this.link_pMain_pDataEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_pMain_pDataEntry.AutoSize = true;
            this.link_pMain_pDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pMain_pDataEntry.Location = new System.Drawing.Point(174, 206);
            this.link_pMain_pDataEntry.Name = "link_pMain_pDataEntry";
            this.link_pMain_pDataEntry.Size = new System.Drawing.Size(206, 39);
            this.link_pMain_pDataEntry.TabIndex = 4;
            this.link_pMain_pDataEntry.TabStop = true;
            this.link_pMain_pDataEntry.Text = "Add a Movie";
            this.link_pMain_pDataEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pMain_pDataEntry_LinkClicked);
            // 
            // pic_pMain_pDataEntry
            // 
            this.pic_pMain_pDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pDataEntry.Location = new System.Drawing.Point(102, 193);
            this.pic_pMain_pDataEntry.Name = "pic_pMain_pDataEntry";
            this.pic_pMain_pDataEntry.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pDataEntry.TabIndex = 5;
            this.pic_pMain_pDataEntry.TabStop = false;
            // 
            // pic_pMain_frmSuggest
            // 
            this.pic_pMain_frmSuggest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_frmSuggest.Location = new System.Drawing.Point(102, 261);
            this.pic_pMain_frmSuggest.Name = "pic_pMain_frmSuggest";
            this.pic_pMain_frmSuggest.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_frmSuggest.TabIndex = 6;
            this.pic_pMain_frmSuggest.TabStop = false;
            // 
            // pic_pMain_pTagged
            // 
            this.pic_pMain_pTagged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pTagged.Location = new System.Drawing.Point(102, 329);
            this.pic_pMain_pTagged.Name = "pic_pMain_pTagged";
            this.pic_pMain_pTagged.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pTagged.TabIndex = 7;
            this.pic_pMain_pTagged.TabStop = false;
            // 
            // link_pMain_frmSuggest
            // 
            this.link_pMain_frmSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_pMain_frmSuggest.AutoSize = true;
            this.link_pMain_frmSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pMain_frmSuggest.Location = new System.Drawing.Point(174, 274);
            this.link_pMain_frmSuggest.Name = "link_pMain_frmSuggest";
            this.link_pMain_frmSuggest.Size = new System.Drawing.Size(374, 39);
            this.link_pMain_frmSuggest.TabIndex = 8;
            this.link_pMain_frmSuggest.TabStop = true;
            this.link_pMain_frmSuggest.Text = "Suggest a Movie for Me";
            this.link_pMain_frmSuggest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pMain_frmSuggest_LinkClicked);
            // 
            // link_pMain_pTaggedSearch
            // 
            this.link_pMain_pTaggedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_pMain_pTaggedSearch.AutoSize = true;
            this.link_pMain_pTaggedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pMain_pTaggedSearch.Location = new System.Drawing.Point(174, 342);
            this.link_pMain_pTaggedSearch.Name = "link_pMain_pTaggedSearch";
            this.link_pMain_pTaggedSearch.Size = new System.Drawing.Size(250, 39);
            this.link_pMain_pTaggedSearch.TabIndex = 9;
            this.link_pMain_pTaggedSearch.TabStop = true;
            this.link_pMain_pTaggedSearch.Text = "Tagged Search";
            // 
            // lbl_WelcomeBanner
            // 
            this.lbl_WelcomeBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WelcomeBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_WelcomeBanner.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeBanner.Location = new System.Drawing.Point(0, 0);
            this.lbl_WelcomeBanner.Name = "lbl_WelcomeBanner";
            this.lbl_WelcomeBanner.Size = new System.Drawing.Size(605, 48);
            this.lbl_WelcomeBanner.TabIndex = 10;
            this.lbl_WelcomeBanner.Text = "Welcome to the Movie Organizer";
            this.lbl_WelcomeBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuPanel.Controls.Add(this.lbl_WelcomeBanner);
            this.MainMenuPanel.Controls.Add(this.link_pMain_pTaggedSearch);
            this.MainMenuPanel.Controls.Add(this.link_pMain_frmSuggest);
            this.MainMenuPanel.Controls.Add(this.pic_pMain_pTagged);
            this.MainMenuPanel.Controls.Add(this.pic_pMain_frmSuggest);
            this.MainMenuPanel.Controls.Add(this.pic_pMain_pDataEntry);
            this.MainMenuPanel.Controls.Add(this.link_pMain_pDataEntry);
            this.MainMenuPanel.Controls.Add(this.pic_pMain_pLibrary);
            this.MainMenuPanel.Controls.Add(this.link_pMain_pLibrary);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(605, 615);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LibraryPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "MainForm";
            this.Text = "Movie Organizer";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.label_panel.ResumeLayout(false);
            this.label_panel.PerformLayout();
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pDataEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_frmSuggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pTagged)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_LOSI;
        private System.Windows.Forms.Label lbl_LOSI;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Genre;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Actor;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Director;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Year;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Rating;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_RecentlyViewed;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_TimesWatched;
        private System.Windows.Forms.Panel label_panel;
        private System.Windows.Forms.Label lbl_SortBy;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.LinkLabel link_pMain_pLibrary;
        private System.Windows.Forms.PictureBox pic_pMain_pLibrary;
        private System.Windows.Forms.LinkLabel link_pMain_pDataEntry;
        private System.Windows.Forms.PictureBox pic_pMain_pDataEntry;
        private System.Windows.Forms.PictureBox pic_pMain_frmSuggest;
        private System.Windows.Forms.PictureBox pic_pMain_pTagged;
        private System.Windows.Forms.LinkLabel link_pMain_frmSuggest;
        private System.Windows.Forms.LinkLabel link_pMain_pTaggedSearch;
        private System.Windows.Forms.Label lbl_WelcomeBanner;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel panel_MovieListing;


    }
}

