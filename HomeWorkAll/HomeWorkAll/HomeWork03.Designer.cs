namespace HomeWorkAll
{
    partial class HomeWork03
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnGreenTea = new System.Windows.Forms.Button();
            this.btnJuice = new System.Windows.Forms.Button();
            this.btnOolongTea = new System.Windows.Forms.Button();
            this.btnBlackTea = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.labdiscont = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.labDisplay = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            this.gbList.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.gbPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnGreenTea);
            this.gbMenu.Controls.Add(this.btnJuice);
            this.gbMenu.Controls.Add(this.btnOolongTea);
            this.gbMenu.Controls.Add(this.btnBlackTea);
            this.gbMenu.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbMenu.Location = new System.Drawing.Point(27, 43);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(276, 336);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "菜單Menu";
            // 
            // btnGreenTea
            // 
            this.btnGreenTea.Location = new System.Drawing.Point(137, 184);
            this.btnGreenTea.Name = "btnGreenTea";
            this.btnGreenTea.Size = new System.Drawing.Size(119, 132);
            this.btnGreenTea.TabIndex = 3;
            this.btnGreenTea.Text = "GreenTea";
            this.btnGreenTea.UseVisualStyleBackColor = true;
            this.btnGreenTea.Click += new System.EventHandler(this.btnGreenTea_Click);
            // 
            // btnJuice
            // 
            this.btnJuice.Location = new System.Drawing.Point(137, 37);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(119, 132);
            this.btnJuice.TabIndex = 2;
            this.btnJuice.Text = "Juice";
            this.btnJuice.UseVisualStyleBackColor = true;
            this.btnJuice.Click += new System.EventHandler(this.btnJuice_Click);
            // 
            // btnOolongTea
            // 
            this.btnOolongTea.Location = new System.Drawing.Point(12, 184);
            this.btnOolongTea.Name = "btnOolongTea";
            this.btnOolongTea.Size = new System.Drawing.Size(119, 132);
            this.btnOolongTea.TabIndex = 1;
            this.btnOolongTea.Text = "Oolong  Tea";
            this.btnOolongTea.UseVisualStyleBackColor = true;
            this.btnOolongTea.Click += new System.EventHandler(this.btnOolongTea_Click);
            // 
            // btnBlackTea
            // 
            this.btnBlackTea.Location = new System.Drawing.Point(12, 37);
            this.btnBlackTea.Name = "btnBlackTea";
            this.btnBlackTea.Size = new System.Drawing.Size(119, 132);
            this.btnBlackTea.TabIndex = 0;
            this.btnBlackTea.Text = "BlackTea";
            this.btnBlackTea.UseVisualStyleBackColor = true;
            this.btnBlackTea.Click += new System.EventHandler(this.btnBlackTea_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.labDisplay);
            this.gbList.Controls.Add(this.btnClean);
            this.gbList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbList.Location = new System.Drawing.Point(496, 43);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(292, 336);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "購物清單Llist";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(142, 286);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(132, 44);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "清除清單";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.Controls.Add(this.labTotal);
            this.gbTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbTotalPrice.Location = new System.Drawing.Point(309, 43);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(173, 140);
            this.gbTotalPrice.TabIndex = 2;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "總金額 TotalPrice";
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labTotal.Location = new System.Drawing.Point(6, 46);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(155, 41);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "NT$0";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.labdiscont);
            this.gbPay.Controls.Add(this.btnCredit);
            this.gbPay.Controls.Add(this.btnCash);
            this.gbPay.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPay.Location = new System.Drawing.Point(313, 195);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(177, 184);
            this.gbPay.TabIndex = 3;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "付款方式";
            // 
            // labdiscont
            // 
            this.labdiscont.AutoSize = true;
            this.labdiscont.Location = new System.Drawing.Point(42, 161);
            this.labdiscont.Name = "labdiscont";
            this.labdiscont.Size = new System.Drawing.Size(127, 23);
            this.labdiscont.TabIndex = 2;
            this.labdiscont.Text = "信用卡享九折!";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(24, 101);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(132, 44);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(24, 38);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(132, 44);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labDisplay
            // 
            this.labDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labDisplay.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labDisplay.Location = new System.Drawing.Point(6, 30);
            this.labDisplay.Name = "labDisplay";
            this.labDisplay.Size = new System.Drawing.Size(280, 242);
            this.labDisplay.TabIndex = 4;
            this.labDisplay.Text = "尚未點餐。";
            this.labDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HomeWork03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPay);
            this.Controls.Add(this.gbTotalPrice);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbMenu);
            this.Name = "HomeWork03";
            this.Text = "Drink Bar!";
            this.gbMenu.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            this.gbTotalPrice.ResumeLayout(false);
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.GroupBox gbTotalPrice;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnBlackTea;
        private System.Windows.Forms.Button btnGreenTea;
        private System.Windows.Forms.Button btnJuice;
        private System.Windows.Forms.Button btnOolongTea;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label labdiscont;
        private System.Windows.Forms.Label labDisplay;
    }
}