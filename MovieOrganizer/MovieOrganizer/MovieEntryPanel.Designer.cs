namespace MovieOrganizer
{
    partial class MovieEntryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMovieIcon = new System.Windows.Forms.PictureBox();
            this.lnkName = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnListRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picMovieIcon
            // 
            this.picMovieIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMovieIcon.Location = new System.Drawing.Point(21, 10);
            this.picMovieIcon.Name = "picMovieIcon";
            this.picMovieIcon.Size = new System.Drawing.Size(91, 85);
            this.picMovieIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMovieIcon.TabIndex = 0;
            this.picMovieIcon.TabStop = false;
            this.picMovieIcon.Click += new System.EventHandler(this.picMovieIcon_Click);
            this.picMovieIcon.MouseEnter += new System.EventHandler(this.picMovieIcon_MouseEnter);
            this.picMovieIcon.MouseLeave += new System.EventHandler(this.picMovieIcon_MouseLeave);
            // 
            // lnkName
            // 
            this.lnkName.AutoSize = true;
            this.lnkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkName.LinkColor = System.Drawing.Color.Black;
            this.lnkName.Location = new System.Drawing.Point(137, 30);
            this.lnkName.Name = "lnkName";
            this.lnkName.Size = new System.Drawing.Size(51, 20);
            this.lnkName.TabIndex = 1;
            this.lnkName.TabStop = true;
            this.lnkName.Text = "Name";
            this.lnkName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkName_LinkClicked);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnListRemove
            // 
            this.btnListRemove.Location = new System.Drawing.Point(141, 53);
            this.btnListRemove.Name = "btnListRemove";
            this.btnListRemove.Size = new System.Drawing.Size(116, 23);
            this.btnListRemove.TabIndex = 3;
            this.btnListRemove.Text = "Remove from List";
            this.btnListRemove.UseVisualStyleBackColor = true;
            this.btnListRemove.Click += new System.EventHandler(this.btnListRemove_Click);
            // 
            // MovieEntryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnListRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lnkName);
            this.Controls.Add(this.picMovieIcon);
            this.Name = "MovieEntryPanel";
            this.Size = new System.Drawing.Size(366, 105);
            ((System.ComponentModel.ISupportInitialize)(this.picMovieIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMovieIcon;
        private System.Windows.Forms.LinkLabel lnkName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnListRemove;
    }
}
