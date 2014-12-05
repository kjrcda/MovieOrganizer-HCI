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
            this.lbl_Tags = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_Actors = new System.Windows.Forms.Label();
            this.lbl_Director = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Movie_Title = new System.Windows.Forms.Label();
            this.cmb_Rating = new System.Windows.Forms.ComboBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
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
            this.btn_pDataEntry_modalConfirmation_DeleteMovie = new System.Windows.Forms.Button();
            this.DataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataEntryPanel
            // 
            this.DataEntryPanel.Controls.Add(this.btn_pDataEntry_modalConfirmation_DeleteMovie);
            this.DataEntryPanel.Controls.Add(this.lbl_Tags);
            this.DataEntryPanel.Controls.Add(this.lbl_Description);
            this.DataEntryPanel.Controls.Add(this.lbl_Genre);
            this.DataEntryPanel.Controls.Add(this.lbl_Rating);
            this.DataEntryPanel.Controls.Add(this.lbl_Actors);
            this.DataEntryPanel.Controls.Add(this.lbl_Director);
            this.DataEntryPanel.Controls.Add(this.lbl_Year);
            this.DataEntryPanel.Controls.Add(this.lbl_Movie_Title);
            this.DataEntryPanel.Controls.Add(this.cmb_Rating);
            this.DataEntryPanel.Controls.Add(this.btn_UploadImage);
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
            this.DataEntryPanel.Size = new System.Drawing.Size(542, 438);
            this.DataEntryPanel.TabIndex = 1;
            // 
            // lbl_Tags
            // 
            this.lbl_Tags.AutoSize = true;
            this.lbl_Tags.Location = new System.Drawing.Point(273, 281);
            this.lbl_Tags.Name = "lbl_Tags";
            this.lbl_Tags.Size = new System.Drawing.Size(37, 13);
            this.lbl_Tags.TabIndex = 21;
            this.lbl_Tags.Text = "Tags :";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(244, 207);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(66, 13);
            this.lbl_Description.TabIndex = 20;
            this.lbl_Description.Text = "Description :";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(268, 179);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(42, 13);
            this.lbl_Genre.TabIndex = 19;
            this.lbl_Genre.Text = "Genre :";
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.AutoSize = true;
            this.lbl_Rating.Location = new System.Drawing.Point(266, 152);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(44, 13);
            this.lbl_Rating.TabIndex = 18;
            this.lbl_Rating.Text = "Rating :";
            // 
            // lbl_Actors
            // 
            this.lbl_Actors.AutoSize = true;
            this.lbl_Actors.Location = new System.Drawing.Point(267, 126);
            this.lbl_Actors.Name = "lbl_Actors";
            this.lbl_Actors.Size = new System.Drawing.Size(43, 13);
            this.lbl_Actors.TabIndex = 17;
            this.lbl_Actors.Text = "Actors :";
            // 
            // lbl_Director
            // 
            this.lbl_Director.AutoSize = true;
            this.lbl_Director.Location = new System.Drawing.Point(260, 100);
            this.lbl_Director.Name = "lbl_Director";
            this.lbl_Director.Size = new System.Drawing.Size(50, 13);
            this.lbl_Director.TabIndex = 16;
            this.lbl_Director.Text = "Director :";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(275, 74);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(35, 13);
            this.lbl_Year.TabIndex = 15;
            this.lbl_Year.Text = "Year :";
            // 
            // lbl_Movie_Title
            // 
            this.lbl_Movie_Title.AutoSize = true;
            this.lbl_Movie_Title.Location = new System.Drawing.Point(245, 48);
            this.lbl_Movie_Title.Name = "lbl_Movie_Title";
            this.lbl_Movie_Title.Size = new System.Drawing.Size(65, 13);
            this.lbl_Movie_Title.TabIndex = 14;
            this.lbl_Movie_Title.Text = "Movie Title :";
            // 
            // cmb_Rating
            // 
            this.cmb_Rating.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmb_Rating.FormattingEnabled = true;
            this.cmb_Rating.Location = new System.Drawing.Point(316, 149);
            this.cmb_Rating.Name = "cmb_Rating";
            this.cmb_Rating.Size = new System.Drawing.Size(191, 21);
            this.cmb_Rating.TabIndex = 6;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(31, 276);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(91, 23);
            this.btn_UploadImage.TabIndex = 10;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            // 
            // btn_pDataEntry_pLibrary_Cancel
            // 
            this.btn_pDataEntry_pLibrary_Cancel.Location = new System.Drawing.Point(355, 387);
            this.btn_pDataEntry_pLibrary_Cancel.Name = "btn_pDataEntry_pLibrary_Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_pDataEntry_pLibrary_Cancel.TabIndex = 12;
            this.btn_pDataEntry_pLibrary_Cancel.Text = "Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_pLibrary_Cancel.Click += new System.EventHandler(this.btn_pDataEntry_pLibrary_Cancel_Click);
            // 
            // btn_pDataEntry_pLibrary_Save
            // 
            this.btn_pDataEntry_pLibrary_Save.Location = new System.Drawing.Point(436, 387);
            this.btn_pDataEntry_pLibrary_Save.Name = "btn_pDataEntry_pLibrary_Save";
            this.btn_pDataEntry_pLibrary_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_pDataEntry_pLibrary_Save.TabIndex = 11;
            this.btn_pDataEntry_pLibrary_Save.Text = "Save";
            this.btn_pDataEntry_pLibrary_Save.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_pLibrary_Save.Click += new System.EventHandler(this.btn_pDataEntry_pLibrary_Save_Click);
            // 
            // txt_Tags
            // 
            this.txt_Tags.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Tags.Location = new System.Drawing.Point(316, 278);
            this.txt_Tags.Name = "txt_Tags";
            this.txt_Tags.Size = new System.Drawing.Size(191, 20);
            this.txt_Tags.TabIndex = 9;
            // 
            // txt_Description
            // 
            this.txt_Description.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Description.Location = new System.Drawing.Point(316, 204);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(191, 68);
            this.txt_Description.TabIndex = 8;
            // 
            // txt_Genre
            // 
            this.txt_Genre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Genre.Location = new System.Drawing.Point(316, 176);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(191, 20);
            this.txt_Genre.TabIndex = 7;
            // 
            // txt_Actors
            // 
            this.txt_Actors.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Actors.Location = new System.Drawing.Point(316, 123);
            this.txt_Actors.Name = "txt_Actors";
            this.txt_Actors.Size = new System.Drawing.Size(191, 20);
            this.txt_Actors.TabIndex = 5;
            // 
            // txt_Director
            // 
            this.txt_Director.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Director.Location = new System.Drawing.Point(316, 97);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(191, 20);
            this.txt_Director.TabIndex = 4;
            // 
            // txt_Year
            // 
            this.txt_Year.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Year.Location = new System.Drawing.Point(316, 71);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(191, 20);
            this.txt_Year.TabIndex = 3;
            // 
            // txt_MovieTitle
            // 
            this.txt_MovieTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_MovieTitle.Location = new System.Drawing.Point(316, 45);
            this.txt_MovieTitle.Name = "txt_MovieTitle";
            this.txt_MovieTitle.Size = new System.Drawing.Size(191, 20);
            this.txt_MovieTitle.TabIndex = 2;
            // 
            // pic_EditMovieImage
            // 
            this.pic_EditMovieImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_EditMovieImage.Location = new System.Drawing.Point(31, 45);
            this.pic_EditMovieImage.Name = "pic_EditMovieImage";
            this.pic_EditMovieImage.Size = new System.Drawing.Size(185, 228);
            this.pic_EditMovieImage.TabIndex = 0;
            this.pic_EditMovieImage.TabStop = false;
            // 
            // btn_pDataEntry_modalConfirmation_DeleteMovie
            // 
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Location = new System.Drawing.Point(31, 387);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Name = "btn_pDataEntry_modalConfirmation_DeleteMovie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Size = new System.Drawing.Size(95, 23);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.TabIndex = 22;
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Text = "Delete Movie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // DataEntryAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 439);
            this.Controls.Add(this.DataEntryPanel);
            this.Name = "DataEntryAbstract";
            this.Text = "DataEntryAbstract";
            this.DataEntryPanel.ResumeLayout(false);
            this.DataEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditMovieImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataEntryPanel;
        protected System.Windows.Forms.ComboBox cmb_Rating;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Button btn_pDataEntry_pLibrary_Cancel;
        private System.Windows.Forms.Button btn_pDataEntry_pLibrary_Save;
        protected System.Windows.Forms.TextBox txt_Tags;
        protected System.Windows.Forms.TextBox txt_Description;
        protected System.Windows.Forms.TextBox txt_Genre;
        protected System.Windows.Forms.TextBox txt_Actors;
        protected System.Windows.Forms.TextBox txt_Director;
        protected System.Windows.Forms.TextBox txt_Year;
        protected System.Windows.Forms.TextBox txt_MovieTitle;
        protected System.Windows.Forms.PictureBox pic_EditMovieImage;
        private System.Windows.Forms.Label lbl_Movie_Title;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Tags;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Label lbl_Actors;
        private System.Windows.Forms.Label lbl_Director;
        private System.Windows.Forms.Button btn_pDataEntry_modalConfirmation_DeleteMovie;

    }
}