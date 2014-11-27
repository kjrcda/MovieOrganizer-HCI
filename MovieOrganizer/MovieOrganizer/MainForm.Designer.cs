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
            this.btn_pLibrary_ViewMain = new System.Windows.Forms.Button();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.btn_pMain_AddMovie = new System.Windows.Forms.Button();
            this.btn_pMain_ViewLibrary = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.txt_placeHolder = new System.Windows.Forms.TextBox();
            this.LibraryPanel.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pLibrary_ViewMain
            // 
            this.btn_pLibrary_ViewMain.Location = new System.Drawing.Point(153, 146);
            this.btn_pLibrary_ViewMain.Name = "btn_pLibrary_ViewMain";
            this.btn_pLibrary_ViewMain.Size = new System.Drawing.Size(110, 41);
            this.btn_pLibrary_ViewMain.TabIndex = 1;
            this.btn_pLibrary_ViewMain.Text = "Return to Main Menu";
            this.btn_pLibrary_ViewMain.UseVisualStyleBackColor = true;
            this.btn_pLibrary_ViewMain.Click += new System.EventHandler(this.btn_pLibrary_ViewMain_Click);
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.btn_pLibrary_ViewMain);
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(605, 615);
            this.LibraryPanel.TabIndex = 2;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.btn_pMain_AddMovie);
            this.MainMenuPanel.Controls.Add(this.btn_pMain_ViewLibrary);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(605, 615);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // btn_pMain_AddMovie
            // 
            this.btn_pMain_AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pMain_AddMovie.Location = new System.Drawing.Point(222, 177);
            this.btn_pMain_AddMovie.Name = "btn_pMain_AddMovie";
            this.btn_pMain_AddMovie.Size = new System.Drawing.Size(110, 41);
            this.btn_pMain_AddMovie.TabIndex = 0;
            this.btn_pMain_AddMovie.Text = "Add Movie";
            this.btn_pMain_AddMovie.UseVisualStyleBackColor = true;
            this.btn_pMain_AddMovie.Click += new System.EventHandler(this.btn_pMain_AddMovie_Click);
            // 
            // btn_pMain_ViewLibrary
            // 
            this.btn_pMain_ViewLibrary.Location = new System.Drawing.Point(222, 130);
            this.btn_pMain_ViewLibrary.Name = "btn_pMain_ViewLibrary";
            this.btn_pMain_ViewLibrary.Size = new System.Drawing.Size(110, 41);
            this.btn_pMain_ViewLibrary.TabIndex = 1;
            this.btn_pMain_ViewLibrary.Text = "View Library";
            this.btn_pMain_ViewLibrary.UseVisualStyleBackColor = true;
            this.btn_pMain_ViewLibrary.Click += new System.EventHandler(this.btn_pMain_ViewLibrary_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.txt_placeHolder);
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(605, 72);
            this.NavigationPanel.TabIndex = 2;
            // 
            // txt_placeHolder
            // 
            this.txt_placeHolder.Location = new System.Drawing.Point(3, 22);
            this.txt_placeHolder.Name = "txt_placeHolder";
            this.txt_placeHolder.Size = new System.Drawing.Size(576, 20);
            this.txt_placeHolder.TabIndex = 0;
            this.txt_placeHolder.Text = "Ideally we\'ll have tag-like objects here that will link to the panel options the " +
    "main menu provides";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LibraryPanel);
            this.Name = "MainForm";
            this.Text = "Movie Organizer";
            this.LibraryPanel.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pLibrary_ViewMain;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button btn_pMain_AddMovie;
        private System.Windows.Forms.Button btn_pMain_ViewLibrary;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.TextBox txt_placeHolder;
    }
}

