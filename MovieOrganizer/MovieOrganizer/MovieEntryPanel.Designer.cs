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
            this.pic_Movie_Icon = new System.Windows.Forms.PictureBox();
            this.lnk_Name = new System.Windows.Forms.LinkLabel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Remove_from_list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Movie_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Movie_Icon
            // 
            this.pic_Movie_Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Movie_Icon.Location = new System.Drawing.Point(21, 10);
            this.pic_Movie_Icon.Name = "pic_Movie_Icon";
            this.pic_Movie_Icon.Size = new System.Drawing.Size(91, 85);
            this.pic_Movie_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Movie_Icon.TabIndex = 0;
            this.pic_Movie_Icon.TabStop = false;
            this.pic_Movie_Icon.Click += new System.EventHandler(this.pic_Movie_Icon_Click);
            this.pic_Movie_Icon.MouseEnter += new System.EventHandler(this.pic_Movie_Icon_MouseEnter);
            this.pic_Movie_Icon.MouseLeave += new System.EventHandler(this.pic_Movie_Icon_MouseLeave);
            // 
            // lnk_Name
            // 
            this.lnk_Name.AutoSize = true;
            this.lnk_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnk_Name.LinkColor = System.Drawing.Color.Black;
            this.lnk_Name.Location = new System.Drawing.Point(137, 30);
            this.lnk_Name.Name = "lnk_Name";
            this.lnk_Name.Size = new System.Drawing.Size(51, 20);
            this.lnk_Name.TabIndex = 1;
            this.lnk_Name.TabStop = true;
            this.lnk_Name.Text = "Name";
            this.lnk_Name.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Name_LinkClicked);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(141, 53);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Remove_from_list
            // 
            this.btn_Remove_from_list.Location = new System.Drawing.Point(141, 53);
            this.btn_Remove_from_list.Name = "btn_Remove_from_list";
            this.btn_Remove_from_list.Size = new System.Drawing.Size(116, 23);
            this.btn_Remove_from_list.TabIndex = 3;
            this.btn_Remove_from_list.Text = "Remove from List";
            this.btn_Remove_from_list.UseVisualStyleBackColor = true;
            this.btn_Remove_from_list.Click += new System.EventHandler(this.btn_Remove_from_list_Click);
            // 
            // MovieEntryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btn_Remove_from_list);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lnk_Name);
            this.Controls.Add(this.pic_Movie_Icon);
            this.Name = "MovieEntryPanel";
            this.Size = new System.Drawing.Size(366, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Movie_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Movie_Icon;
        private System.Windows.Forms.LinkLabel lnk_Name;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Remove_from_list;
    }
}
