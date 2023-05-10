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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWorkMajor));
            this.labTitle = new System.Windows.Forms.Label();
            this.btnHomework01 = new System.Windows.Forms.Button();
            this.bntHomework02 = new System.Windows.Forms.Button();
            this.splitleftright = new System.Windows.Forms.SplitContainer();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.bntHomework10 = new System.Windows.Forms.Button();
            this.bntHomework09 = new System.Windows.Forms.Button();
            this.bntHomework08 = new System.Windows.Forms.Button();
            this.bntBullsCowws = new System.Windows.Forms.Button();
            this.bntHomework06 = new System.Windows.Forms.Button();
            this.bntHomework05 = new System.Windows.Forms.Button();
            this.bntHomework04 = new System.Windows.Forms.Button();
            this.bntHomework03 = new System.Windows.Forms.Button();
            this.splitTopBottom = new System.Windows.Forms.SplitContainer();
            this.labLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitleftright)).BeginInit();
            this.splitleftright.Panel1.SuspendLayout();
            this.splitleftright.Panel2.SuspendLayout();
            this.splitleftright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTopBottom)).BeginInit();
            this.splitTopBottom.Panel2.SuspendLayout();
            this.splitTopBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(26, 26);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(146, 38);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "C#作業集";
            // 
            // btnHomework01
            // 
            this.btnHomework01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.btnHomework01.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHomework01.Location = new System.Drawing.Point(10, 77);
            this.btnHomework01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHomework01.Name = "btnHomework01";
            this.btnHomework01.Size = new System.Drawing.Size(102, 44);
            this.btnHomework01.TabIndex = 1;
            this.btnHomework01.Text = "作業1";
            this.btnHomework01.UseVisualStyleBackColor = false;
            this.btnHomework01.Click += new System.EventHandler(this.bntHomework01_Click);
            // 
            // bntHomework02
            // 
            this.bntHomework02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework02.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework02.Location = new System.Drawing.Point(10, 175);
            this.bntHomework02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework02.Name = "bntHomework02";
            this.bntHomework02.Size = new System.Drawing.Size(102, 46);
            this.bntHomework02.TabIndex = 2;
            this.bntHomework02.Text = "作業2";
            this.bntHomework02.UseVisualStyleBackColor = false;
            this.bntHomework02.Click += new System.EventHandler(this.bntHomework02_Click);
            // 
            // splitleftright
            // 
            this.splitleftright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitleftright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitleftright.Location = new System.Drawing.Point(0, 0);
            this.splitleftright.Name = "splitleftright";
            // 
            // splitleftright.Panel1
            // 
            this.splitleftright.Panel1.AutoScroll = true;
            this.splitleftright.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitleftright.Panel1.BackgroundImage")));
            this.splitleftright.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitleftright.Panel1.Controls.Add(this.btnAlarm);
            this.splitleftright.Panel1.Controls.Add(this.btnScreen);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework10);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework09);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework08);
            this.splitleftright.Panel1.Controls.Add(this.bntBullsCowws);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework06);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework05);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework04);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework03);
            this.splitleftright.Panel1.Controls.Add(this.btnHomework01);
            this.splitleftright.Panel1.Controls.Add(this.labTitle);
            this.splitleftright.Panel1.Controls.Add(this.bntHomework02);
            this.splitleftright.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // splitleftright.Panel2
            // 
            this.splitleftright.Panel2.Controls.Add(this.splitTopBottom);
            this.splitleftright.Size = new System.Drawing.Size(1060, 610);
            this.splitleftright.SplitterDistance = 327;
            this.splitleftright.TabIndex = 6;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.btnAlarm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAlarm.Location = new System.Drawing.Point(118, 530);
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(95, 63);
            this.btnAlarm.TabIndex = 12;
            this.btnAlarm.Text = "鬧鐘";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnScreen
            // 
            this.btnScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.btnScreen.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnScreen.Location = new System.Drawing.Point(235, 458);
            this.btnScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(86, 63);
            this.btnScreen.TabIndex = 11;
            this.btnScreen.Text = "Screen";
            this.btnScreen.UseVisualStyleBackColor = false;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // bntHomework10
            // 
            this.bntHomework10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntHomework10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework10.Location = new System.Drawing.Point(3, 525);
            this.bntHomework10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework10.Name = "bntHomework10";
            this.bntHomework10.Size = new System.Drawing.Size(112, 46);
            this.bntHomework10.TabIndex = 10;
            this.bntHomework10.Text = "作業10";
            this.bntHomework10.UseVisualStyleBackColor = false;
            this.bntHomework10.Click += new System.EventHandler(this.bntHomework10_Click);
            // 
            // bntHomework09
            // 
            this.bntHomework09.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework09.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework09.Location = new System.Drawing.Point(10, 475);
            this.bntHomework09.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework09.Name = "bntHomework09";
            this.bntHomework09.Size = new System.Drawing.Size(102, 46);
            this.bntHomework09.TabIndex = 9;
            this.bntHomework09.Text = "作業9";
            this.bntHomework09.UseVisualStyleBackColor = false;
            this.bntHomework09.Click += new System.EventHandler(this.bntHomework09_Click);
            // 
            // bntHomework08
            // 
            this.bntHomework08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework08.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework08.Location = new System.Drawing.Point(10, 425);
            this.bntHomework08.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework08.Name = "bntHomework08";
            this.bntHomework08.Size = new System.Drawing.Size(102, 46);
            this.bntHomework08.TabIndex = 8;
            this.bntHomework08.Text = "作業8";
            this.bntHomework08.UseVisualStyleBackColor = false;
            this.bntHomework08.Click += new System.EventHandler(this.bntHomework08_Click);
            // 
            // bntBullsCowws
            // 
            this.bntBullsCowws.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntBullsCowws.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntBullsCowws.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntBullsCowws.Location = new System.Drawing.Point(219, 538);
            this.bntBullsCowws.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBullsCowws.Name = "bntBullsCowws";
            this.bntBullsCowws.Size = new System.Drawing.Size(102, 46);
            this.bntBullsCowws.TabIndex = 7;
            this.bntBullsCowws.Text = "猜數字";
            this.bntBullsCowws.UseVisualStyleBackColor = false;
            this.bntBullsCowws.Click += new System.EventHandler(this.bntBullsCowws_Click);
            // 
            // bntHomework06
            // 
            this.bntHomework06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework06.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework06.Location = new System.Drawing.Point(10, 375);
            this.bntHomework06.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework06.Name = "bntHomework06";
            this.bntHomework06.Size = new System.Drawing.Size(102, 46);
            this.bntHomework06.TabIndex = 6;
            this.bntHomework06.Text = "作業6";
            this.bntHomework06.UseVisualStyleBackColor = false;
            this.bntHomework06.Click += new System.EventHandler(this.bntHomework06_Click);
            // 
            // bntHomework05
            // 
            this.bntHomework05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework05.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework05.Location = new System.Drawing.Point(10, 325);
            this.bntHomework05.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework05.Name = "bntHomework05";
            this.bntHomework05.Size = new System.Drawing.Size(102, 46);
            this.bntHomework05.TabIndex = 5;
            this.bntHomework05.Text = "作業5";
            this.bntHomework05.UseVisualStyleBackColor = false;
            this.bntHomework05.Click += new System.EventHandler(this.bntHomework05_Click);
            // 
            // bntHomework04
            // 
            this.bntHomework04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework04.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework04.Location = new System.Drawing.Point(10, 275);
            this.bntHomework04.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework04.Name = "bntHomework04";
            this.bntHomework04.Size = new System.Drawing.Size(102, 46);
            this.bntHomework04.TabIndex = 4;
            this.bntHomework04.Text = "作業4";
            this.bntHomework04.UseVisualStyleBackColor = false;
            this.bntHomework04.Click += new System.EventHandler(this.bntHomework04_Click);
            // 
            // bntHomework03
            // 
            this.bntHomework03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.bntHomework03.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntHomework03.Location = new System.Drawing.Point(10, 225);
            this.bntHomework03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntHomework03.Name = "bntHomework03";
            this.bntHomework03.Size = new System.Drawing.Size(102, 46);
            this.bntHomework03.TabIndex = 3;
            this.bntHomework03.Text = "作業3";
            this.bntHomework03.UseVisualStyleBackColor = false;
            this.bntHomework03.Click += new System.EventHandler(this.bntHomework03_Click);
            // 
            // splitTopBottom
            // 
            this.splitTopBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTopBottom.Location = new System.Drawing.Point(0, 0);
            this.splitTopBottom.Name = "splitTopBottom";
            this.splitTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTopBottom.Panel1
            // 
            this.splitTopBottom.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitTopBottom.Panel1.BackgroundImage")));
            this.splitTopBottom.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitTopBottom.Panel2
            // 
            this.splitTopBottom.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitTopBottom.Panel2.BackgroundImage")));
            this.splitTopBottom.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitTopBottom.Panel2.Controls.Add(this.labLocation);
            this.splitTopBottom.Size = new System.Drawing.Size(729, 610);
            this.splitTopBottom.SplitterDistance = 121;
            this.splitTopBottom.TabIndex = 0;
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labLocation.Location = new System.Drawing.Point(0, 0);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(0, 15);
            this.labLocation.TabIndex = 0;
            // 
            // HomeWorkMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 610);
            this.Controls.Add(this.splitleftright);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeWorkMajor";
            this.Text = "Homework主畫面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitleftright.Panel1.ResumeLayout(false);
            this.splitleftright.Panel1.PerformLayout();
            this.splitleftright.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitleftright)).EndInit();
            this.splitleftright.ResumeLayout(false);
            this.splitTopBottom.Panel2.ResumeLayout(false);
            this.splitTopBottom.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTopBottom)).EndInit();
            this.splitTopBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnHomework01;
        private System.Windows.Forms.Button bntHomework02;
        private System.Windows.Forms.SplitContainer splitleftright;
        private System.Windows.Forms.SplitContainer splitTopBottom;
        private System.Windows.Forms.Button bntHomework10;
        private System.Windows.Forms.Button bntHomework09;
        private System.Windows.Forms.Button bntHomework08;
        private System.Windows.Forms.Button bntBullsCowws;
        private System.Windows.Forms.Button bntHomework06;
        private System.Windows.Forms.Button bntHomework05;
        private System.Windows.Forms.Button bntHomework04;
        private System.Windows.Forms.Button bntHomework03;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Label labLocation;
    }
}

