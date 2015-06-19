namespace MovieOrganizer
{
    partial class SuggestModal
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(76, 57);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(312, 18);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What type of recommendation would you like?";
            // 
            // btnRating
            // 
            this.btnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.Location = new System.Drawing.Point(102, 106);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(89, 50);
            this.btnRating.TabIndex = 1;
            this.btnRating.Text = "Rating";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.Location = new System.Drawing.Point(265, 106);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(89, 50);
            this.btnRecent.TabIndex = 2;
            this.btnRecent.Text = "Recently Viewed";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // SuggestModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.lblQuestion);
            this.MaximumSize = new System.Drawing.Size(481, 240);
            this.MinimumSize = new System.Drawing.Size(481, 240);
            this.Name = "SuggestModal";
            this.Text = "Suggest A Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.Button btnRecent;
    }
}