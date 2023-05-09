namespace HomeWorkAll
{
    partial class HomeWork08
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
            this.labNum01 = new System.Windows.Forms.Label();
            this.labNum02 = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum01 = new System.Windows.Forms.TextBox();
            this.TxtNum02 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplied = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNum01
            // 
            this.labNum01.AutoSize = true;
            this.labNum01.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum01.Location = new System.Drawing.Point(61, 58);
            this.labNum01.Name = "labNum01";
            this.labNum01.Size = new System.Drawing.Size(106, 31);
            this.labNum01.TabIndex = 0;
            this.labNum01.Text = "Num01:";
            // 
            // labNum02
            // 
            this.labNum02.AutoSize = true;
            this.labNum02.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum02.Location = new System.Drawing.Point(61, 117);
            this.labNum02.Name = "labNum02";
            this.labNum02.Size = new System.Drawing.Size(106, 31);
            this.labNum02.TabIndex = 1;
            this.labNum02.Text = "Num02:";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(61, 217);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(99, 31);
            this.labAnswer.TabIndex = 2;
            this.labAnswer.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "====================";
            // 
            // txtNum01
            // 
            this.txtNum01.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum01.Location = new System.Drawing.Point(184, 55);
            this.txtNum01.Name = "txtNum01";
            this.txtNum01.Size = new System.Drawing.Size(190, 39);
            this.txtNum01.TabIndex = 4;
            // 
            // TxtNum02
            // 
            this.TxtNum02.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtNum02.Location = new System.Drawing.Point(184, 114);
            this.TxtNum02.Name = "TxtNum02";
            this.TxtNum02.Size = new System.Drawing.Size(190, 39);
            this.TxtNum02.TabIndex = 5;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnswer.Location = new System.Drawing.Point(184, 217);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(190, 46);
            this.txtAnswer.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(405, 31);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 58);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(405, 98);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 58);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiplied
            // 
            this.btnMultiplied.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiplied.Location = new System.Drawing.Point(405, 162);
            this.btnMultiplied.Name = "btnMultiplied";
            this.btnMultiplied.Size = new System.Drawing.Size(76, 58);
            this.btnMultiplied.TabIndex = 9;
            this.btnMultiplied.Text = "x";
            this.btnMultiplied.UseVisualStyleBackColor = true;
            this.btnMultiplied.Click += new System.EventHandler(this.btnMultiplied_Click);
            // 
            // btnDivided
            // 
            this.btnDivided.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivided.Location = new System.Drawing.Point(405, 231);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(76, 58);
            this.btnDivided.TabIndex = 10;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            // 
            // HomeWork08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 332);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnMultiplied);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.TxtNum02);
            this.Controls.Add(this.txtNum01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labNum02);
            this.Controls.Add(this.labNum01);
            this.Name = "HomeWork08";
            this.Text = "HomeWork08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum01;
        private System.Windows.Forms.Label labNum02;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum01;
        private System.Windows.Forms.TextBox TxtNum02;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplied;
        private System.Windows.Forms.Button btnDivided;
    }
}