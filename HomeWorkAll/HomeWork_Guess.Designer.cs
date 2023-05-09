namespace HomeWorkAll
{
    partial class HomeWork_Guess
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
            this.labTitle2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labTitle2
            // 
            this.labTitle2.AutoSize = true;
            this.labTitle2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle2.Location = new System.Drawing.Point(27, 28);
            this.labTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTitle2.Name = "labTitle2";
            this.labTitle2.Size = new System.Drawing.Size(300, 31);
            this.labTitle2.TabIndex = 2;
            this.labTitle2.Text = "Please Input A Number !";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(350, 28);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 35);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(350, 81);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtGuess.Location = new System.Drawing.Point(50, 73);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(199, 43);
            this.txtGuess.TabIndex = 5;
            // 
            // HomeWork_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 145);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labTitle2);
            this.Name = "HomeWork_Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGuess;
    }
}