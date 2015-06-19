namespace MovieOrganizer
{
    partial class DataEntryAbstract
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
            this.DataEntryPanel = new System.Windows.Forms.Panel();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveMovie = new System.Windows.Forms.Button();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.picEditMovieImage = new System.Windows.Forms.PictureBox();
            this.DataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.Controls.Add(this.btnDeleteMovie);
            this.DataEntryPanel.Controls.Add(this.lblTags);
            this.DataEntryPanel.Controls.Add(this.lblDescription);
            this.DataEntryPanel.Controls.Add(this.lblGenre);
            this.DataEntryPanel.Controls.Add(this.lblRating);
            this.DataEntryPanel.Controls.Add(this.lblActors);
            this.DataEntryPanel.Controls.Add(this.lblDirector);
            this.DataEntryPanel.Controls.Add(this.lblYear);
            this.DataEntryPanel.Controls.Add(this.lblMovieTitle);
            this.DataEntryPanel.Controls.Add(this.cmbRating);
            this.DataEntryPanel.Controls.Add(this.btnUploadImage);
            this.DataEntryPanel.Controls.Add(this.btnCancel);
            this.DataEntryPanel.Controls.Add(this.btnSaveMovie);
            this.DataEntryPanel.Controls.Add(this.txtTags);
            this.DataEntryPanel.Controls.Add(this.txtDescription);
            this.DataEntryPanel.Controls.Add(this.txtGenre);
            this.DataEntryPanel.Controls.Add(this.txtActors);
            this.DataEntryPanel.Controls.Add(this.txtDirector);
            this.DataEntryPanel.Controls.Add(this.txtYear);
            this.DataEntryPanel.Controls.Add(this.txtMovieTitle);
            this.DataEntryPanel.Controls.Add(this.picEditMovieImage);
            this.DataEntryPanel.Location = new System.Drawing.Point(0, 0);
            this.DataEntryPanel.Name = "DataEntryPanel";
            this.DataEntryPanel.Size = new System.Drawing.Size(542, 438);
            this.DataEntryPanel.TabIndex = 1;
            // 
            // btn_Delete_Movie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(31, 387);
            this.btnDeleteMovie.Name = "btn_Delete_Movie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteMovie.TabIndex = 22;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // lbl_Tags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(273, 281);
            this.lblTags.Name = "lbl_Tags";
            this.lblTags.Size = new System.Drawing.Size(37, 13);
            this.lblTags.TabIndex = 21;
            this.lblTags.Text = "Tags :";
            // 
            // lbl_Description
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(244, 207);
            this.lblDescription.Name = "lbl_Description";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description :";
            // 
            // lbl_Genre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(268, 179);
            this.lblGenre.Name = "lbl_Genre";
            this.lblGenre.Size = new System.Drawing.Size(42, 13);
            this.lblGenre.TabIndex = 19;
            this.lblGenre.Text = "Genre :";
            // 
            // lbl_Rating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(266, 152);
            this.lblRating.Name = "lbl_Rating";
            this.lblRating.Size = new System.Drawing.Size(44, 13);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating :";
            // 
            // lbl_Actors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(267, 126);
            this.lblActors.Name = "lbl_Actors";
            this.lblActors.Size = new System.Drawing.Size(43, 13);
            this.lblActors.TabIndex = 17;
            this.lblActors.Text = "Actors :";
            // 
            // lbl_Director
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(260, 100);
            this.lblDirector.Name = "lbl_Director";
            this.lblDirector.Size = new System.Drawing.Size(50, 13);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Director :";
            // 
            // lbl_Year
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(275, 74);
            this.lblYear.Name = "lbl_Year";
            this.lblYear.Size = new System.Drawing.Size(35, 13);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Year :";
            // 
            // lbl_Movie_Title
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(245, 48);
            this.lblMovieTitle.Name = "lbl_Movie_Title";
            this.lblMovieTitle.Size = new System.Drawing.Size(65, 13);
            this.lblMovieTitle.TabIndex = 14;
            this.lblMovieTitle.Text = "Movie Title :";
            // 
            // cmb_Rating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(316, 149);
            this.cmbRating.MaxDropDownItems = 5;
            this.cmbRating.Name = "cmb_Rating";
            this.cmbRating.Size = new System.Drawing.Size(191, 21);
            this.cmbRating.TabIndex = 6;
            // 
            // btn_UploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(31, 276);
            this.btnUploadImage.Name = "btn_UploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(91, 23);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btn_Cancel_Entry
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 387);
            this.btnCancel.Name = "btn_Cancel_Entry";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_Save_Movie
            // 
            this.btnSaveMovie.Location = new System.Drawing.Point(436, 387);
            this.btnSaveMovie.Name = "btn_Save_Movie";
            this.btnSaveMovie.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMovie.TabIndex = 11;
            this.btnSaveMovie.Text = "Save";
            this.btnSaveMovie.UseVisualStyleBackColor = true;
            this.btnSaveMovie.Click += new System.EventHandler(this.btnSaveMovie_Click);
            // 
            // txt_Tags
            // 
            this.txtTags.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTags.Location = new System.Drawing.Point(316, 278);
            this.txtTags.Name = "txt_Tags";
            this.txtTags.Size = new System.Drawing.Size(191, 20);
            this.txtTags.TabIndex = 9;
            // 
            // txt_Description
            // 
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDescription.Location = new System.Drawing.Point(316, 204);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txt_Description";
            this.txtDescription.Size = new System.Drawing.Size(191, 68);
            this.txtDescription.TabIndex = 8;
            // 
            // txt_Genre
            // 
            this.txtGenre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtGenre.Location = new System.Drawing.Point(316, 176);
            this.txtGenre.Name = "txt_Genre";
            this.txtGenre.Size = new System.Drawing.Size(191, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txt_Actors
            // 
            this.txtActors.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtActors.Location = new System.Drawing.Point(316, 123);
            this.txtActors.Name = "txt_Actors";
            this.txtActors.Size = new System.Drawing.Size(191, 20);
            this.txtActors.TabIndex = 5;
            // 
            // txt_Director
            // 
            this.txtDirector.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDirector.Location = new System.Drawing.Point(316, 97);
            this.txtDirector.Name = "txt_Director";
            this.txtDirector.Size = new System.Drawing.Size(191, 20);
            this.txtDirector.TabIndex = 4;
            // 
            // txt_Year
            // 
            this.txtYear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtYear.Location = new System.Drawing.Point(316, 71);
            this.txtYear.Name = "txt_Year";
            this.txtYear.Size = new System.Drawing.Size(191, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txt_MovieTitle
            // 
            this.txtMovieTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMovieTitle.Location = new System.Drawing.Point(316, 45);
            this.txtMovieTitle.Name = "txt_MovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(191, 20);
            this.txtMovieTitle.TabIndex = 2;
            // 
            // pic_EditMovieImage
            // 
            this.picEditMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEditMovieImage.Location = new System.Drawing.Point(31, 45);
            this.picEditMovieImage.Name = "pic_EditMovieImage";
            this.picEditMovieImage.Size = new System.Drawing.Size(185, 228);
            this.picEditMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditMovieImage.TabIndex = 0;
            this.picEditMovieImage.TabStop = false;
            // 
            // DataEntryAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 439);
            this.Controls.Add(this.DataEntryPanel);
            this.MaximumSize = new System.Drawing.Size(558, 478);
            this.MinimumSize = new System.Drawing.Size(558, 478);
            this.Name = "DataEntryAbstract";
            this.Text = "DataEntryAbstract";
            this.Load += new System.EventHandler(this.DataEntryAbstract_Load);
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditMovieImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataEntryPanel;
        protected System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveMovie;
        protected System.Windows.Forms.TextBox txtTags;
        protected System.Windows.Forms.TextBox txtDescription;
        protected System.Windows.Forms.TextBox txtGenre;
        protected System.Windows.Forms.TextBox txtActors;
        protected System.Windows.Forms.TextBox txtDirector;
        protected System.Windows.Forms.TextBox txtYear;
        protected System.Windows.Forms.TextBox txtMovieTitle;
        protected System.Windows.Forms.PictureBox picEditMovieImage;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Button btnDeleteMovie;

    }
}