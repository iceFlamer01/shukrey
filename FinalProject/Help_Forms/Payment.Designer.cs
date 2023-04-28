namespace FinalProject
{
    partial class Payment
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
            this.PayBtn = new System.Windows.Forms.Button();
            this.SeperateBTN = new System.Windows.Forms.Button();
            this.RefundBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(356, 43);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(92, 38);
            this.PayBtn.TabIndex = 0;
            this.PayBtn.Text = "תשלום";
            this.PayBtn.UseVisualStyleBackColor = true;
            // 
            // SeperateBTN
            // 
            this.SeperateBTN.Location = new System.Drawing.Point(356, 128);
            this.SeperateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SeperateBTN.Name = "SeperateBTN";
            this.SeperateBTN.Size = new System.Drawing.Size(92, 47);
            this.SeperateBTN.TabIndex = 1;
            this.SeperateBTN.Text = "פצל תשלופ";
            this.SeperateBTN.UseVisualStyleBackColor = true;
            this.SeperateBTN.Click += new System.EventHandler(this.SeperateBTN_Click);
            // 
            // RefundBtn
            // 
            this.RefundBtn.Location = new System.Drawing.Point(356, 225);
            this.RefundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefundBtn.Name = "RefundBtn";
            this.RefundBtn.Size = new System.Drawing.Size(92, 43);
            this.RefundBtn.TabIndex = 2;
            this.RefundBtn.Text = "זיכוי";
            this.RefundBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(9, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(316, 242);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Method";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(356, 296);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(92, 43);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "ביטול";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 361);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RefundBtn);
            this.Controls.Add(this.SeperateBTN);
            this.Controls.Add(this.PayBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button SeperateBTN;
        private System.Windows.Forms.Button RefundBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button CancelBtn;
    }
}