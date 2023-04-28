namespace FinalProject
{
    partial class Manager_GUI
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
            this.Manegar_tabs = new System.Windows.Forms.TabControl();
            this.storage_tab = new System.Windows.Forms.TabPage();
            this.Workers_tab = new System.Windows.Forms.TabPage();
            this.Reports_tab = new System.Windows.Forms.TabPage();
            this.Add_new_pr_btn = new System.Windows.Forms.Button();
            this.Delete_pr_btn = new System.Windows.Forms.Button();
            this.Update_pr_btn = new System.Windows.Forms.Button();
            this.Storage_GV = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units_in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_worker_btn = new System.Windows.Forms.Button();
            this.Delete_worker_btn = new System.Windows.Forms.Button();
            this.Add_new_worker_btn = new System.Windows.Forms.Button();
            this.Workers_GV = new System.Windows.Forms.DataGridView();
            this.Worker_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z_report_btn = new System.Windows.Forms.Button();
            this.Revenue_rep_btn = new System.Windows.Forms.Button();
            this.Expenses_rep_btn = new System.Windows.Forms.Button();
            this.Man_Exit_btn = new System.Windows.Forms.Button();
            this.Search_worker = new System.Windows.Forms.Label();
            this.Worker_name_CB = new System.Windows.Forms.ComboBox();
            this.Worker_salary_CB = new System.Windows.Forms.ComboBox();
            this.Worker_status_CB = new System.Windows.Forms.ComboBox();
            this.Worker_role_CB = new System.Windows.Forms.ComboBox();
            this.Worker_name_lbl = new System.Windows.Forms.Label();
            this.Worker_salry_lbl = new System.Windows.Forms.Label();
            this.Worker_status_lbl = new System.Windows.Forms.Label();
            this.Worker_role_lbl = new System.Windows.Forms.Label();
            this.Search_worker_btn = new System.Windows.Forms.Button();
            this.Start_date_DP = new System.Windows.Forms.DateTimePicker();
            this.end_date_DP = new System.Windows.Forms.DateTimePicker();
            this.Start_date_lbl = new System.Windows.Forms.Label();
            this.start_report_btn = new System.Windows.Forms.Button();
            this.cancel_report_btn = new System.Windows.Forms.Button();
            this.End_date_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.product_cat_lbl = new System.Windows.Forms.Label();
            this.product_units__lbl = new System.Windows.Forms.Label();
            this.Product_price_lbl = new System.Windows.Forms.Label();
            this.Product_name_lbl = new System.Windows.Forms.Label();
            this.product_cat_CB = new System.Windows.Forms.ComboBox();
            this.product_units_CB = new System.Windows.Forms.ComboBox();
            this.Product_price_CB = new System.Windows.Forms.ComboBox();
            this.product_name_CB = new System.Windows.Forms.ComboBox();
            this.Search_product_lbl = new System.Windows.Forms.Label();
            this.Expired_date_lbl = new System.Windows.Forms.Label();
            this.Expired_date_DP = new System.Windows.Forms.DateTimePicker();
            this.Manegar_tabs.SuspendLayout();
            this.storage_tab.SuspendLayout();
            this.Workers_tab.SuspendLayout();
            this.Reports_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Storage_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Workers_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // Manegar_tabs
            // 
            this.Manegar_tabs.Controls.Add(this.storage_tab);
            this.Manegar_tabs.Controls.Add(this.Workers_tab);
            this.Manegar_tabs.Controls.Add(this.Reports_tab);
            this.Manegar_tabs.Location = new System.Drawing.Point(12, 86);
            this.Manegar_tabs.Name = "Manegar_tabs";
            this.Manegar_tabs.RightToLeftLayout = true;
            this.Manegar_tabs.SelectedIndex = 0;
            this.Manegar_tabs.Size = new System.Drawing.Size(1073, 372);
            this.Manegar_tabs.TabIndex = 0;
            // 
            // storage_tab
            // 
            this.storage_tab.Controls.Add(this.Expired_date_DP);
            this.storage_tab.Controls.Add(this.Expired_date_lbl);
            this.storage_tab.Controls.Add(this.search_btn);
            this.storage_tab.Controls.Add(this.product_cat_lbl);
            this.storage_tab.Controls.Add(this.product_units__lbl);
            this.storage_tab.Controls.Add(this.Product_price_lbl);
            this.storage_tab.Controls.Add(this.Product_name_lbl);
            this.storage_tab.Controls.Add(this.product_cat_CB);
            this.storage_tab.Controls.Add(this.product_units_CB);
            this.storage_tab.Controls.Add(this.Product_price_CB);
            this.storage_tab.Controls.Add(this.product_name_CB);
            this.storage_tab.Controls.Add(this.Search_product_lbl);
            this.storage_tab.Controls.Add(this.Storage_GV);
            this.storage_tab.Controls.Add(this.Update_pr_btn);
            this.storage_tab.Controls.Add(this.Delete_pr_btn);
            this.storage_tab.Controls.Add(this.Add_new_pr_btn);
            this.storage_tab.Location = new System.Drawing.Point(4, 25);
            this.storage_tab.Name = "storage_tab";
            this.storage_tab.Padding = new System.Windows.Forms.Padding(3);
            this.storage_tab.Size = new System.Drawing.Size(1065, 343);
            this.storage_tab.TabIndex = 0;
            this.storage_tab.Text = "מחסן";
            this.storage_tab.UseVisualStyleBackColor = true;
            // 
            // Workers_tab
            // 
            this.Workers_tab.Controls.Add(this.Search_worker_btn);
            this.Workers_tab.Controls.Add(this.Worker_role_lbl);
            this.Workers_tab.Controls.Add(this.Worker_status_lbl);
            this.Workers_tab.Controls.Add(this.Worker_salry_lbl);
            this.Workers_tab.Controls.Add(this.Worker_name_lbl);
            this.Workers_tab.Controls.Add(this.Worker_role_CB);
            this.Workers_tab.Controls.Add(this.Worker_status_CB);
            this.Workers_tab.Controls.Add(this.Worker_salary_CB);
            this.Workers_tab.Controls.Add(this.Worker_name_CB);
            this.Workers_tab.Controls.Add(this.Search_worker);
            this.Workers_tab.Controls.Add(this.Workers_GV);
            this.Workers_tab.Controls.Add(this.update_worker_btn);
            this.Workers_tab.Controls.Add(this.Delete_worker_btn);
            this.Workers_tab.Controls.Add(this.Add_new_worker_btn);
            this.Workers_tab.Location = new System.Drawing.Point(4, 25);
            this.Workers_tab.Name = "Workers_tab";
            this.Workers_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Workers_tab.Size = new System.Drawing.Size(1065, 343);
            this.Workers_tab.TabIndex = 1;
            this.Workers_tab.Text = "עובדים";
            this.Workers_tab.UseVisualStyleBackColor = true;
            // 
            // Reports_tab
            // 
            this.Reports_tab.Controls.Add(this.End_date_lbl);
            this.Reports_tab.Controls.Add(this.cancel_report_btn);
            this.Reports_tab.Controls.Add(this.start_report_btn);
            this.Reports_tab.Controls.Add(this.Start_date_lbl);
            this.Reports_tab.Controls.Add(this.end_date_DP);
            this.Reports_tab.Controls.Add(this.Start_date_DP);
            this.Reports_tab.Controls.Add(this.Expenses_rep_btn);
            this.Reports_tab.Controls.Add(this.Revenue_rep_btn);
            this.Reports_tab.Controls.Add(this.Z_report_btn);
            this.Reports_tab.Location = new System.Drawing.Point(4, 25);
            this.Reports_tab.Name = "Reports_tab";
            this.Reports_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Reports_tab.Size = new System.Drawing.Size(1065, 343);
            this.Reports_tab.TabIndex = 2;
            this.Reports_tab.Text = "דוחות";
            this.Reports_tab.UseVisualStyleBackColor = true;
            // 
            // Add_new_pr_btn
            // 
            this.Add_new_pr_btn.Location = new System.Drawing.Point(953, 269);
            this.Add_new_pr_btn.Name = "Add_new_pr_btn";
            this.Add_new_pr_btn.Size = new System.Drawing.Size(106, 53);
            this.Add_new_pr_btn.TabIndex = 0;
            this.Add_new_pr_btn.Text = "הוספת מוצר חדש";
            this.Add_new_pr_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_pr_btn
            // 
            this.Delete_pr_btn.Location = new System.Drawing.Point(750, 269);
            this.Delete_pr_btn.Name = "Delete_pr_btn";
            this.Delete_pr_btn.Size = new System.Drawing.Size(95, 53);
            this.Delete_pr_btn.TabIndex = 1;
            this.Delete_pr_btn.Text = "מחק מוצר";
            this.Delete_pr_btn.UseVisualStyleBackColor = true;
            // 
            // Update_pr_btn
            // 
            this.Update_pr_btn.Location = new System.Drawing.Point(851, 269);
            this.Update_pr_btn.Name = "Update_pr_btn";
            this.Update_pr_btn.Size = new System.Drawing.Size(96, 53);
            this.Update_pr_btn.TabIndex = 2;
            this.Update_pr_btn.Text = "עדכן מוצר";
            this.Update_pr_btn.UseVisualStyleBackColor = true;
            // 
            // Storage_GV
            // 
            this.Storage_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Storage_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.unit_price,
            this.units_in_stock,
            this.product_category,
            this.expired_date});
            this.Storage_GV.Location = new System.Drawing.Point(421, 94);
            this.Storage_GV.Name = "Storage_GV";
            this.Storage_GV.RowTemplate.Height = 24;
            this.Storage_GV.Size = new System.Drawing.Size(641, 150);
            this.Storage_GV.TabIndex = 3;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "מספר סידורי";
            this.product_id.Name = "product_id";
            // 
            // product_name
            // 
            this.product_name.HeaderText = "שם מוצר";
            this.product_name.Name = "product_name";
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "מחיר ליחידה";
            this.unit_price.Name = "unit_price";
            // 
            // units_in_stock
            // 
            this.units_in_stock.HeaderText = "יחידות במלאי";
            this.units_in_stock.Name = "units_in_stock";
            // 
            // product_category
            // 
            this.product_category.HeaderText = "קטיגוריה";
            this.product_category.Name = "product_category";
            // 
            // expired_date
            // 
            this.expired_date.HeaderText = "פג תוקף";
            this.expired_date.Name = "expired_date";
            // 
            // update_worker_btn
            // 
            this.update_worker_btn.Location = new System.Drawing.Point(851, 275);
            this.update_worker_btn.Name = "update_worker_btn";
            this.update_worker_btn.Size = new System.Drawing.Size(96, 53);
            this.update_worker_btn.TabIndex = 5;
            this.update_worker_btn.Text = "עדכן עובד";
            this.update_worker_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_worker_btn
            // 
            this.Delete_worker_btn.Location = new System.Drawing.Point(750, 275);
            this.Delete_worker_btn.Name = "Delete_worker_btn";
            this.Delete_worker_btn.Size = new System.Drawing.Size(95, 53);
            this.Delete_worker_btn.TabIndex = 4;
            this.Delete_worker_btn.Text = "מחק עובד";
            this.Delete_worker_btn.UseVisualStyleBackColor = true;
            // 
            // Add_new_worker_btn
            // 
            this.Add_new_worker_btn.Location = new System.Drawing.Point(953, 275);
            this.Add_new_worker_btn.Name = "Add_new_worker_btn";
            this.Add_new_worker_btn.Size = new System.Drawing.Size(106, 53);
            this.Add_new_worker_btn.TabIndex = 3;
            this.Add_new_worker_btn.Text = "הוספת עובד חדש";
            this.Add_new_worker_btn.UseVisualStyleBackColor = true;
            // 
            // Workers_GV
            // 
            this.Workers_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Workers_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Worker_id,
            this.Worker_name,
            this.Salary,
            this.Birthdate,
            this.Status,
            this.Role,
            this.Password});
            this.Workers_GV.Location = new System.Drawing.Point(320, 110);
            this.Workers_GV.Name = "Workers_GV";
            this.Workers_GV.RowTemplate.Height = 24;
            this.Workers_GV.Size = new System.Drawing.Size(745, 150);
            this.Workers_GV.TabIndex = 6;
            this.Workers_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Workers_GV_CellContentClick);
            // 
            // Worker_id
            // 
            this.Worker_id.HeaderText = "ת.ז";
            this.Worker_id.Name = "Worker_id";
            // 
            // Worker_name
            // 
            this.Worker_name.HeaderText = "שם עובד";
            this.Worker_name.Name = "Worker_name";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "תעריף לשעה";
            this.Salary.Name = "Salary";
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "יום הולדת";
            this.Birthdate.Name = "Birthdate";
            // 
            // Status
            // 
            this.Status.HeaderText = "סטטוס";
            this.Status.Name = "Status";
            // 
            // Role
            // 
            this.Role.HeaderText = "תפקיד";
            this.Role.Name = "Role";
            // 
            // Password
            // 
            this.Password.HeaderText = "סיסמה";
            this.Password.Name = "Password";
            // 
            // Z_report_btn
            // 
            this.Z_report_btn.Location = new System.Drawing.Point(926, 50);
            this.Z_report_btn.Name = "Z_report_btn";
            this.Z_report_btn.Size = new System.Drawing.Size(124, 43);
            this.Z_report_btn.TabIndex = 0;
            this.Z_report_btn.Text = "סגור יום";
            this.Z_report_btn.UseVisualStyleBackColor = true;
            // 
            // Revenue_rep_btn
            // 
            this.Revenue_rep_btn.Location = new System.Drawing.Point(926, 122);
            this.Revenue_rep_btn.Name = "Revenue_rep_btn";
            this.Revenue_rep_btn.Size = new System.Drawing.Size(124, 43);
            this.Revenue_rep_btn.TabIndex = 1;
            this.Revenue_rep_btn.Text = "דוח הכנסות בתקופה";
            this.Revenue_rep_btn.UseVisualStyleBackColor = true;
            // 
            // Expenses_rep_btn
            // 
            this.Expenses_rep_btn.Location = new System.Drawing.Point(926, 188);
            this.Expenses_rep_btn.Name = "Expenses_rep_btn";
            this.Expenses_rep_btn.Size = new System.Drawing.Size(124, 43);
            this.Expenses_rep_btn.TabIndex = 2;
            this.Expenses_rep_btn.Text = "דוח הוצאות בתקופה";
            this.Expenses_rep_btn.UseVisualStyleBackColor = true;
            // 
            // Man_Exit_btn
            // 
            this.Man_Exit_btn.Location = new System.Drawing.Point(39, 473);
            this.Man_Exit_btn.Name = "Man_Exit_btn";
            this.Man_Exit_btn.Size = new System.Drawing.Size(134, 51);
            this.Man_Exit_btn.TabIndex = 1;
            this.Man_Exit_btn.Text = "יציאה";
            this.Man_Exit_btn.UseVisualStyleBackColor = true;
            this.Man_Exit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Search_worker
            // 
            this.Search_worker.AutoSize = true;
            this.Search_worker.Location = new System.Drawing.Point(991, 3);
            this.Search_worker.Name = "Search_worker";
            this.Search_worker.Size = new System.Drawing.Size(68, 17);
            this.Search_worker.TabIndex = 7;
            this.Search_worker.Text = "חפש עובד:";
            // 
            // Worker_name_CB
            // 
            this.Worker_name_CB.FormattingEnabled = true;
            this.Worker_name_CB.Location = new System.Drawing.Point(862, 46);
            this.Worker_name_CB.Name = "Worker_name_CB";
            this.Worker_name_CB.Size = new System.Drawing.Size(121, 24);
            this.Worker_name_CB.TabIndex = 8;
            // 
            // Worker_salary_CB
            // 
            this.Worker_salary_CB.FormattingEnabled = true;
            this.Worker_salary_CB.Location = new System.Drawing.Point(634, 46);
            this.Worker_salary_CB.Name = "Worker_salary_CB";
            this.Worker_salary_CB.Size = new System.Drawing.Size(121, 24);
            this.Worker_salary_CB.TabIndex = 9;
            // 
            // Worker_status_CB
            // 
            this.Worker_status_CB.FormattingEnabled = true;
            this.Worker_status_CB.Location = new System.Drawing.Point(439, 46);
            this.Worker_status_CB.Name = "Worker_status_CB";
            this.Worker_status_CB.Size = new System.Drawing.Size(121, 24);
            this.Worker_status_CB.TabIndex = 10;
            // 
            // Worker_role_CB
            // 
            this.Worker_role_CB.FormattingEnabled = true;
            this.Worker_role_CB.Location = new System.Drawing.Point(231, 46);
            this.Worker_role_CB.Name = "Worker_role_CB";
            this.Worker_role_CB.Size = new System.Drawing.Size(121, 24);
            this.Worker_role_CB.TabIndex = 11;
            // 
            // Worker_name_lbl
            // 
            this.Worker_name_lbl.AutoSize = true;
            this.Worker_name_lbl.Location = new System.Drawing.Point(989, 53);
            this.Worker_name_lbl.Name = "Worker_name_lbl";
            this.Worker_name_lbl.Size = new System.Drawing.Size(60, 17);
            this.Worker_name_lbl.TabIndex = 12;
            this.Worker_name_lbl.Text = "שם עובד:";
            // 
            // Worker_salry_lbl
            // 
            this.Worker_salry_lbl.AutoSize = true;
            this.Worker_salry_lbl.Location = new System.Drawing.Point(765, 52);
            this.Worker_salry_lbl.Name = "Worker_salry_lbl";
            this.Worker_salry_lbl.Size = new System.Drawing.Size(83, 17);
            this.Worker_salry_lbl.TabIndex = 13;
            this.Worker_salry_lbl.Text = "תעריף לשעה:";
            // 
            // Worker_status_lbl
            // 
            this.Worker_status_lbl.AutoSize = true;
            this.Worker_status_lbl.Location = new System.Drawing.Point(566, 53);
            this.Worker_status_lbl.Name = "Worker_status_lbl";
            this.Worker_status_lbl.Size = new System.Drawing.Size(48, 17);
            this.Worker_status_lbl.TabIndex = 14;
            this.Worker_status_lbl.Text = "סטטוס:";
            // 
            // Worker_role_lbl
            // 
            this.Worker_role_lbl.AutoSize = true;
            this.Worker_role_lbl.Location = new System.Drawing.Point(359, 52);
            this.Worker_role_lbl.Name = "Worker_role_lbl";
            this.Worker_role_lbl.Size = new System.Drawing.Size(47, 17);
            this.Worker_role_lbl.TabIndex = 15;
            this.Worker_role_lbl.Text = "תפקיד:";
            // 
            // Search_worker_btn
            // 
            this.Search_worker_btn.Location = new System.Drawing.Point(116, 46);
            this.Search_worker_btn.Name = "Search_worker_btn";
            this.Search_worker_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_worker_btn.TabIndex = 16;
            this.Search_worker_btn.Text = "חפש";
            this.Search_worker_btn.UseVisualStyleBackColor = true;
            // 
            // Start_date_DP
            // 
            this.Start_date_DP.Enabled = false;
            this.Start_date_DP.Location = new System.Drawing.Point(706, 157);
            this.Start_date_DP.Name = "Start_date_DP";
            this.Start_date_DP.Size = new System.Drawing.Size(103, 22);
            this.Start_date_DP.TabIndex = 3;
            // 
            // end_date_DP
            // 
            this.end_date_DP.Location = new System.Drawing.Point(706, 186);
            this.end_date_DP.Name = "end_date_DP";
            this.end_date_DP.Size = new System.Drawing.Size(106, 22);
            this.end_date_DP.TabIndex = 4;
            // 
            // Start_date_lbl
            // 
            this.Start_date_lbl.AutoSize = true;
            this.Start_date_lbl.Enabled = false;
            this.Start_date_lbl.Location = new System.Drawing.Point(818, 157);
            this.Start_date_lbl.Name = "Start_date_lbl";
            this.Start_date_lbl.Size = new System.Drawing.Size(54, 17);
            this.Start_date_lbl.TabIndex = 5;
            this.Start_date_lbl.Text = "מתאריך:";
            // 
            // start_report_btn
            // 
            this.start_report_btn.Enabled = false;
            this.start_report_btn.Location = new System.Drawing.Point(592, 173);
            this.start_report_btn.Name = "start_report_btn";
            this.start_report_btn.Size = new System.Drawing.Size(75, 35);
            this.start_report_btn.TabIndex = 6;
            this.start_report_btn.Text = "הפקת דוח";
            this.start_report_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_report_btn
            // 
            this.cancel_report_btn.Enabled = false;
            this.cancel_report_btn.Location = new System.Drawing.Point(511, 173);
            this.cancel_report_btn.Name = "cancel_report_btn";
            this.cancel_report_btn.Size = new System.Drawing.Size(75, 35);
            this.cancel_report_btn.TabIndex = 7;
            this.cancel_report_btn.Text = "ביטול";
            this.cancel_report_btn.UseVisualStyleBackColor = true;
            // 
            // End_date_lbl
            // 
            this.End_date_lbl.AutoSize = true;
            this.End_date_lbl.Enabled = false;
            this.End_date_lbl.Location = new System.Drawing.Point(818, 191);
            this.End_date_lbl.Name = "End_date_lbl";
            this.End_date_lbl.Size = new System.Drawing.Size(65, 17);
            this.End_date_lbl.TabIndex = 8;
            this.End_date_lbl.Text = "עד תאריך:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(37, 104);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 26;
            this.search_btn.Text = "חפש";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // product_cat_lbl
            // 
            this.product_cat_lbl.AutoSize = true;
            this.product_cat_lbl.Location = new System.Drawing.Point(359, 58);
            this.product_cat_lbl.Name = "product_cat_lbl";
            this.product_cat_lbl.Size = new System.Drawing.Size(57, 17);
            this.product_cat_lbl.TabIndex = 25;
            this.product_cat_lbl.Text = "קטיגורה:";
            // 
            // product_units__lbl
            // 
            this.product_units__lbl.AutoSize = true;
            this.product_units__lbl.Location = new System.Drawing.Point(566, 59);
            this.product_units__lbl.Name = "product_units__lbl";
            this.product_units__lbl.Size = new System.Drawing.Size(86, 17);
            this.product_units__lbl.TabIndex = 24;
            this.product_units__lbl.Text = "יחידות במלאי:";
            // 
            // Product_price_lbl
            // 
            this.Product_price_lbl.AutoSize = true;
            this.Product_price_lbl.Location = new System.Drawing.Point(800, 59);
            this.Product_price_lbl.Name = "Product_price_lbl";
            this.Product_price_lbl.Size = new System.Drawing.Size(39, 17);
            this.Product_price_lbl.TabIndex = 23;
            this.Product_price_lbl.Text = "מחיר:";
            this.Product_price_lbl.Click += new System.EventHandler(this.Product_price_lbl_Click);
            // 
            // Product_name_lbl
            // 
            this.Product_name_lbl.AutoSize = true;
            this.Product_name_lbl.Location = new System.Drawing.Point(989, 59);
            this.Product_name_lbl.Name = "Product_name_lbl";
            this.Product_name_lbl.Size = new System.Drawing.Size(60, 17);
            this.Product_name_lbl.TabIndex = 22;
            this.Product_name_lbl.Text = "שם מוצר:";
            // 
            // product_cat_CB
            // 
            this.product_cat_CB.FormattingEnabled = true;
            this.product_cat_CB.Location = new System.Drawing.Point(231, 52);
            this.product_cat_CB.Name = "product_cat_CB";
            this.product_cat_CB.Size = new System.Drawing.Size(121, 24);
            this.product_cat_CB.TabIndex = 21;
            // 
            // product_units_CB
            // 
            this.product_units_CB.FormattingEnabled = true;
            this.product_units_CB.Location = new System.Drawing.Point(439, 52);
            this.product_units_CB.Name = "product_units_CB";
            this.product_units_CB.Size = new System.Drawing.Size(121, 24);
            this.product_units_CB.TabIndex = 20;
            // 
            // Product_price_CB
            // 
            this.Product_price_CB.FormattingEnabled = true;
            this.Product_price_CB.Location = new System.Drawing.Point(673, 52);
            this.Product_price_CB.Name = "Product_price_CB";
            this.Product_price_CB.Size = new System.Drawing.Size(121, 24);
            this.Product_price_CB.TabIndex = 19;
            // 
            // product_name_CB
            // 
            this.product_name_CB.FormattingEnabled = true;
            this.product_name_CB.Location = new System.Drawing.Point(862, 52);
            this.product_name_CB.Name = "product_name_CB";
            this.product_name_CB.Size = new System.Drawing.Size(121, 24);
            this.product_name_CB.TabIndex = 18;
            // 
            // Search_product_lbl
            // 
            this.Search_product_lbl.AutoSize = true;
            this.Search_product_lbl.Location = new System.Drawing.Point(991, 9);
            this.Search_product_lbl.Name = "Search_product_lbl";
            this.Search_product_lbl.Size = new System.Drawing.Size(68, 17);
            this.Search_product_lbl.TabIndex = 17;
            this.Search_product_lbl.Text = "חפש עובד:";
            // 
            // Expired_date_lbl
            // 
            this.Expired_date_lbl.AutoSize = true;
            this.Expired_date_lbl.Location = new System.Drawing.Point(162, 55);
            this.Expired_date_lbl.Name = "Expired_date_lbl";
            this.Expired_date_lbl.Size = new System.Drawing.Size(40, 17);
            this.Expired_date_lbl.TabIndex = 27;
            this.Expired_date_lbl.Text = "תוקף:";
            // 
            // Expired_date_DP
            // 
            this.Expired_date_DP.Location = new System.Drawing.Point(37, 55);
            this.Expired_date_DP.Name = "Expired_date_DP";
            this.Expired_date_DP.Size = new System.Drawing.Size(106, 22);
            this.Expired_date_DP.TabIndex = 28;
            // 
            // Manager_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 546);
            this.Controls.Add(this.Man_Exit_btn);
            this.Controls.Add(this.Manegar_tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_GUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_GUI";
            this.Manegar_tabs.ResumeLayout(false);
            this.storage_tab.ResumeLayout(false);
            this.storage_tab.PerformLayout();
            this.Workers_tab.ResumeLayout(false);
            this.Workers_tab.PerformLayout();
            this.Reports_tab.ResumeLayout(false);
            this.Reports_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Storage_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Workers_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Manegar_tabs;
        private System.Windows.Forms.TabPage storage_tab;
        private System.Windows.Forms.TabPage Workers_tab;
        private System.Windows.Forms.TabPage Reports_tab;
        private System.Windows.Forms.DataGridView Storage_GV;
        private System.Windows.Forms.Button Update_pr_btn;
        private System.Windows.Forms.Button Delete_pr_btn;
        private System.Windows.Forms.Button Add_new_pr_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn units_in_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired_date;
        private System.Windows.Forms.DataGridView Workers_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button update_worker_btn;
        private System.Windows.Forms.Button Delete_worker_btn;
        private System.Windows.Forms.Button Add_new_worker_btn;
        private System.Windows.Forms.Button Revenue_rep_btn;
        private System.Windows.Forms.Button Z_report_btn;
        private System.Windows.Forms.Button Expenses_rep_btn;
        private System.Windows.Forms.Button Man_Exit_btn;
        private System.Windows.Forms.Label Search_worker;
        private System.Windows.Forms.Button Search_worker_btn;
        private System.Windows.Forms.Label Worker_role_lbl;
        private System.Windows.Forms.Label Worker_status_lbl;
        private System.Windows.Forms.Label Worker_salry_lbl;
        private System.Windows.Forms.Label Worker_name_lbl;
        private System.Windows.Forms.ComboBox Worker_role_CB;
        private System.Windows.Forms.ComboBox Worker_status_CB;
        private System.Windows.Forms.ComboBox Worker_salary_CB;
        private System.Windows.Forms.ComboBox Worker_name_CB;
        private System.Windows.Forms.Label End_date_lbl;
        private System.Windows.Forms.Button cancel_report_btn;
        private System.Windows.Forms.Button start_report_btn;
        private System.Windows.Forms.Label Start_date_lbl;
        private System.Windows.Forms.DateTimePicker end_date_DP;
        private System.Windows.Forms.DateTimePicker Start_date_DP;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label product_cat_lbl;
        private System.Windows.Forms.Label product_units__lbl;
        private System.Windows.Forms.Label Product_price_lbl;
        private System.Windows.Forms.Label Product_name_lbl;
        private System.Windows.Forms.ComboBox product_cat_CB;
        private System.Windows.Forms.ComboBox product_units_CB;
        private System.Windows.Forms.ComboBox Product_price_CB;
        private System.Windows.Forms.ComboBox product_name_CB;
        private System.Windows.Forms.Label Search_product_lbl;
        private System.Windows.Forms.DateTimePicker Expired_date_DP;
        private System.Windows.Forms.Label Expired_date_lbl;
    }
}