﻿namespace HomeWorkAll
{
    partial class HomeWork_BullsCows
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
            this.labTitle = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(83, 68);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(643, 38);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Please Select A Number Between 1 To 100!";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(112, 195);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(235, 62);
            this.btnGuess.TabIndex = 9;
            this.btnGuess.Text = "Guess!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnswer.Location = new System.Drawing.Point(419, 195);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(345, 62);
            this.btnAnswer.TabIndex = 10;
            this.btnAnswer.Text = "Show Answer!";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // HomeWork_BullsCows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 389);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeWork_BullsCows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomeWork_BullsCows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       


        #endregion

        internal System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnAnswer;
    }
}