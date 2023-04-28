namespace FinalProject
{
    partial class Workers_GUI_main
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
            this.Res_GV = new System.Windows.Forms.DataGridView();
            this.table_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinner_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avg_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New_table_btn = new System.Windows.Forms.Button();
            this.Open_table_btn = new System.Windows.Forms.Button();
            this.Recive_btn = new System.Windows.Forms.Button();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.Open_cash_register_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Fast_info_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Reopen_tbl_btn = new System.Windows.Forms.Button();
            this.Delete_tbl_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Res_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // Res_GV
            // 
            this.Res_GV.AllowUserToDeleteRows = false;
            this.Res_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Res_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_num,
            this.waiter,
            this.open_date,
            this.Dinner_num,
            this.Total_price,
            this.Avg_price,
            this.recive,
            this.notes});
            this.Res_GV.Location = new System.Drawing.Point(55, 162);
            this.Res_GV.MultiSelect = false;
            this.Res_GV.Name = "Res_GV";
            this.Res_GV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Res_GV.RowHeadersWidth = 51;
            this.Res_GV.RowTemplate.Height = 24;
            this.Res_GV.Size = new System.Drawing.Size(960, 232);
            this.Res_GV.TabIndex = 0;
            this.Res_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // table_num
            // 
            this.table_num.HeaderText = "שולחן";
            this.table_num.MinimumWidth = 6;
            this.table_num.Name = "table_num";
            this.table_num.Width = 125;
            // 
            // waiter
            // 
            this.waiter.HeaderText = "מלצר מדפיס";
            this.waiter.MinimumWidth = 6;
            this.waiter.Name = "waiter";
            this.waiter.Width = 125;
            // 
            // open_date
            // 
            this.open_date.HeaderText = "זמן ישיבה";
            this.open_date.MinimumWidth = 6;
            this.open_date.Name = "open_date";
            this.open_date.Width = 125;
            // 
            // Dinner_num
            // 
            this.Dinner_num.HeaderText = "מספר סועדים";
            this.Dinner_num.MinimumWidth = 6;
            this.Dinner_num.Name = "Dinner_num";
            this.Dinner_num.Width = 125;
            // 
            // Total_price
            // 
            this.Total_price.HeaderText = "מחיר שולחן";
            this.Total_price.MinimumWidth = 6;
            this.Total_price.Name = "Total_price";
            this.Total_price.Width = 125;
            // 
            // Avg_price
            // 
            this.Avg_price.HeaderText = "ממוצע לסועד";
            this.Avg_price.MinimumWidth = 6;
            this.Avg_price.Name = "Avg_price";
            this.Avg_price.Width = 125;
            // 
            // recive
            // 
            this.recive.HeaderText = "יצא חשבון ?";
            this.recive.MinimumWidth = 6;
            this.recive.Name = "recive";
            this.recive.Width = 125;
            // 
            // notes
            // 
            this.notes.HeaderText = "הערות כלליות לשולחן";
            this.notes.MinimumWidth = 6;
            this.notes.Name = "notes";
            this.notes.Width = 125;
            // 
            // New_table_btn
            // 
            this.New_table_btn.Location = new System.Drawing.Point(889, 448);
            this.New_table_btn.Name = "New_table_btn";
            this.New_table_btn.Size = new System.Drawing.Size(159, 115);
            this.New_table_btn.TabIndex = 1;
            this.New_table_btn.Text = "פתח שולחן חדש";
            this.New_table_btn.UseVisualStyleBackColor = true;
            // 
            // Open_table_btn
            // 
            this.Open_table_btn.Location = new System.Drawing.Point(724, 448);
            this.Open_table_btn.Name = "Open_table_btn";
            this.Open_table_btn.Size = new System.Drawing.Size(159, 115);
            this.Open_table_btn.TabIndex = 2;
            this.Open_table_btn.Text = "כניסה לשולחן שנבחר";
            this.Open_table_btn.UseVisualStyleBackColor = true;
            // 
            // Recive_btn
            // 
            this.Recive_btn.Location = new System.Drawing.Point(559, 448);
            this.Recive_btn.Name = "Recive_btn";
            this.Recive_btn.Size = new System.Drawing.Size(159, 115);
            this.Recive_btn.TabIndex = 3;
            this.Recive_btn.Text = "חשבון";
            this.Recive_btn.UseVisualStyleBackColor = true;
            // 
            // Pay_btn
            // 
            this.Pay_btn.Location = new System.Drawing.Point(394, 448);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(159, 115);
            this.Pay_btn.TabIndex = 4;
            this.Pay_btn.Text = "תשלום";
            this.Pay_btn.UseVisualStyleBackColor = true;
            // 
            // Open_cash_register_btn
            // 
            this.Open_cash_register_btn.Location = new System.Drawing.Point(21, 460);
            this.Open_cash_register_btn.Name = "Open_cash_register_btn";
            this.Open_cash_register_btn.Size = new System.Drawing.Size(107, 45);
            this.Open_cash_register_btn.TabIndex = 5;
            this.Open_cash_register_btn.Text = "פתיחת קופה";
            this.Open_cash_register_btn.UseVisualStyleBackColor = true;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(134, 460);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(107, 45);
            this.Refresh_btn.TabIndex = 6;
            this.Refresh_btn.Text = "רענון רשת";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            // 
            // Fast_info_btn
            // 
            this.Fast_info_btn.Location = new System.Drawing.Point(247, 460);
            this.Fast_info_btn.Name = "Fast_info_btn";
            this.Fast_info_btn.Size = new System.Drawing.Size(107, 45);
            this.Fast_info_btn.TabIndex = 7;
            this.Fast_info_btn.Text = "מידע מהיר";
            this.Fast_info_btn.UseVisualStyleBackColor = true;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(21, 509);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(107, 45);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.Text = "יציאה מהתוכנה";
            this.Exit_btn.UseVisualStyleBackColor = true;
            // 
            // Reopen_tbl_btn
            // 
            this.Reopen_tbl_btn.Location = new System.Drawing.Point(134, 509);
            this.Reopen_tbl_btn.Name = "Reopen_tbl_btn";
            this.Reopen_tbl_btn.Size = new System.Drawing.Size(107, 45);
            this.Reopen_tbl_btn.TabIndex = 9;
            this.Reopen_tbl_btn.Text = "שחזר שולחן";
            this.Reopen_tbl_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_tbl_btn
            // 
            this.Delete_tbl_btn.Location = new System.Drawing.Point(247, 509);
            this.Delete_tbl_btn.Name = "Delete_tbl_btn";
            this.Delete_tbl_btn.Size = new System.Drawing.Size(107, 45);
            this.Delete_tbl_btn.TabIndex = 10;
            this.Delete_tbl_btn.Text = "בטל שולחן";
            this.Delete_tbl_btn.UseVisualStyleBackColor = true;
            // 
            // Workers_GUI_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 602);
            this.Controls.Add(this.Delete_tbl_btn);
            this.Controls.Add(this.Reopen_tbl_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Fast_info_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Open_cash_register_btn);
            this.Controls.Add(this.Pay_btn);
            this.Controls.Add(this.Recive_btn);
            this.Controls.Add(this.Open_table_btn);
            this.Controls.Add(this.New_table_btn);
            this.Controls.Add(this.Res_GV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workers_GUI_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table_general";
            ((System.ComponentModel.ISupportInitialize)(this.Res_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Res_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn open_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinner_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avg_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn recive;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.Button New_table_btn;
        private System.Windows.Forms.Button Open_table_btn;
        private System.Windows.Forms.Button Recive_btn;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Button Open_cash_register_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Fast_info_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Reopen_tbl_btn;
        private System.Windows.Forms.Button Delete_tbl_btn;
    }
}