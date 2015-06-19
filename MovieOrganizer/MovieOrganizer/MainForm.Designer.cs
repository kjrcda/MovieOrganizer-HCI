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
            this.MovieListingPanel = new System.Windows.Forms.Panel();
            this.linkLOSI = new System.Windows.Forms.LinkLabel();
            this.lblLOSI = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tlsContainer = new System.Windows.Forms.ToolStripContainer();
            this.lnkWishlist = new System.Windows.Forms.LinkLabel();
            this.lnkGive = new System.Windows.Forms.LinkLabel();
            this.lnkWatchNext = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mnsStrip = new System.Windows.Forms.MenuStrip();
            this.tlsGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsActor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDirector = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRating = new System.Windows.Forms.ToolStripMenuItem();
            this.tl5Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tl4Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tl3Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tl2Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tl1Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tl0Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.tlAllStars = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRecentlyViewed = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsTimesWatched = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.lnkMainLibrary = new System.Windows.Forms.LinkLabel();
            this.picMainLibrary = new System.Windows.Forms.PictureBox();
            this.lnkMainDataEntry = new System.Windows.Forms.LinkLabel();
            this.picMainDataEntry = new System.Windows.Forms.PictureBox();
            this.picMainSuggest = new System.Windows.Forms.PictureBox();
            this.picMainTaggedSearch = new System.Windows.Forms.PictureBox();
            this.lnkMainSuggest = new System.Windows.Forms.LinkLabel();
            this.lnkMainTaggedSearch = new System.Windows.Forms.LinkLabel();
            this.lblWelcomeBanner = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.lnkLibrary = new System.Windows.Forms.LinkLabel();
            this.lnkAddMovie = new System.Windows.Forms.LinkLabel();
            this.lnkSuggest = new System.Windows.Forms.LinkLabel();
            this.lnkTaggedSearch = new System.Windows.Forms.LinkLabel();
            this.NavigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TagPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstToSearch = new System.Windows.Forms.ListBox();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.lstTagsAvailable = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.tlsContainer.ContentPanel.SuspendLayout();
            this.tlsContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnsStrip.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDataEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainSuggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainTaggedSearch)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.TagPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MovieListing
            // 
            this.MovieListingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieListingPanel.AutoScroll = true;
            this.MovieListingPanel.Location = new System.Drawing.Point(127, 113);
            this.MovieListingPanel.Name = "panel_MovieListing";
            this.MovieListingPanel.Size = new System.Drawing.Size(474, 499);
            this.MovieListingPanel.TabIndex = 3;
            // 
            // link_LOSI
            // 
            this.linkLOSI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLOSI.AutoSize = true;
            this.linkLOSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLOSI.Location = new System.Drawing.Point(538, 6);
            this.linkLOSI.Name = "link_LOSI";
            this.linkLOSI.Size = new System.Drawing.Size(59, 17);
            this.linkLOSI.TabIndex = 0;
            this.linkLOSI.TabStop = true;
            this.linkLOSI.Text = "Log Out";
            // 
            // lbl_LOSI
            // 
            this.lblLOSI.AutoSize = true;
            this.lblLOSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOSI.Location = new System.Drawing.Point(12, 6);
            this.lblLOSI.Name = "lbl_LOSI";
            this.lblLOSI.Size = new System.Drawing.Size(94, 17);
            this.lblLOSI.TabIndex = 1;
            this.lblLOSI.Text = "Logged in as:";
            // 
            // lbl_Username
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(99, 6);
            this.lblUsername.Name = "lbl_Username";
            this.lblUsername.Size = new System.Drawing.Size(101, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Jack Harkness";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.lblUsername);
            this.LoginPanel.Controls.Add(this.lblLOSI);
            this.LoginPanel.Controls.Add(this.linkLOSI);
            this.LoginPanel.Location = new System.Drawing.Point(0, 48);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(612, 33);
            this.LoginPanel.TabIndex = 10;
            // 
            // txt_Search
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(127, 87);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txt_Search";
            this.txtSearch.Size = new System.Drawing.Size(474, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripContainer1
            // 
            this.tlsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.tlsContainer.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlsContainer.ContentPanel.Controls.Add(this.lnkWishlist);
            this.tlsContainer.ContentPanel.Controls.Add(this.lnkGive);
            this.tlsContainer.ContentPanel.Controls.Add(this.lnkWatchNext);
            this.tlsContainer.ContentPanel.Controls.Add(this.panel1);
            this.tlsContainer.ContentPanel.Controls.Add(this.mnsStrip);
            this.tlsContainer.ContentPanel.Size = new System.Drawing.Size(121, 500);
            this.tlsContainer.Location = new System.Drawing.Point(0, 87);
            this.tlsContainer.Name = "toolStripContainer1";
            this.tlsContainer.Size = new System.Drawing.Size(121, 525);
            this.tlsContainer.TabIndex = 5;
            this.tlsContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.tlsContainer.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            // 
            // lnk_Wishlist
            // 
            this.lnkWishlist.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkWishlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkWishlist.AutoSize = true;
            this.lnkWishlist.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWishlist.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkWishlist.LinkColor = System.Drawing.Color.Black;
            this.lnkWishlist.Location = new System.Drawing.Point(16, 270);
            this.lnkWishlist.Name = "lnk_Wishlist";
            this.lnkWishlist.Size = new System.Drawing.Size(82, 16);
            this.lnkWishlist.TabIndex = 10;
            this.lnkWishlist.TabStop = true;
            this.lnkWishlist.Text = "My Wishlist";
            this.lnkWishlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkWishlist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWishlist_LinkClicked);
            // 
            // lnk_Give
            // 
            this.lnkGive.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkGive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGive.AutoSize = true;
            this.lnkGive.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGive.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkGive.LinkColor = System.Drawing.Color.Black;
            this.lnkGive.Location = new System.Drawing.Point(16, 252);
            this.lnkGive.Name = "lnk_Give";
            this.lnkGive.Size = new System.Drawing.Size(81, 16);
            this.lnkGive.TabIndex = 9;
            this.lnkGive.TabStop = true;
            this.lnkGive.Text = "Gift Movies";
            this.lnkGive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkGive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGive_LinkClicked);
            // 
            // lnk_WatchNext
            // 
            this.lnkWatchNext.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkWatchNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkWatchNext.AutoSize = true;
            this.lnkWatchNext.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWatchNext.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkWatchNext.LinkColor = System.Drawing.Color.Black;
            this.lnkWatchNext.Location = new System.Drawing.Point(16, 233);
            this.lnkWatchNext.Name = "lnk_WatchNext";
            this.lnkWatchNext.Size = new System.Drawing.Size(86, 16);
            this.lnkWatchNext.TabIndex = 8;
            this.lnkWatchNext.TabStop = true;
            this.lnkWatchNext.Text = "Watch Next";
            this.lnkWatchNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkWatchNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWatchNext_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 26);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Lists";
            // 
            // menuStrip1
            // 
            this.mnsStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsGenre,
            this.tlsActor,
            this.tlsDirector,
            this.tlsYear,
            this.tlsRating,
            this.tlsRecentlyViewed,
            this.tlsTimesWatched});
            this.mnsStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnsStrip.Location = new System.Drawing.Point(3, 18);
            this.mnsStrip.Name = "menuStrip1";
            this.mnsStrip.Size = new System.Drawing.Size(111, 139);
            this.mnsStrip.TabIndex = 0;
            this.mnsStrip.Text = "menuStrip1";
            // 
            // tlStrp_Genre
            // 
            this.tlsGenre.Name = "tlStrp_Genre";
            this.tlsGenre.Size = new System.Drawing.Size(104, 19);
            this.tlsGenre.Text = "Genre";
            this.tlsGenre.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Actor
            // 
            this.tlsActor.Name = "tlStrp_Actor";
            this.tlsActor.Size = new System.Drawing.Size(104, 19);
            this.tlsActor.Text = "Actor";
            this.tlsActor.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Director
            // 
            this.tlsDirector.Name = "tlStrp_Director";
            this.tlsDirector.Size = new System.Drawing.Size(104, 19);
            this.tlsDirector.Text = "Director";
            this.tlsDirector.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Year
            // 
            this.tlsYear.Name = "tlStrp_Year";
            this.tlsYear.Size = new System.Drawing.Size(104, 19);
            this.tlsYear.Text = "Year";
            this.tlsYear.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tlStrp_Rating
            // 
            this.tlsRating.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tl5Stars,
            this.tl4Stars,
            this.tl3Stars,
            this.tl2Stars,
            this.tl1Stars,
            this.tl0Stars,
            this.tlAllStars});
            this.tlsRating.Name = "tlStrp_Rating";
            this.tlsRating.Size = new System.Drawing.Size(104, 19);
            this.tlsRating.Text = "Rating";
            this.tlsRating.Click += new System.EventHandler(this.tlStrp_Click);
            // 
            // tool_5Stars
            // 
            this.tl5Stars.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl5Stars.Name = "tool_5Stars";
            this.tl5Stars.Size = new System.Drawing.Size(136, 24);
            this.tl5Stars.Text = "★★★★★";
            this.tl5Stars.Click += new System.EventHandler(this.tl5Stars_Click);
            // 
            // tool_4Stars
            // 
            this.tl4Stars.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl4Stars.Name = "tool_4Stars";
            this.tl4Stars.Size = new System.Drawing.Size(136, 24);
            this.tl4Stars.Text = "★★★★";
            this.tl4Stars.Click += new System.EventHandler(this.tl4Stars_Click);
            // 
            // tool_3Stars
            // 
            this.tl3Stars.Font = new System.Drawing.Font("Mistral", 12F);
            this.tl3Stars.Name = "tool_3Stars";
            this.tl3Stars.Size = new System.Drawing.Size(136, 24);
            this.tl3Stars.Text = "★★★";
            this.tl3Stars.Click += new System.EventHandler(this.tl3Stars_Click);
            // 
            // tool_2Stars
            // 
            this.tl2Stars.Font = new System.Drawing.Font("Mistral", 12F);
            this.tl2Stars.Name = "tool_2Stars";
            this.tl2Stars.Size = new System.Drawing.Size(136, 24);
            this.tl2Stars.Text = "★★";
            this.tl2Stars.Click += new System.EventHandler(this.tl2Stars_Click);
            // 
            // tool_1Stars
            // 
            this.tl1Stars.Font = new System.Drawing.Font("Mistral", 12F);
            this.tl1Stars.Name = "tool_1Stars";
            this.tl1Stars.Size = new System.Drawing.Size(136, 24);
            this.tl1Stars.Text = "★";
            this.tl1Stars.Click += new System.EventHandler(this.tl1Stars_Click);
            // 
            // tool_0Stars
            // 
            this.tl0Stars.Font = new System.Drawing.Font("Mistral", 12F);
            this.tl0Stars.Name = "tool_0Stars";
            this.tl0Stars.Size = new System.Drawing.Size(136, 24);
            this.tl0Stars.Text = "☆";
            this.tl0Stars.Click += new System.EventHandler(this.tl0Stars_Click);
            // 
            // tool_AllStars
            // 
            this.tlAllStars.Name = "tool_AllStars";
            this.tlAllStars.Size = new System.Drawing.Size(136, 24);
            this.tlAllStars.Text = "All Ratings";
            this.tlAllStars.Click += new System.EventHandler(this.tlAllStars_Click);
            // 
            // tlStrp_RecentlyViewed
            // 
            this.tlsRecentlyViewed.Name = "tlStrp_RecentlyViewed";
            this.tlsRecentlyViewed.Size = new System.Drawing.Size(104, 19);
            this.tlsRecentlyViewed.Text = "Recently Viewed";
            // 
            // tlStrp_TimesWatched
            // 
            this.tlsTimesWatched.Name = "tlStrp_TimesWatched";
            this.tlsTimesWatched.Size = new System.Drawing.Size(104, 19);
            this.tlsTimesWatched.Text = "Times Watched";
            // 
            // label_panel
            // 
            this.LabelPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPanel.Controls.Add(this.lblSortBy);
            this.LabelPanel.Location = new System.Drawing.Point(0, 87);
            this.LabelPanel.Name = "label_panel";
            this.LabelPanel.Size = new System.Drawing.Size(121, 26);
            this.LabelPanel.TabIndex = 6;
            // 
            // lbl_SortBy
            // 
            this.lblSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(32, 4);
            this.lblSortBy.Name = "lbl_SortBy";
            this.lblSortBy.Size = new System.Drawing.Size(54, 17);
            this.lblSortBy.TabIndex = 2;
            this.lblSortBy.Text = "Sort By";
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryPanel.Controls.Add(this.LabelPanel);
            this.LibraryPanel.Controls.Add(this.tlsContainer);
            this.LibraryPanel.Controls.Add(this.txtSearch);
            this.LibraryPanel.Controls.Add(this.MovieListingPanel);
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(612, 615);
            this.LibraryPanel.TabIndex = 2;
            // 
            // link_pMain_pLibrary
            // 
            this.lnkMainLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMainLibrary.AutoSize = true;
            this.lnkMainLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMainLibrary.Location = new System.Drawing.Point(174, 138);
            this.lnkMainLibrary.Name = "link_pMain_pLibrary";
            this.lnkMainLibrary.Size = new System.Drawing.Size(340, 39);
            this.lnkMainLibrary.TabIndex = 2;
            this.lnkMainLibrary.TabStop = true;
            this.lnkMainLibrary.Text = "View Library / Search";
            this.lnkMainLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainLibrary_LinkClicked);
            // 
            // pic_pMain_pLibrary
            // 
            this.picMainLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainLibrary.Location = new System.Drawing.Point(102, 125);
            this.picMainLibrary.Name = "pic_pMain_pLibrary";
            this.picMainLibrary.Size = new System.Drawing.Size(66, 62);
            this.picMainLibrary.TabIndex = 3;
            this.picMainLibrary.TabStop = false;
            // 
            // link_pMain_pDataEntry
            // 
            this.lnkMainDataEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMainDataEntry.AutoSize = true;
            this.lnkMainDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMainDataEntry.Location = new System.Drawing.Point(174, 206);
            this.lnkMainDataEntry.Name = "link_pMain_pDataEntry";
            this.lnkMainDataEntry.Size = new System.Drawing.Size(206, 39);
            this.lnkMainDataEntry.TabIndex = 4;
            this.lnkMainDataEntry.TabStop = true;
            this.lnkMainDataEntry.Text = "Add a Movie";
            this.lnkMainDataEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainDataEntry_LinkClicked);
            // 
            // pic_pMain_pDataEntry
            // 
            this.picMainDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainDataEntry.Location = new System.Drawing.Point(102, 193);
            this.picMainDataEntry.Name = "pic_pMain_pDataEntry";
            this.picMainDataEntry.Size = new System.Drawing.Size(66, 62);
            this.picMainDataEntry.TabIndex = 5;
            this.picMainDataEntry.TabStop = false;
            // 
            // pic_pMain_frmSuggest
            // 
            this.picMainSuggest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainSuggest.Location = new System.Drawing.Point(102, 261);
            this.picMainSuggest.Name = "pic_pMain_frmSuggest";
            this.picMainSuggest.Size = new System.Drawing.Size(66, 62);
            this.picMainSuggest.TabIndex = 6;
            this.picMainSuggest.TabStop = false;
            // 
            // pic_pMain_pTagged
            // 
            this.picMainTaggedSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainTaggedSearch.Location = new System.Drawing.Point(102, 329);
            this.picMainTaggedSearch.Name = "pic_pMain_pTagged";
            this.picMainTaggedSearch.Size = new System.Drawing.Size(66, 62);
            this.picMainTaggedSearch.TabIndex = 7;
            this.picMainTaggedSearch.TabStop = false;
            // 
            // link_pMain_frmSuggest
            // 
            this.lnkMainSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMainSuggest.AutoSize = true;
            this.lnkMainSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMainSuggest.Location = new System.Drawing.Point(174, 274);
            this.lnkMainSuggest.Name = "link_pMain_frmSuggest";
            this.lnkMainSuggest.Size = new System.Drawing.Size(374, 39);
            this.lnkMainSuggest.TabIndex = 8;
            this.lnkMainSuggest.TabStop = true;
            this.lnkMainSuggest.Text = "Suggest a Movie for Me";
            this.lnkMainSuggest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainSuggest_LinkClicked);
            // 
            // link_pMain_pTaggedSearch
            // 
            this.lnkMainTaggedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMainTaggedSearch.AutoSize = true;
            this.lnkMainTaggedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMainTaggedSearch.Location = new System.Drawing.Point(174, 342);
            this.lnkMainTaggedSearch.Name = "link_pMain_pTaggedSearch";
            this.lnkMainTaggedSearch.Size = new System.Drawing.Size(250, 39);
            this.lnkMainTaggedSearch.TabIndex = 9;
            this.lnkMainTaggedSearch.TabStop = true;
            this.lnkMainTaggedSearch.Text = "Tagged Search";
            this.lnkMainTaggedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainTaggedSearch_LinkClicked);
            // 
            // lbl_WelcomeBanner
            // 
            this.lblWelcomeBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcomeBanner.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBanner.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeBanner.Name = "lbl_WelcomeBanner";
            this.lblWelcomeBanner.Size = new System.Drawing.Size(612, 48);
            this.lblWelcomeBanner.TabIndex = 10;
            this.lblWelcomeBanner.Text = "Welcome to the Movie Organizer";
            this.lblWelcomeBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuPanel.Controls.Add(this.lblWelcomeBanner);
            this.MainMenuPanel.Controls.Add(this.lnkMainTaggedSearch);
            this.MainMenuPanel.Controls.Add(this.lnkMainSuggest);
            this.MainMenuPanel.Controls.Add(this.picMainTaggedSearch);
            this.MainMenuPanel.Controls.Add(this.picMainSuggest);
            this.MainMenuPanel.Controls.Add(this.picMainDataEntry);
            this.MainMenuPanel.Controls.Add(this.lnkMainDataEntry);
            this.MainMenuPanel.Controls.Add(this.picMainLibrary);
            this.MainMenuPanel.Controls.Add(this.lnkMainLibrary);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(612, 615);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // lnkLibrary
            // 
            this.lnkLibrary.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLibrary.AutoSize = true;
            this.lnkLibrary.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLibrary.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLibrary.LinkColor = System.Drawing.Color.Black;
            this.lnkLibrary.Location = new System.Drawing.Point(6, 3);
            this.lnkLibrary.Name = "lnkLibrary";
            this.lnkLibrary.Size = new System.Drawing.Size(142, 42);
            this.lnkLibrary.TabIndex = 0;
            this.lnkLibrary.TabStop = true;
            this.lnkLibrary.Text = "View Library";
            this.lnkLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLibrary_LinkClicked);
            // 
            // lnkAddMovie
            // 
            this.lnkAddMovie.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAddMovie.AutoSize = true;
            this.lnkAddMovie.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddMovie.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAddMovie.LinkColor = System.Drawing.Color.Black;
            this.lnkAddMovie.Location = new System.Drawing.Point(157, 3);
            this.lnkAddMovie.Name = "lnkAddMovie";
            this.lnkAddMovie.Size = new System.Drawing.Size(142, 42);
            this.lnkAddMovie.TabIndex = 1;
            this.lnkAddMovie.TabStop = true;
            this.lnkAddMovie.Text = "Add Movie";
            this.lnkAddMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAddMovie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainDataEntry_LinkClicked);
            // 
            // lnkSuggest
            // 
            this.lnkSuggest.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSuggest.AutoSize = true;
            this.lnkSuggest.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSuggest.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSuggest.LinkColor = System.Drawing.Color.Black;
            this.lnkSuggest.Location = new System.Drawing.Point(308, 3);
            this.lnkSuggest.Name = "lnkSuggest";
            this.lnkSuggest.Size = new System.Drawing.Size(142, 42);
            this.lnkSuggest.TabIndex = 2;
            this.lnkSuggest.TabStop = true;
            this.lnkSuggest.Text = "Suggest Movie";
            this.lnkSuggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkSuggest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMainSuggest_LinkClicked);
            // 
            // lnkTaggedSearch
            // 
            this.lnkTaggedSearch.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkTaggedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkTaggedSearch.AutoSize = true;
            this.lnkTaggedSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTaggedSearch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkTaggedSearch.LinkColor = System.Drawing.Color.Black;
            this.lnkTaggedSearch.Location = new System.Drawing.Point(459, 3);
            this.lnkTaggedSearch.Name = "lnkTaggedSearch";
            this.lnkTaggedSearch.Size = new System.Drawing.Size(144, 42);
            this.lnkTaggedSearch.TabIndex = 3;
            this.lnkTaggedSearch.TabStop = true;
            this.lnkTaggedSearch.Text = "Tagged Search";
            this.lnkTaggedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkTaggedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTaggedSearch_LinkClicked);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigationPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.NavigationPanel.ColumnCount = 4;
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationPanel.Controls.Add(this.lnkTaggedSearch, 3, 0);
            this.NavigationPanel.Controls.Add(this.lnkSuggest, 2, 0);
            this.NavigationPanel.Controls.Add(this.lnkAddMovie, 1, 0);
            this.NavigationPanel.Controls.Add(this.lnkLibrary, 0, 0);
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.RowCount = 1;
            this.NavigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationPanel.Size = new System.Drawing.Size(609, 48);
            this.NavigationPanel.TabIndex = 7;
            // 
            // TagPanel
            // 
            this.TagPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagPanel.Controls.Add(this.btnDelete);
            this.TagPanel.Controls.Add(this.btnCreate);
            this.TagPanel.Controls.Add(this.btnSearch);
            this.TagPanel.Controls.Add(this.lstToSearch);
            this.TagPanel.Controls.Add(this.btnRemoveTag);
            this.TagPanel.Controls.Add(this.btnAddTag);
            this.TagPanel.Controls.Add(this.lstTagsAvailable);
            this.TagPanel.Controls.Add(this.lblSearch);
            this.TagPanel.Controls.Add(this.lblAvailable);
            this.TagPanel.Location = new System.Drawing.Point(0, 84);
            this.TagPanel.Name = "TagPanel";
            this.TagPanel.Size = new System.Drawing.Size(609, 531);
            this.TagPanel.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btnDelete.Location = new System.Drawing.Point(86, 434);
            this.btnDelete.Name = "btn_Delete";
            this.btnDelete.Size = new System.Drawing.Size(93, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Tag";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Create
            // 
            this.btnCreate.Location = new System.Drawing.Point(86, 402);
            this.btnCreate.Name = "btn_Create";
            this.btnCreate.Size = new System.Drawing.Size(93, 27);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Tag";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btn_Search
            // 
            this.btnSearch.Location = new System.Drawing.Point(436, 434);
            this.btnSearch.Name = "btn_Search";
            this.btnSearch.Size = new System.Drawing.Size(79, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // list_ToSearch
            // 
            this.lstToSearch.FormattingEnabled = true;
            this.lstToSearch.Location = new System.Drawing.Point(353, 126);
            this.lstToSearch.Name = "list_ToSearch";
            this.lstToSearch.Size = new System.Drawing.Size(162, 238);
            this.lstToSearch.TabIndex = 6;
            // 
            // btn_Remove_Tag
            // 
            this.btnRemoveTag.Location = new System.Drawing.Point(263, 227);
            this.btnRemoveTag.Name = "btn_Remove_Tag";
            this.btnRemoveTag.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTag.TabIndex = 5;
            this.btnRemoveTag.Text = "< <";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btn_Add_Tag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(263, 187);
            this.btnAddTag.Name = "btn_Add_Tag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddTag.TabIndex = 4;
            this.btnAddTag.Text = "> >";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // list_availableTags
            // 
            this.lstTagsAvailable.FormattingEnabled = true;
            this.lstTagsAvailable.Location = new System.Drawing.Point(86, 126);
            this.lstTagsAvailable.Name = "list_availableTags";
            this.lstTagsAvailable.Size = new System.Drawing.Size(162, 238);
            this.lstTagsAvailable.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(349, 88);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(137, 24);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tags to Search";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(82, 88);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(133, 24);
            this.lblAvailable.TabIndex = 1;
            this.lblAvailable.Text = "Available Tags";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 613);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.TagPanel);
            this.Controls.Add(this.LibraryPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "MainForm";
            this.Text = "Movie Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.tlsContainer.ContentPanel.ResumeLayout(false);
            this.tlsContainer.ContentPanel.PerformLayout();
            this.tlsContainer.ResumeLayout(false);
            this.tlsContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnsStrip.ResumeLayout(false);
            this.mnsStrip.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDataEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainSuggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainTaggedSearch)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.TagPanel.ResumeLayout(false);
            this.TagPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLOSI;
        private System.Windows.Forms.Label lblLOSI;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripContainer tlsContainer;
        private System.Windows.Forms.MenuStrip mnsStrip;
        private System.Windows.Forms.ToolStripMenuItem tlsGenre;
        private System.Windows.Forms.ToolStripMenuItem tlsActor;
        private System.Windows.Forms.ToolStripMenuItem tlsDirector;
        private System.Windows.Forms.ToolStripMenuItem tlsYear;
        private System.Windows.Forms.ToolStripMenuItem tlsRating;
        private System.Windows.Forms.ToolStripMenuItem tlsRecentlyViewed;
        private System.Windows.Forms.ToolStripMenuItem tlsTimesWatched;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.LinkLabel lnkMainLibrary;
        private System.Windows.Forms.PictureBox picMainLibrary;
        private System.Windows.Forms.LinkLabel lnkMainDataEntry;
        private System.Windows.Forms.PictureBox picMainDataEntry;
        private System.Windows.Forms.PictureBox picMainSuggest;
        private System.Windows.Forms.PictureBox picMainTaggedSearch;
        private System.Windows.Forms.LinkLabel lnkMainSuggest;
        private System.Windows.Forms.LinkLabel lnkMainTaggedSearch;
        private System.Windows.Forms.Label lblWelcomeBanner;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel MovieListingPanel;
        private System.Windows.Forms.TableLayoutPanel NavigationPanel;
        private System.Windows.Forms.LinkLabel lnkTaggedSearch;
        private System.Windows.Forms.LinkLabel lnkSuggest;
        private System.Windows.Forms.LinkLabel lnkAddMovie;
        private System.Windows.Forms.LinkLabel lnkLibrary;
        private System.Windows.Forms.Panel TagPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.ListBox lstTagsAvailable;
        private System.Windows.Forms.ListBox lstToSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem tl5Stars;
        private System.Windows.Forms.ToolStripMenuItem tl4Stars;
        private System.Windows.Forms.ToolStripMenuItem tl3Stars;
        private System.Windows.Forms.ToolStripMenuItem tl2Stars;
        private System.Windows.Forms.ToolStripMenuItem tl1Stars;
        private System.Windows.Forms.ToolStripMenuItem tl0Stars;
        private System.Windows.Forms.ToolStripMenuItem tlAllStars;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.LinkLabel lnkWishlist;
        private System.Windows.Forms.LinkLabel lnkGive;
        private System.Windows.Forms.LinkLabel lnkWatchNext;
    }
}

