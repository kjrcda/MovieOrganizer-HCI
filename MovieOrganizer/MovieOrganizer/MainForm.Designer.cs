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
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.label_panel = new System.Windows.Forms.Panel();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlStrp_Genre = new System.Windows.Forms.ToolStripMenuItem();
            this.horrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherDynamicallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Actor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Director = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_Rating = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_RecentlyViewed = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrp_TimesWatched = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_SearchBar = new System.Windows.Forms.TextBox();
            this.panel_MovieListing = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.pic_WelcomeBanner = new System.Windows.Forms.PictureBox();
            this.link_pMain_pTaggedSearch = new System.Windows.Forms.LinkLabel();
            this.link_pMain_frmSuggest = new System.Windows.Forms.LinkLabel();
            this.pic_pMain_pTagged = new System.Windows.Forms.PictureBox();
            this.pic_pMain_frmSuggest = new System.Windows.Forms.PictureBox();
            this.pic_pMain_pDataEntry = new System.Windows.Forms.PictureBox();
            this.link_pMain_pDataEntry = new System.Windows.Forms.LinkLabel();
            this.pic_pMain_pLibrary = new System.Windows.Forms.PictureBox();
            this.link_pMain_pLibrary = new System.Windows.Forms.LinkLabel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.DataEntryPanel = new System.Windows.Forms.Panel();
            this.cmb_Rating = new System.Windows.Forms.ComboBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.btn_pDataEntry_modalConfirmation_DeleteMovie = new System.Windows.Forms.Button();
            this.btn_pDataEntry_pLibrary_Cancel = new System.Windows.Forms.Button();
            this.btn_pDataEntry_pLibrary_Save = new System.Windows.Forms.Button();
            this.txt_Tags = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Genre = new System.Windows.Forms.TextBox();
            this.txt_Actors = new System.Windows.Forms.TextBox();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_MovieTitle = new System.Windows.Forms.TextBox();
            this.pic_EditMovieImage = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_LOSI = new System.Windows.Forms.Label();
            this.link_LOSI = new System.Windows.Forms.LinkLabel();
            this.link_pNavBar_TaggedSearch = new System.Windows.Forms.LinkLabel();
            this.link_pNavBar_Suggest = new System.Windows.Forms.LinkLabel();
            this.link_pNavBar_AddMovie = new System.Windows.Forms.LinkLabel();
            this.link_pNavBar_ViewLibrary = new System.Windows.Forms.LinkLabel();
            this.btn_pLibrary_BeginSearch = new System.Windows.Forms.Button();
            this.TaggedSearchPanel = new System.Windows.Forms.Panel();
            this.listBox_pTaggedSearch_available = new System.Windows.Forms.ListBox();
            this.lbl_pTaggedSearch_available = new System.Windows.Forms.Label();
            this.lbl_pTaggedSearch_search = new System.Windows.Forms.Label();
            this.listBox_pTaggedSearch_search = new System.Windows.Forms.ListBox();
            this.btn_pTaggedSearch_Search = new System.Windows.Forms.Button();
            this.btn_pTaggedSearch_Cancel = new System.Windows.Forms.Button();
            this.btn_pTaggedSearch_moveToSearch = new System.Windows.Forms.Button();
            this.btn_pTaggedSearch_moveToAvail = new System.Windows.Forms.Button();
            this.LibraryPanel.SuspendLayout();
            this.label_panel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_MovieListing.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WelcomeBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pTagged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_frmSuggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pDataEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pLibrary)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.DataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditMovieImage)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.TaggedSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.btn_pLibrary_BeginSearch);
            this.LibraryPanel.Controls.Add(this.label_panel);
            this.LibraryPanel.Controls.Add(this.toolStripContainer1);
            this.LibraryPanel.Controls.Add(this.txtBox_SearchBar);
            this.LibraryPanel.Controls.Add(this.panel_MovieListing);
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(605, 615);
            this.LibraryPanel.TabIndex = 2;
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
            // toolStripContainer1
            // 
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
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_2);
            // 
            // tlStrp_Genre
            // 
            this.tlStrp_Genre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horrorToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.otherDynamicallyToolStripMenuItem,
            this.addedFieldsToolStripMenuItem});
            this.tlStrp_Genre.Name = "tlStrp_Genre";
            this.tlStrp_Genre.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Genre.Text = "Genre";
            // 
            // horrorToolStripMenuItem
            // 
            this.horrorToolStripMenuItem.Name = "horrorToolStripMenuItem";
            this.horrorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.horrorToolStripMenuItem.Text = "Horror";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // otherDynamicallyToolStripMenuItem
            // 
            this.otherDynamicallyToolStripMenuItem.Name = "otherDynamicallyToolStripMenuItem";
            this.otherDynamicallyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.otherDynamicallyToolStripMenuItem.Text = "Other dynamically";
            // 
            // addedFieldsToolStripMenuItem
            // 
            this.addedFieldsToolStripMenuItem.Name = "addedFieldsToolStripMenuItem";
            this.addedFieldsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addedFieldsToolStripMenuItem.Text = "added fields";
            // 
            // tlStrp_Actor
            // 
            this.tlStrp_Actor.Name = "tlStrp_Actor";
            this.tlStrp_Actor.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Actor.Text = "Actor";
            // 
            // tlStrp_Director
            // 
            this.tlStrp_Director.Name = "tlStrp_Director";
            this.tlStrp_Director.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Director.Text = "Director";
            // 
            // tlStrp_Year
            // 
            this.tlStrp_Year.Name = "tlStrp_Year";
            this.tlStrp_Year.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Year.Text = "Year";
            // 
            // tlStrp_Rating
            // 
            this.tlStrp_Rating.Name = "tlStrp_Rating";
            this.tlStrp_Rating.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_Rating.Text = "Rating";
            // 
            // tlStrp_RecentlyViewed
            // 
            this.tlStrp_RecentlyViewed.Name = "tlStrp_RecentlyViewed";
            this.tlStrp_RecentlyViewed.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_RecentlyViewed.Text = "Recently Viewed";
            // 
            // tlStrp_TimesWatched
            // 
            this.tlStrp_TimesWatched.Name = "tlStrp_TimesWatched";
            this.tlStrp_TimesWatched.Size = new System.Drawing.Size(104, 19);
            this.tlStrp_TimesWatched.Text = "Times Watched";
            // 
            // txtBox_SearchBar
            // 
            this.txtBox_SearchBar.Location = new System.Drawing.Point(124, 87);
            this.txtBox_SearchBar.Multiline = true;
            this.txtBox_SearchBar.Name = "txtBox_SearchBar";
            this.txtBox_SearchBar.Size = new System.Drawing.Size(467, 20);
            this.txtBox_SearchBar.TabIndex = 4;
            this.txtBox_SearchBar.Text = "Search for a Title";
            // 
            // panel_MovieListing
            // 
            this.panel_MovieListing.Controls.Add(this.vScrollBar1);
            this.panel_MovieListing.Location = new System.Drawing.Point(121, 113);
            this.panel_MovieListing.Name = "panel_MovieListing";
            this.panel_MovieListing.Size = new System.Drawing.Size(484, 499);
            this.panel_MovieListing.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(458, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 499);
            this.vScrollBar1.TabIndex = 2;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.pic_WelcomeBanner);
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
            // pic_WelcomeBanner
            // 
            this.pic_WelcomeBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_WelcomeBanner.Location = new System.Drawing.Point(0, 0);
            this.pic_WelcomeBanner.Name = "pic_WelcomeBanner";
            this.pic_WelcomeBanner.Size = new System.Drawing.Size(605, 48);
            this.pic_WelcomeBanner.TabIndex = 10;
            this.pic_WelcomeBanner.TabStop = false;
            // 
            // link_pMain_pTaggedSearch
            // 
            this.link_pMain_pTaggedSearch.AutoSize = true;
            this.link_pMain_pTaggedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pMain_pTaggedSearch.Location = new System.Drawing.Point(174, 342);
            this.link_pMain_pTaggedSearch.Name = "link_pMain_pTaggedSearch";
            this.link_pMain_pTaggedSearch.Size = new System.Drawing.Size(250, 39);
            this.link_pMain_pTaggedSearch.TabIndex = 9;
            this.link_pMain_pTaggedSearch.TabStop = true;
            this.link_pMain_pTaggedSearch.Text = "Tagged Search";
            this.link_pMain_pTaggedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pMain_pTaggedSearch_LinkClicked);
            // 
            // link_pMain_frmSuggest
            // 
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
            // pic_pMain_pTagged
            // 
            this.pic_pMain_pTagged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pTagged.Location = new System.Drawing.Point(102, 329);
            this.pic_pMain_pTagged.Name = "pic_pMain_pTagged";
            this.pic_pMain_pTagged.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pTagged.TabIndex = 7;
            this.pic_pMain_pTagged.TabStop = false;
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
            // pic_pMain_pDataEntry
            // 
            this.pic_pMain_pDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pDataEntry.Location = new System.Drawing.Point(102, 193);
            this.pic_pMain_pDataEntry.Name = "pic_pMain_pDataEntry";
            this.pic_pMain_pDataEntry.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pDataEntry.TabIndex = 5;
            this.pic_pMain_pDataEntry.TabStop = false;
            // 
            // link_pMain_pDataEntry
            // 
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
            // pic_pMain_pLibrary
            // 
            this.pic_pMain_pLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_pMain_pLibrary.Location = new System.Drawing.Point(102, 125);
            this.pic_pMain_pLibrary.Name = "pic_pMain_pLibrary";
            this.pic_pMain_pLibrary.Size = new System.Drawing.Size(66, 62);
            this.pic_pMain_pLibrary.TabIndex = 3;
            this.pic_pMain_pLibrary.TabStop = false;
            // 
            // link_pMain_pLibrary
            // 
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
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.link_pNavBar_ViewLibrary);
            this.NavigationPanel.Controls.Add(this.link_pNavBar_AddMovie);
            this.NavigationPanel.Controls.Add(this.link_pNavBar_Suggest);
            this.NavigationPanel.Controls.Add(this.link_pNavBar_TaggedSearch);
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(605, 51);
            this.NavigationPanel.TabIndex = 2;
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.Controls.Add(this.cmb_Rating);
            this.DataEntryPanel.Controls.Add(this.btn_UploadImage);
            this.DataEntryPanel.Controls.Add(this.btn_pDataEntry_modalConfirmation_DeleteMovie);
            this.DataEntryPanel.Controls.Add(this.btn_pDataEntry_pLibrary_Cancel);
            this.DataEntryPanel.Controls.Add(this.btn_pDataEntry_pLibrary_Save);
            this.DataEntryPanel.Controls.Add(this.txt_Tags);
            this.DataEntryPanel.Controls.Add(this.txt_Description);
            this.DataEntryPanel.Controls.Add(this.txt_Genre);
            this.DataEntryPanel.Controls.Add(this.txt_Actors);
            this.DataEntryPanel.Controls.Add(this.txt_Director);
            this.DataEntryPanel.Controls.Add(this.txt_Year);
            this.DataEntryPanel.Controls.Add(this.txt_MovieTitle);
            this.DataEntryPanel.Controls.Add(this.pic_EditMovieImage);
            this.DataEntryPanel.Location = new System.Drawing.Point(0, 0);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(605, 615);
            this.DataEntryPanel.TabIndex = 10;
            // 
            // cmb_Rating
            // 
            this.cmb_Rating.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmb_Rating.FormattingEnabled = true;
            this.cmb_Rating.Location = new System.Drawing.Point(233, 202);
            this.cmb_Rating.Name = "cmb_Rating";
            this.cmb_Rating.Size = new System.Drawing.Size(191, 21);
            this.cmb_Rating.TabIndex = 13;
            this.cmb_Rating.Text = "Rating";
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(16, 326);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(91, 23);
            this.btn_UploadImage.TabIndex = 12;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            // 
            // btn_pDataEntry_modalConfirmation_DeleteMovie
            // 
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Location = new System.Drawing.Point(12, 578);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Name = "btn_pDataEntry_modalConfirmation_DeleteMovie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Size = new System.Drawing.Size(95, 23);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.TabIndex = 11;
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Text = "Delete Movie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Click += new System.EventHandler(this.btn_pDataEntry_modalConfirmation_DeleteMovie_Click);
            // 
            // btn_pDataEntry_pLibrary_Cancel
            // 
            this.btn_pDataEntry_pLibrary_Cancel.Location = new System.Drawing.Point(435, 578);
            this.btn_pDataEntry_pLibrary_Cancel.Name = "btn_pDataEntry_pLibrary_Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_pDataEntry_pLibrary_Cancel.TabIndex = 10;
            this.btn_pDataEntry_pLibrary_Cancel.Text = "Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_pLibrary_Cancel.Click += new System.EventHandler(this.btn_pDataEntry_pLibrary_Cancel_Click);
            // 
            // btn_pDataEntry_pLibrary_Save
            // 
            this.btn_pDataEntry_pLibrary_Save.Location = new System.Drawing.Point(516, 578);
            this.btn_pDataEntry_pLibrary_Save.Name = "btn_pDataEntry_pLibrary_Save";
            this.btn_pDataEntry_pLibrary_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_pDataEntry_pLibrary_Save.TabIndex = 9;
            this.btn_pDataEntry_pLibrary_Save.Text = "Save";
            this.btn_pDataEntry_pLibrary_Save.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_pLibrary_Save.Click += new System.EventHandler(this.btn_pDataEntry_pLibrary_Save_Click);
            // 
            // txt_Tags
            // 
            this.txt_Tags.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Tags.Location = new System.Drawing.Point(233, 329);
            this.txt_Tags.Name = "txt_Tags";
            this.txt_Tags.Size = new System.Drawing.Size(191, 20);
            this.txt_Tags.TabIndex = 8;
            this.txt_Tags.Text = "Tags";
            this.txt_Tags.TextChanged += new System.EventHandler(this.txt_Tags_TextChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Description.Location = new System.Drawing.Point(233, 255);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(191, 68);
            this.txt_Description.TabIndex = 7;
            this.txt_Description.Text = "Description";
            this.txt_Description.TextChanged += new System.EventHandler(this.txt_Description_TextChanged);
            // 
            // txt_Genre
            // 
            this.txt_Genre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Genre.Location = new System.Drawing.Point(233, 229);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(191, 20);
            this.txt_Genre.TabIndex = 6;
            this.txt_Genre.Text = "Genre";
            this.txt_Genre.TextChanged += new System.EventHandler(this.txt_Genre_TextChanged);
            // 
            // txt_Actors
            // 
            this.txt_Actors.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Actors.Location = new System.Drawing.Point(233, 177);
            this.txt_Actors.Name = "txt_Actors";
            this.txt_Actors.Size = new System.Drawing.Size(191, 20);
            this.txt_Actors.TabIndex = 4;
            this.txt_Actors.Text = "Actors";
            this.txt_Actors.TextChanged += new System.EventHandler(this.txt_Actors_TextChanged);
            // 
            // txt_Director
            // 
            this.txt_Director.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Director.Location = new System.Drawing.Point(233, 151);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(191, 20);
            this.txt_Director.TabIndex = 3;
            this.txt_Director.Text = "Director";
            this.txt_Director.TextChanged += new System.EventHandler(this.txt_Director_TextChanged);
            // 
            // txt_Year
            // 
            this.txt_Year.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Year.Location = new System.Drawing.Point(233, 125);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(191, 20);
            this.txt_Year.TabIndex = 2;
            this.txt_Year.Text = "Year";
            this.txt_Year.TextChanged += new System.EventHandler(this.txt_Year_TextChanged);
            // 
            // txt_MovieTitle
            // 
            this.txt_MovieTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_MovieTitle.Location = new System.Drawing.Point(233, 99);
            this.txt_MovieTitle.Name = "txt_MovieTitle";
            this.txt_MovieTitle.Size = new System.Drawing.Size(191, 20);
            this.txt_MovieTitle.TabIndex = 1;
            this.txt_MovieTitle.Text = "Movie Title";
            this.txt_MovieTitle.TextChanged += new System.EventHandler(this.txt_MovieTitle_TextChanged);
            // 
            // pic_EditMovieImage
            // 
            this.pic_EditMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_EditMovieImage.Location = new System.Drawing.Point(16, 99);
            this.pic_EditMovieImage.Name = "pic_EditMovieImage";
            this.pic_EditMovieImage.Size = new System.Drawing.Size(185, 224);
            this.pic_EditMovieImage.TabIndex = 0;
            this.pic_EditMovieImage.TabStop = false;
            // 
            // LoginPanel
            // 
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
            // link_LOSI
            // 
            this.link_LOSI.AutoSize = true;
            this.link_LOSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_LOSI.Location = new System.Drawing.Point(531, 6);
            this.link_LOSI.Name = "link_LOSI";
            this.link_LOSI.Size = new System.Drawing.Size(59, 17);
            this.link_LOSI.TabIndex = 0;
            this.link_LOSI.TabStop = true;
            this.link_LOSI.Text = "Log Out";
            this.link_LOSI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LOSI_LinkClicked);
            // 
            // link_pNavBar_TaggedSearch
            // 
            this.link_pNavBar_TaggedSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.link_pNavBar_TaggedSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link_pNavBar_TaggedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pNavBar_TaggedSearch.Location = new System.Drawing.Point(453, 0);
            this.link_pNavBar_TaggedSearch.Name = "link_pNavBar_TaggedSearch";
            this.link_pNavBar_TaggedSearch.Size = new System.Drawing.Size(151, 48);
            this.link_pNavBar_TaggedSearch.TabIndex = 8;
            this.link_pNavBar_TaggedSearch.TabStop = true;
            this.link_pNavBar_TaggedSearch.Text = "TaggedSearch";
            this.link_pNavBar_TaggedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_pNavBar_TaggedSearch.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // link_pNavBar_Suggest
            // 
            this.link_pNavBar_Suggest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.link_pNavBar_Suggest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link_pNavBar_Suggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pNavBar_Suggest.Location = new System.Drawing.Point(302, 0);
            this.link_pNavBar_Suggest.Name = "link_pNavBar_Suggest";
            this.link_pNavBar_Suggest.Size = new System.Drawing.Size(151, 48);
            this.link_pNavBar_Suggest.TabIndex = 9;
            this.link_pNavBar_Suggest.TabStop = true;
            this.link_pNavBar_Suggest.Text = "Suggest Movie";
            this.link_pNavBar_Suggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_pNavBar_Suggest.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // link_pNavBar_AddMovie
            // 
            this.link_pNavBar_AddMovie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.link_pNavBar_AddMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link_pNavBar_AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pNavBar_AddMovie.Location = new System.Drawing.Point(151, 0);
            this.link_pNavBar_AddMovie.Name = "link_pNavBar_AddMovie";
            this.link_pNavBar_AddMovie.Size = new System.Drawing.Size(151, 48);
            this.link_pNavBar_AddMovie.TabIndex = 10;
            this.link_pNavBar_AddMovie.TabStop = true;
            this.link_pNavBar_AddMovie.Text = "Add a Movie";
            this.link_pNavBar_AddMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_pNavBar_AddMovie.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // link_pNavBar_ViewLibrary
            // 
            this.link_pNavBar_ViewLibrary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.link_pNavBar_ViewLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.link_pNavBar_ViewLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_pNavBar_ViewLibrary.Location = new System.Drawing.Point(0, 0);
            this.link_pNavBar_ViewLibrary.Name = "link_pNavBar_ViewLibrary";
            this.link_pNavBar_ViewLibrary.Size = new System.Drawing.Size(151, 48);
            this.link_pNavBar_ViewLibrary.TabIndex = 11;
            this.link_pNavBar_ViewLibrary.TabStop = true;
            this.link_pNavBar_ViewLibrary.Text = "View Library";
            this.link_pNavBar_ViewLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_pNavBar_ViewLibrary.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_pNavBar_ViewLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pNavBar_ViewLibrary_LinkClicked);
            // 
            // btn_pLibrary_BeginSearch
            // 
            this.btn_pLibrary_BeginSearch.Location = new System.Drawing.Point(516, 87);
            this.btn_pLibrary_BeginSearch.Name = "btn_pLibrary_BeginSearch";
            this.btn_pLibrary_BeginSearch.Size = new System.Drawing.Size(74, 20);
            this.btn_pLibrary_BeginSearch.TabIndex = 7;
            this.btn_pLibrary_BeginSearch.Text = "Search";
            this.btn_pLibrary_BeginSearch.UseVisualStyleBackColor = true;
            // 
            // TaggedSearchPanel
            // 
            this.TaggedSearchPanel.Controls.Add(this.btn_pTaggedSearch_moveToAvail);
            this.TaggedSearchPanel.Controls.Add(this.btn_pTaggedSearch_moveToSearch);
            this.TaggedSearchPanel.Controls.Add(this.btn_pTaggedSearch_Cancel);
            this.TaggedSearchPanel.Controls.Add(this.btn_pTaggedSearch_Search);
            this.TaggedSearchPanel.Controls.Add(this.listBox_pTaggedSearch_search);
            this.TaggedSearchPanel.Controls.Add(this.lbl_pTaggedSearch_search);
            this.TaggedSearchPanel.Controls.Add(this.lbl_pTaggedSearch_available);
            this.TaggedSearchPanel.Controls.Add(this.listBox_pTaggedSearch_available);
            this.TaggedSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.TaggedSearchPanel.Name = "TaggedSearchPanel";
            this.TaggedSearchPanel.Size = new System.Drawing.Size(604, 615);
            this.TaggedSearchPanel.TabIndex = 1;
            // 
            // listBox_pTaggedSearch_available
            // 
            this.listBox_pTaggedSearch_available.FormattingEnabled = true;
            this.listBox_pTaggedSearch_available.Location = new System.Drawing.Point(80, 153);
            this.listBox_pTaggedSearch_available.Name = "listBox_pTaggedSearch_available";
            this.listBox_pTaggedSearch_available.Size = new System.Drawing.Size(166, 238);
            this.listBox_pTaggedSearch_available.TabIndex = 1;
            // 
            // lbl_pTaggedSearch_available
            // 
            this.lbl_pTaggedSearch_available.AutoSize = true;
            this.lbl_pTaggedSearch_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pTaggedSearch_available.Location = new System.Drawing.Point(77, 128);
            this.lbl_pTaggedSearch_available.Name = "lbl_pTaggedSearch_available";
            this.lbl_pTaggedSearch_available.Size = new System.Drawing.Size(115, 20);
            this.lbl_pTaggedSearch_available.TabIndex = 3;
            this.lbl_pTaggedSearch_available.Text = "Available Tags:";
            // 
            // lbl_pTaggedSearch_search
            // 
            this.lbl_pTaggedSearch_search.AutoSize = true;
            this.lbl_pTaggedSearch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pTaggedSearch_search.Location = new System.Drawing.Point(348, 130);
            this.lbl_pTaggedSearch_search.Name = "lbl_pTaggedSearch_search";
            this.lbl_pTaggedSearch_search.Size = new System.Drawing.Size(149, 20);
            this.lbl_pTaggedSearch_search.TabIndex = 4;
            this.lbl_pTaggedSearch_search.Text = "Tags to Search For:";
            // 
            // listBox_pTaggedSearch_search
            // 
            this.listBox_pTaggedSearch_search.FormattingEnabled = true;
            this.listBox_pTaggedSearch_search.Location = new System.Drawing.Point(352, 153);
            this.listBox_pTaggedSearch_search.Name = "listBox_pTaggedSearch_search";
            this.listBox_pTaggedSearch_search.Size = new System.Drawing.Size(166, 238);
            this.listBox_pTaggedSearch_search.TabIndex = 5;
            // 
            // btn_pTaggedSearch_Search
            // 
            this.btn_pTaggedSearch_Search.Location = new System.Drawing.Point(515, 578);
            this.btn_pTaggedSearch_Search.Name = "btn_pTaggedSearch_Search";
            this.btn_pTaggedSearch_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_pTaggedSearch_Search.TabIndex = 6;
            this.btn_pTaggedSearch_Search.Text = "Search";
            this.btn_pTaggedSearch_Search.UseVisualStyleBackColor = true;
            // 
            // btn_pTaggedSearch_Cancel
            // 
            this.btn_pTaggedSearch_Cancel.Location = new System.Drawing.Point(434, 578);
            this.btn_pTaggedSearch_Cancel.Name = "btn_pTaggedSearch_Cancel";
            this.btn_pTaggedSearch_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_pTaggedSearch_Cancel.TabIndex = 7;
            this.btn_pTaggedSearch_Cancel.Text = "Cancel";
            this.btn_pTaggedSearch_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_pTaggedSearch_moveToSearch
            // 
            this.btn_pTaggedSearch_moveToSearch.Location = new System.Drawing.Point(280, 209);
            this.btn_pTaggedSearch_moveToSearch.Name = "btn_pTaggedSearch_moveToSearch";
            this.btn_pTaggedSearch_moveToSearch.Size = new System.Drawing.Size(38, 36);
            this.btn_pTaggedSearch_moveToSearch.TabIndex = 8;
            this.btn_pTaggedSearch_moveToSearch.Text = ">";
            this.btn_pTaggedSearch_moveToSearch.UseVisualStyleBackColor = true;
            // 
            // btn_pTaggedSearch_moveToAvail
            // 
            this.btn_pTaggedSearch_moveToAvail.Location = new System.Drawing.Point(280, 274);
            this.btn_pTaggedSearch_moveToAvail.Name = "btn_pTaggedSearch_moveToAvail";
            this.btn_pTaggedSearch_moveToAvail.Size = new System.Drawing.Size(38, 36);
            this.btn_pTaggedSearch_moveToAvail.TabIndex = 9;
            this.btn_pTaggedSearch_moveToAvail.Text = "<";
            this.btn_pTaggedSearch_moveToAvail.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.TaggedSearchPanel);
            this.Controls.Add(this.LibraryPanel);
            this.Controls.Add(this.DataEntryPanel);
            this.Name = "MainForm";
            this.Text = "Movie Organizer";
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            this.label_panel.ResumeLayout(false);
            this.label_panel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_MovieListing.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WelcomeBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pTagged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_frmSuggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pDataEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pMain_pLibrary)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditMovieImage)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.TaggedSearchPanel.ResumeLayout(false);
            this.TaggedSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.LinkLabel link_pMain_pLibrary;
        private System.Windows.Forms.PictureBox pic_pMain_pLibrary;
        private System.Windows.Forms.LinkLabel link_pMain_pTaggedSearch;
        private System.Windows.Forms.LinkLabel link_pMain_frmSuggest;
        private System.Windows.Forms.PictureBox pic_pMain_pTagged;
        private System.Windows.Forms.PictureBox pic_pMain_frmSuggest;
        private System.Windows.Forms.PictureBox pic_pMain_pDataEntry;
        private System.Windows.Forms.LinkLabel link_pMain_pDataEntry;
        private System.Windows.Forms.Panel DataEntryPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.LinkLabel link_LOSI;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_LOSI;
        private System.Windows.Forms.PictureBox pic_WelcomeBanner;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Button btn_pDataEntry_modalConfirmation_DeleteMovie;
        private System.Windows.Forms.Button btn_pDataEntry_pLibrary_Cancel;
        private System.Windows.Forms.Button btn_pDataEntry_pLibrary_Save;
        private System.Windows.Forms.TextBox txt_Tags;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Genre;
        private System.Windows.Forms.TextBox txt_Actors;
        private System.Windows.Forms.TextBox txt_Director;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_MovieTitle;
        private System.Windows.Forms.PictureBox pic_EditMovieImage;
        private System.Windows.Forms.ComboBox cmb_Rating;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel_MovieListing;
        private System.Windows.Forms.TextBox txtBox_SearchBar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Genre;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Actor;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Director;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Year;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_Rating;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_RecentlyViewed;
        private System.Windows.Forms.ToolStripMenuItem tlStrp_TimesWatched;
        private System.Windows.Forms.ToolStripMenuItem horrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherDynamicallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addedFieldsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_SortBy;
        private System.Windows.Forms.Panel label_panel;
        private System.Windows.Forms.LinkLabel link_pNavBar_ViewLibrary;
        private System.Windows.Forms.LinkLabel link_pNavBar_AddMovie;
        private System.Windows.Forms.LinkLabel link_pNavBar_Suggest;
        private System.Windows.Forms.LinkLabel link_pNavBar_TaggedSearch;
        private System.Windows.Forms.Button btn_pLibrary_BeginSearch;
        private System.Windows.Forms.Panel TaggedSearchPanel;
        private System.Windows.Forms.Button btn_pTaggedSearch_moveToAvail;
        private System.Windows.Forms.Button btn_pTaggedSearch_moveToSearch;
        private System.Windows.Forms.Button btn_pTaggedSearch_Cancel;
        private System.Windows.Forms.Button btn_pTaggedSearch_Search;
        private System.Windows.Forms.ListBox listBox_pTaggedSearch_search;
        private System.Windows.Forms.Label lbl_pTaggedSearch_search;
        private System.Windows.Forms.Label lbl_pTaggedSearch_available;
        private System.Windows.Forms.ListBox listBox_pTaggedSearch_available;
    }
}

