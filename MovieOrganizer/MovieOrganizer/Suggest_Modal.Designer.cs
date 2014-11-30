namespace MovieOrganizer
{
    partial class Suggest_Modal
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
            this.lbl_fSuggestion_question = new System.Windows.Forms.Label();
            this.btn_fSuggestion_Rating = new System.Windows.Forms.Button();
            this.btn_fSuggestion_Viewed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fSuggestion_question
            // 
            this.lbl_fSuggestion_question.AutoSize = true;
            this.lbl_fSuggestion_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fSuggestion_question.Location = new System.Drawing.Point(30, 41);
            this.lbl_fSuggestion_question.Name = "lbl_fSuggestion_question";
            this.lbl_fSuggestion_question.Size = new System.Drawing.Size(297, 17);
            this.lbl_fSuggestion_question.TabIndex = 0;
            this.lbl_fSuggestion_question.Text = "What type of recommendation would you like?";
            // 
            // btn_fSuggestion_Rating
            // 
            this.btn_fSuggestion_Rating.Location = new System.Drawing.Point(33, 71);
            this.btn_fSuggestion_Rating.Name = "btn_fSuggestion_Rating";
            this.btn_fSuggestion_Rating.Size = new System.Drawing.Size(118, 23);
            this.btn_fSuggestion_Rating.TabIndex = 1;
            this.btn_fSuggestion_Rating.Text = "Rating";
            this.btn_fSuggestion_Rating.UseVisualStyleBackColor = true;
            // 
            // btn_fSuggestion_Viewed
            // 
            this.btn_fSuggestion_Viewed.Location = new System.Drawing.Point(209, 71);
            this.btn_fSuggestion_Viewed.Name = "btn_fSuggestion_Viewed";
            this.btn_fSuggestion_Viewed.Size = new System.Drawing.Size(118, 23);
            this.btn_fSuggestion_Viewed.TabIndex = 2;
            this.btn_fSuggestion_Viewed.Text = "Recently Viewed";
            this.btn_fSuggestion_Viewed.UseVisualStyleBackColor = true;
            // 
            // Suggest_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 148);
            this.Controls.Add(this.btn_fSuggestion_Viewed);
            this.Controls.Add(this.btn_fSuggestion_Rating);
            this.Controls.Add(this.lbl_fSuggestion_question);
            this.Name = "Suggest_Modal";
            this.Text = "Suggest A Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fSuggestion_question;
        private System.Windows.Forms.Button btn_fSuggestion_Rating;
        private System.Windows.Forms.Button btn_fSuggestion_Viewed;
    }
}