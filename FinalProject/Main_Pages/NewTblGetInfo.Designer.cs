namespace FinalProject.Main_Pages
{
    partial class NewTblGetInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerNameCB = new System.Windows.Forms.ComboBox();
            this.TblNum = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DinnersNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":שם עובד ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":מספר שולחן";
            // 
            // WorkerNameCB
            // 
            this.WorkerNameCB.FormattingEnabled = true;
            this.WorkerNameCB.Location = new System.Drawing.Point(548, 78);
            this.WorkerNameCB.Name = "WorkerNameCB";
            this.WorkerNameCB.Size = new System.Drawing.Size(121, 21);
            this.WorkerNameCB.TabIndex = 2;
            // 
            // TblNum
            // 
            this.TblNum.Location = new System.Drawing.Point(633, 113);
            this.TblNum.Name = "TblNum";
            this.TblNum.Size = new System.Drawing.Size(36, 20);
            this.TblNum.TabIndex = 3;
            this.TblNum.TextChanged += new System.EventHandler(this.TblNum_TextChanged);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(420, 201);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "אישור";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(286, 201);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "ביוטל";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ": מספר סועדים";
            // 
            // DinnersNum
            // 
            this.DinnersNum.Location = new System.Drawing.Point(633, 151);
            this.DinnersNum.Name = "DinnersNum";
            this.DinnersNum.Size = new System.Drawing.Size(36, 20);
            this.DinnersNum.TabIndex = 7;
            this.DinnersNum.TextChanged += new System.EventHandler(this.DinnersNum_TextChanged);
            // 
            // NewTblGetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 247);
            this.Controls.Add(this.DinnersNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.TblNum);
            this.Controls.Add(this.WorkerNameCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTblGetInfo";
            this.Text = "NewTblGetInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WorkerNameCB;
        private System.Windows.Forms.TextBox TblNum;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DinnersNum;
    }
}