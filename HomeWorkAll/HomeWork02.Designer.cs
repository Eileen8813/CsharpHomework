namespace HomeWorkAll
{
    partial class HomeWork02
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
            this.labAmount = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFirstAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirstAmount = new System.Windows.Forms.TextBox();
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAmount.Location = new System.Drawing.Point(105, 48);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(158, 42);
            this.labAmount.TabIndex = 0;
            this.labAmount.Text = "貸款金額:";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(105, 117);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(149, 42);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年):";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(105, 185);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(146, 42);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%):";
            // 
            // labFirstAmount
            // 
            this.labFirstAmount.AutoSize = true;
            this.labFirstAmount.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirstAmount.Location = new System.Drawing.Point(105, 260);
            this.labFirstAmount.Name = "labFirstAmount";
            this.labFirstAmount.Size = new System.Drawing.Size(125, 42);
            this.labFirstAmount.TabIndex = 3;
            this.labFirstAmount.Text = "頭期款:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(275, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(206, 43);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "100000";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(275, 117);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(206, 43);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "2";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(275, 185);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(206, 43);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "10";
            // 
            // txtFirstAmount
            // 
            this.txtFirstAmount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstAmount.Location = new System.Drawing.Point(275, 260);
            this.txtFirstAmount.Name = "txtFirstAmount";
            this.txtFirstAmount.Size = new System.Drawing.Size(206, 43);
            this.txtFirstAmount.TabIndex = 7;
            this.txtFirstAmount.Text = "0";
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthPay.Location = new System.Drawing.Point(537, 43);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(221, 54);
            this.btnMonthPay.TabIndex = 8;
            this.btnMonthPay.Text = "PMT(每月付)";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(537, 146);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(221, 54);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(537, 252);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(221, 54);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // HomeWork02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMonthPay);
            this.Controls.Add(this.txtFirstAmount);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labFirstAmount);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labAmount);
            this.Name = "HomeWork02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "借款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFirstAmount;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox txtFirstAmount;
        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}