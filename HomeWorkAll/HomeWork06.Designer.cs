namespace HomeWorkAll
{
    partial class HomeWork06
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
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnJoinScore = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labCh = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.splitC1 = new System.Windows.Forms.SplitContainer();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.rtbStatistic = new System.Windows.Forms.RichTextBox();
            this.txtlow = new System.Windows.Forms.TextBox();
            this.txthigh = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.labBetween = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitC1)).BeginInit();
            this.splitC1.Panel1.SuspendLayout();
            this.splitC1.Panel2.SuspendLayout();
            this.splitC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatic.Location = new System.Drawing.Point(618, 485);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(169, 42);
            this.btnStatic.TabIndex = 33;
            this.btnStatic.Text = "各科統計";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(40, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 48);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "清除所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(31, 479);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 48);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoin.Location = new System.Drawing.Point(40, 246);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(169, 42);
            this.btnJoin.TabIndex = 30;
            this.btnJoin.Text = "插入儲存資料";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnJoinScore
            // 
            this.btnJoinScore.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoinScore.Location = new System.Drawing.Point(40, 198);
            this.btnJoinScore.Name = "btnJoinScore";
            this.btnJoinScore.Size = new System.Drawing.Size(169, 42);
            this.btnJoinScore.TabIndex = 29;
            this.btnJoinScore.Text = "加入學生資料";
            this.btnJoinScore.UseVisualStyleBackColor = true;
            this.btnJoinScore.Click += new System.EventHandler(this.btnJoinScore_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(115, 135);
            this.txtMath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(126, 36);
            this.txtMath.TabIndex = 28;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEn.Location = new System.Drawing.Point(115, 91);
            this.txtEn.Margin = new System.Windows.Forms.Padding(2);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(126, 36);
            this.txtEn.TabIndex = 27;
            this.txtEn.Text = "0";
            this.txtEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCh.Location = new System.Drawing.Point(115, 49);
            this.txtCh.Margin = new System.Windows.Forms.Padding(2);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(126, 36);
            this.txtCh.TabIndex = 26;
            this.txtCh.Text = "0";
            this.txtCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(115, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 36);
            this.txtName.TabIndex = 25;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(25, 135);
            this.labMath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(76, 35);
            this.labMath.TabIndex = 24;
            this.labMath.Text = "數學:";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(25, 91);
            this.labEn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(76, 35);
            this.labEn.TabIndex = 23;
            this.labEn.Text = "英文:";
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCh.Location = new System.Drawing.Point(25, 49);
            this.labCh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(76, 35);
            this.labCh.TabIndex = 22;
            this.labCh.Text = "國文:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(25, 4);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(76, 35);
            this.labName.TabIndex = 21;
            this.labName.Text = "姓名:";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(40, 294);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 42);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "移除資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // splitC1
            // 
            this.splitC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitC1.Location = new System.Drawing.Point(256, 12);
            this.splitC1.Name = "splitC1";
            this.splitC1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitC1.Panel1
            // 
            this.splitC1.Panel1.AutoScroll = true;
            this.splitC1.Panel1.Controls.Add(this.txtShow);
            this.splitC1.Panel1.Controls.Add(this.txtTitle);
            // 
            // splitC1.Panel2
            // 
            this.splitC1.Panel2.Controls.Add(this.rtbStatistic);
            this.splitC1.Size = new System.Drawing.Size(531, 451);
            this.splitC1.SplitterDistance = 298;
            this.splitC1.TabIndex = 35;
            // 
            // txtShow
            // 
            this.txtShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtShow.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShow.Location = new System.Drawing.Point(0, 23);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(529, 271);
            this.txtShow.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(529, 23);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "\t姓名\t國文\t英文\t數學\t總分\t平均\t最低\t最高";
            // 
            // rtbStatistic
            // 
            this.rtbStatistic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbStatistic.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbStatistic.Location = new System.Drawing.Point(-1, -7);
            this.rtbStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.rtbStatistic.Name = "rtbStatistic";
            this.rtbStatistic.ReadOnly = true;
            this.rtbStatistic.ShowSelectionMargin = true;
            this.rtbStatistic.Size = new System.Drawing.Size(536, 156);
            this.rtbStatistic.TabIndex = 24;
            this.rtbStatistic.Text = "";
            // 
            // txtlow
            // 
            this.txtlow.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlow.Location = new System.Drawing.Point(31, 428);
            this.txtlow.Margin = new System.Windows.Forms.Padding(2);
            this.txtlow.Name = "txtlow";
            this.txtlow.Size = new System.Drawing.Size(69, 36);
            this.txtlow.TabIndex = 36;
            this.txtlow.Text = "0";
            this.txtlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txthigh
            // 
            this.txthigh.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txthigh.Location = new System.Drawing.Point(140, 428);
            this.txthigh.Margin = new System.Windows.Forms.Padding(2);
            this.txthigh.Name = "txthigh";
            this.txthigh.Size = new System.Drawing.Size(69, 36);
            this.txthigh.TabIndex = 37;
            this.txthigh.Text = "0";
            this.txthigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSearch.Location = new System.Drawing.Point(26, 400);
            this.labSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(185, 26);
            this.labSearch.TabIndex = 38;
            this.labSearch.Text = "搜尋國文成績範圍:";
            // 
            // labBetween
            // 
            this.labBetween.AutoSize = true;
            this.labBetween.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBetween.Location = new System.Drawing.Point(108, 432);
            this.labBetween.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBetween.Name = "labBetween";
            this.labBetween.Size = new System.Drawing.Size(28, 26);
            this.labBetween.TabIndex = 39;
            this.labBetween.Text = "~";
            // 
            // HomeWork06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 539);
            this.Controls.Add(this.labBetween);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txthigh);
            this.Controls.Add(this.txtlow);
            this.Controls.Add(this.splitC1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnJoinScore);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.labName);
            this.Name = "HomeWork06";
            this.Text = "Homework06";
            this.splitC1.Panel1.ResumeLayout(false);
            this.splitC1.Panel1.PerformLayout();
            this.splitC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC1)).EndInit();
            this.splitC1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnJoinScore;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.SplitContainer splitC1;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox rtbStatistic;
        private System.Windows.Forms.TextBox txtlow;
        private System.Windows.Forms.TextBox txthigh;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labBetween;
    }
}