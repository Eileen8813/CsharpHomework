namespace HomeWorkAll
{
    partial class HomeWorkMajor
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitle = new System.Windows.Forms.Label();
            this.btnHomework01 = new System.Windows.Forms.Button();
            this.bntHomework02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(63, 27);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(146, 38);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "C#作業集";
            // 
            // btnHomework01
            // 
            this.btnHomework01.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHomework01.Location = new System.Drawing.Point(70, 81);
            this.btnHomework01.Name = "btnHomework01";
            this.btnHomework01.Size = new System.Drawing.Size(123, 44);
            this.btnHomework01.TabIndex = 1;
            this.btnHomework01.Text = "作業1";
            this.btnHomework01.UseVisualStyleBackColor = true;
            this.btnHomework01.Click += new System.EventHandler(this.bntHomework01_Click);
            // 
            // bntHomework02
            // 
            this.bntHomework02.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework02.Location = new System.Drawing.Point(70, 144);
            this.bntHomework02.Name = "bntHomework02";
            this.bntHomework02.Size = new System.Drawing.Size(123, 44);
            this.bntHomework02.TabIndex = 2;
            this.bntHomework02.Text = "作業2";
            this.bntHomework02.UseVisualStyleBackColor = true;
            this.bntHomework02.Click += new System.EventHandler(this.bntHomework02_Click);
            // 
            // HomeWorkMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntHomework02);
            this.Controls.Add(this.btnHomework01);
            this.Controls.Add(this.labTitle);
            this.Name = "HomeWorkMajor";
            this.Text = "Homework主畫面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnHomework01;
        private System.Windows.Forms.Button bntHomework02;
    }
}

