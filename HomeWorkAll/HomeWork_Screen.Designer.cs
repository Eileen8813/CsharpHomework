namespace HomeWorkAll
{
    partial class HomeWork_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWork_Screen));
            this.pbGengar = new System.Windows.Forms.PictureBox();
            this.timerStar = new System.Windows.Forms.Timer(this.components);
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGengar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGengar
            // 
            this.pbGengar.BackColor = System.Drawing.Color.Black;
            this.pbGengar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbGengar.ErrorImage")));
            this.pbGengar.Image = ((System.Drawing.Image)(resources.GetObject("pbGengar.Image")));
            this.pbGengar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbGengar.InitialImage")));
            this.pbGengar.Location = new System.Drawing.Point(12, 46);
            this.pbGengar.Name = "pbGengar";
            this.pbGengar.Size = new System.Drawing.Size(416, 279);
            this.pbGengar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGengar.TabIndex = 0;
            this.pbGengar.TabStop = false;
            // 
            // timerStar
            // 
            this.timerStar.Interval = 800;
            this.timerStar.Tick += new System.EventHandler(this.timerStar_Tick);
            // 
            // timerStop
            // 
            this.timerStop.Tick += new System.EventHandler(this.tinerStop_Tick);
            // 
            // HomeWork_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1069, 608);
            this.Controls.Add(this.pbGengar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeWork_Screen";
            this.Text = "HomeWork_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeWork_Screen_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeWork_Screen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbGengar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGengar;
        private System.Windows.Forms.Timer timerStar;
        private System.Windows.Forms.Timer timerStop;
    }
}