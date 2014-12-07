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
            this.lbl_Question = new System.Windows.Forms.Label();
            this.btn_Rating = new System.Windows.Forms.Button();
            this.btn_Recent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(76, 57);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(312, 18);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "What type of recommendation would you like?";
            // 
            // btn_Rating
            // 
            this.btn_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rating.Location = new System.Drawing.Point(102, 106);
            this.btn_Rating.Name = "btn_Rating";
            this.btn_Rating.Size = new System.Drawing.Size(89, 50);
            this.btn_Rating.TabIndex = 1;
            this.btn_Rating.Text = "Rating";
            this.btn_Rating.UseVisualStyleBackColor = true;
            this.btn_Rating.Click += new System.EventHandler(this.btn_Rating_Click);
            // 
            // btn_Recent
            // 
            this.btn_Recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recent.Location = new System.Drawing.Point(265, 106);
            this.btn_Recent.Name = "btn_Recent";
            this.btn_Recent.Size = new System.Drawing.Size(89, 50);
            this.btn_Recent.TabIndex = 2;
            this.btn_Recent.Text = "Recently Viewed";
            this.btn_Recent.UseVisualStyleBackColor = true;
            this.btn_Recent.Click += new System.EventHandler(this.btn_Recent_Click);
            // 
            // Suggest_Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.btn_Recent);
            this.Controls.Add(this.btn_Rating);
            this.Controls.Add(this.lbl_Question);
            this.Name = "Suggest_Modal";
            this.Text = "Suggest A Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Button btn_Rating;
        private System.Windows.Forms.Button btn_Recent;
    }
}