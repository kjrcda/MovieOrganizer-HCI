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
            this.DataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EditMovieImage)).BeginInit();
            this.SuspendLayout();
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
            this.DataEntryPanel.TabIndex = 1;
            // 
            // cmb_Rating
            // 
            this.cmb_Rating.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmb_Rating.FormattingEnabled = true;
            this.cmb_Rating.Location = new System.Drawing.Point(233, 202);
            this.cmb_Rating.Name = "cmb_Rating";
            this.cmb_Rating.Size = new System.Drawing.Size(191, 21);
            this.cmb_Rating.TabIndex = 6;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(16, 326);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(91, 23);
            this.btn_UploadImage.TabIndex = 10;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            // 
            // btn_pDataEntry_modalConfirmation_DeleteMovie
            // 
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Location = new System.Drawing.Point(12, 578);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Name = "btn_pDataEntry_modalConfirmation_DeleteMovie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Size = new System.Drawing.Size(95, 23);
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.TabIndex = 13;
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.Text = "Delete Movie";
            this.btn_pDataEntry_modalConfirmation_DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btn_pDataEntry_pLibrary_Cancel
            // 
            this.btn_pDataEntry_pLibrary_Cancel.Location = new System.Drawing.Point(435, 578);
            this.btn_pDataEntry_pLibrary_Cancel.Name = "btn_pDataEntry_pLibrary_Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_pDataEntry_pLibrary_Cancel.TabIndex = 12;
            this.btn_pDataEntry_pLibrary_Cancel.Text = "Cancel";
            this.btn_pDataEntry_pLibrary_Cancel.UseVisualStyleBackColor = true;
            this.btn_pDataEntry_pLibrary_Cancel.Click += new System.EventHandler(this.btn_pDataEntry_pLibrary_Cancel_Click);
            // 
            // btn_pDataEntry_pLibrary_Save
            // 
            this.btn_pDataEntry_pLibrary_Save.Location = new System.Drawing.Point(516, 578);
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
            this.txt_Tags.Location = new System.Drawing.Point(233, 329);
            this.txt_Tags.Name = "txt_Tags";
            this.txt_Tags.Size = new System.Drawing.Size(191, 20);
            this.txt_Tags.TabIndex = 9;
            // 
            // txt_Description
            // 
            this.txt_Description.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Description.Location = new System.Drawing.Point(233, 255);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(191, 68);
            this.txt_Description.TabIndex = 8;
            // 
            // txt_Genre
            // 
            this.txt_Genre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Genre.Location = new System.Drawing.Point(233, 229);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(191, 20);
            this.txt_Genre.TabIndex = 7;
            // 
            // txt_Actors
            // 
            this.txt_Actors.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Actors.Location = new System.Drawing.Point(233, 177);
            this.txt_Actors.Name = "txt_Actors";
            this.txt_Actors.Size = new System.Drawing.Size(191, 20);
            this.txt_Actors.TabIndex = 5;
            // 
            // txt_Director
            // 
            this.txt_Director.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Director.Location = new System.Drawing.Point(233, 151);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(191, 20);
            this.txt_Director.TabIndex = 4;
            // 
            // txt_Year
            // 
            this.txt_Year.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Year.Location = new System.Drawing.Point(233, 125);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(191, 20);
            this.txt_Year.TabIndex = 3;
            // 
            // txt_MovieTitle
            // 
            this.txt_MovieTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_MovieTitle.Location = new System.Drawing.Point(233, 99);
            this.txt_MovieTitle.Name = "txt_MovieTitle";
            this.txt_MovieTitle.Size = new System.Drawing.Size(191, 20);
            this.txt_MovieTitle.TabIndex = 2;
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
            // DataEntryAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 615);
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
        private System.Windows.Forms.ComboBox cmb_Rating;
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

    }
}