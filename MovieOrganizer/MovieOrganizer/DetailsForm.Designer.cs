namespace MovieOrganizer
{
    partial class DetailsForm
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
            this.label = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWish = new System.Windows.Forms.Button();
            this.btnGift = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(239, 91);
            this.label.Name = "lbl_label";
            this.label.Size = new System.Drawing.Size(79, 16);
            this.label.TabIndex = 29;
            this.label.Text = "Description:";
            // 
            // lbl_Movie_Title
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(237, 32);
            this.lblMovieTitle.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblMovieTitle.Name = "lbl_Movie_Title";
            this.lblMovieTitle.Size = new System.Drawing.Size(128, 25);
            this.lblMovieTitle.TabIndex = 23;
            this.lblMovieTitle.Text = "movie name";
            // 
            // pic_Cover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(34, 32);
            this.picCover.Name = "pic_Cover";
            this.picCover.Size = new System.Drawing.Size(185, 228);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 22;
            this.picCover.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Director: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Genre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Year: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Rating: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Actors: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tags: ";
            // 
            // lbl_Description
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(239, 117);
            this.lblDescription.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDescription.Name = "lbl_Description";
            this.lblDescription.Size = new System.Drawing.Size(76, 15);
            this.lblDescription.TabIndex = 36;
            this.lblDescription.Text = "decribe here";
            // 
            // lbl_Director
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(98, 283);
            this.lblDirector.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblDirector.Name = "lbl_Director";
            this.lblDirector.Size = new System.Drawing.Size(49, 15);
            this.lblDirector.TabIndex = 37;
            this.lblDirector.Text = "dir here";
            // 
            // lbl_Genre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(98, 308);
            this.lblGenre.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblGenre.Name = "lbl_Genre";
            this.lblGenre.Size = new System.Drawing.Size(67, 15);
            this.lblGenre.TabIndex = 38;
            this.lblGenre.Text = "genre here";
            // 
            // lbl_Year
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(98, 333);
            this.lblYear.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblYear.Name = "lbl_Year";
            this.lblYear.Size = new System.Drawing.Size(58, 15);
            this.lblYear.TabIndex = 39;
            this.lblYear.Text = "year here";
            // 
            // lbl_Rating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(95, 352);
            this.lblRating.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblRating.Name = "lbl_Rating";
            this.lblRating.Size = new System.Drawing.Size(98, 29);
            this.lblRating.TabIndex = 40;
            this.lblRating.Text = "☆☆☆☆☆";
            // 
            // lbl_Actors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(98, 384);
            this.lblActors.MaximumSize = new System.Drawing.Size(370, 0);
            this.lblActors.Name = "lbl_Actors";
            this.lblActors.Size = new System.Drawing.Size(68, 15);
            this.lblActors.TabIndex = 41;
            this.lblActors.Text = "actors here";
            // 
            // lbl_Tags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(98, 424);
            this.lblTags.MaximumSize = new System.Drawing.Size(370, 60);
            this.lblTags.Name = "lbl_Tags";
            this.lblTags.Size = new System.Drawing.Size(58, 15);
            this.lblTags.TabIndex = 42;
            this.lblTags.Text = "tags here";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(361, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWish
            // 
            this.btnWish.Location = new System.Drawing.Point(34, 501);
            this.btnWish.Name = "btnWish";
            this.btnWish.Size = new System.Drawing.Size(74, 46);
            this.btnWish.TabIndex = 44;
            this.btnWish.Text = "Add to My Wishlist";
            this.btnWish.UseVisualStyleBackColor = true;
            this.btnWish.Click += new System.EventHandler(this.btnWish_Click);
            // 
            // btnGift
            // 
            this.btnGift.Location = new System.Drawing.Point(114, 501);
            this.btnGift.Name = "btnGift";
            this.btnGift.Size = new System.Drawing.Size(74, 46);
            this.btnGift.TabIndex = 45;
            this.btnGift.Text = "Add to Gift Movies";
            this.btnGift.UseVisualStyleBackColor = true;
            this.btnGift.Click += new System.EventHandler(this.btnGift_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(194, 501);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(74, 46);
            this.btnWatch.TabIndex = 46;
            this.btnWatch.Text = "Add to Watch Next";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 568);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.btnGift);
            this.Controls.Add(this.btnWish);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.picCover);
            this.MaximumSize = new System.Drawing.Size(498, 607);
            this.MinimumSize = new System.Drawing.Size(498, 607);
            this.Name = "DetailsForm";
            this.Text = "Movie Details";
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWish;
        private System.Windows.Forms.Button btnGift;
        private System.Windows.Forms.Button btnWatch;


    }
}