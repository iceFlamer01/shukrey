namespace FinalProject
{
    partial class Manager_start_page
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
            this.Passwordd_txt = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Close_Page = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passwordd_txt
            // 
            this.Passwordd_txt.Location = new System.Drawing.Point(307, 301);
            this.Passwordd_txt.Name = "Passwordd_txt";
            this.Passwordd_txt.Size = new System.Drawing.Size(174, 22);
            this.Passwordd_txt.TabIndex = 0;
            this.Passwordd_txt.TextChanged += new System.EventHandler(this.Passwordd_txt_TextChanged);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(503, 306);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(50, 16);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = ": סיסמה";
            // 
            // Close_Page
            // 
            this.Close_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Page.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Close_Page.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Close_Page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Page.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close_Page.Location = new System.Drawing.Point(789, 0);
            this.Close_Page.Name = "Close_Page";
            this.Close_Page.Size = new System.Drawing.Size(25, 32);
            this.Close_Page.TabIndex = 2;
            this.Close_Page.Text = "X";
            this.Close_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close_Page.Click += new System.EventHandler(this.Close_Page_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(89, 396);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(119, 37);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Login";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Manager_start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 459);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Close_Page);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Passwordd_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_start_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Passwordd_txt;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Close_Page;
        private System.Windows.Forms.Button Calculate;
    }
}