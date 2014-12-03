namespace MovieOrganizer
{
    partial class Sign_In_Form
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
            this.txtBox_fSignIn_Username = new System.Windows.Forms.TextBox();
            this.txtBox_fSignIn_Password = new System.Windows.Forms.TextBox();
            this.btn_fSignIn_OK = new System.Windows.Forms.Button();
            this.btn_fSignIn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_fSignIn_Username
            // 
            this.txtBox_fSignIn_Username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBox_fSignIn_Username.Location = new System.Drawing.Point(23, 22);
            this.txtBox_fSignIn_Username.Name = "txtBox_fSignIn_Username";
            this.txtBox_fSignIn_Username.Size = new System.Drawing.Size(181, 20);
            this.txtBox_fSignIn_Username.TabIndex = 0;
            this.txtBox_fSignIn_Username.Text = "Username";
            // 
            // txtBox_fSignIn_Password
            // 
            this.txtBox_fSignIn_Password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBox_fSignIn_Password.Location = new System.Drawing.Point(23, 48);
            this.txtBox_fSignIn_Password.Name = "txtBox_fSignIn_Password";
            this.txtBox_fSignIn_Password.Size = new System.Drawing.Size(181, 20);
            this.txtBox_fSignIn_Password.TabIndex = 1;
            this.txtBox_fSignIn_Password.Text = "Password";
            // 
            // btn_fSignIn_OK
            // 
            this.btn_fSignIn_OK.Location = new System.Drawing.Point(210, 88);
            this.btn_fSignIn_OK.Name = "btn_fSignIn_OK";
            this.btn_fSignIn_OK.Size = new System.Drawing.Size(62, 23);
            this.btn_fSignIn_OK.TabIndex = 2;
            this.btn_fSignIn_OK.Text = "OK";
            this.btn_fSignIn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_fSignIn_Cancel
            // 
            this.btn_fSignIn_Cancel.Location = new System.Drawing.Point(142, 88);
            this.btn_fSignIn_Cancel.Name = "btn_fSignIn_Cancel";
            this.btn_fSignIn_Cancel.Size = new System.Drawing.Size(62, 23);
            this.btn_fSignIn_Cancel.TabIndex = 3;
            this.btn_fSignIn_Cancel.Text = "Cancel";
            this.btn_fSignIn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Sign_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 129);
            this.Controls.Add(this.btn_fSignIn_Cancel);
            this.Controls.Add(this.btn_fSignIn_OK);
            this.Controls.Add(this.txtBox_fSignIn_Password);
            this.Controls.Add(this.txtBox_fSignIn_Username);
            this.Name = "Sign_In_Form";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_fSignIn_Username;
        private System.Windows.Forms.TextBox txtBox_fSignIn_Password;
        private System.Windows.Forms.Button btn_fSignIn_OK;
        private System.Windows.Forms.Button btn_fSignIn_Cancel;
    }
}