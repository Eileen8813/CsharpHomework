using System.Drawing;
using System.Windows.Forms;

namespace HomeWorkAll
{
    partial class HomeWork01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWork01));
            this.labName = new System.Windows.Forms.Label();
            this.labNameEN = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labStarsign = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNameEN = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStarsign = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Turquoise;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(239, 67);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(92, 42);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labNameEN
            // 
            this.labNameEN.AutoSize = true;
            this.labNameEN.BackColor = System.Drawing.Color.Turquoise;
            this.labNameEN.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameEN.Location = new System.Drawing.Point(83, 133);
            this.labNameEN.Name = "labNameEN";
            this.labNameEN.Size = new System.Drawing.Size(245, 42);
            this.labNameEN.TabIndex = 1;
            this.labNameEN.Text = "English Name:";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Turquoise;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(239, 211);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(92, 42);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "性別:";
            // 
            // labStarsign
            // 
            this.labStarsign.AutoSize = true;
            this.labStarsign.BackColor = System.Drawing.Color.Turquoise;
            this.labStarsign.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStarsign.Location = new System.Drawing.Point(239, 280);
            this.labStarsign.Name = "labStarsign";
            this.labStarsign.Size = new System.Drawing.Size(92, 42);
            this.labStarsign.TabIndex = 3;
            this.labStarsign.Text = "星座:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(351, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 51);
            this.txtName.TabIndex = 4;
            // 
            // txtNameEN
            // 
            this.txtNameEN.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtNameEN.Location = new System.Drawing.Point(351, 133);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(264, 51);
            this.txtNameEN.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtGender.Location = new System.Drawing.Point(351, 203);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(264, 51);
            this.txtGender.TabIndex = 6;
            // 
            // txtStarsign
            // 
            this.txtStarsign.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtStarsign.Location = new System.Drawing.Point(351, 272);
            this.txtStarsign.Name = "txtStarsign";
            this.txtStarsign.Size = new System.Drawing.Size(264, 51);
            this.txtStarsign.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.Turquoise;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(113, 353);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(234, 63);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.Color.Turquoise;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(438, 353);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(234, 63);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // HomeWork01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtStarsign);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labStarsign);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labNameEN);
            this.Controls.Add(this.labName);
            this.Name = "HomeWork01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "作業一: Hello!C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labNameEN;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labStarsign;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNameEN;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStarsign;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}