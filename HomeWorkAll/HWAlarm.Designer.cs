namespace HomeWorkAll
{
    partial class HWAlarm
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
            this.gbSetTime = new System.Windows.Forms.GroupBox();
            this.cbSet = new System.Windows.Forms.CheckBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labAlarm = new System.Windows.Forms.Label();
            this.timernow = new System.Windows.Forms.Timer(this.components);
            this.labShowTime = new System.Windows.Forms.Label();
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            this.gbSetTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetTime
            // 
            this.gbSetTime.Controls.Add(this.cbSet);
            this.gbSetTime.Controls.Add(this.txtTime);
            this.gbSetTime.Controls.Add(this.labAlarm);
            this.gbSetTime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSetTime.Location = new System.Drawing.Point(80, 86);
            this.gbSetTime.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetTime.Name = "gbSetTime";
            this.gbSetTime.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetTime.Size = new System.Drawing.Size(465, 270);
            this.gbSetTime.TabIndex = 3;
            this.gbSetTime.TabStop = false;
            this.gbSetTime.Text = "設定鬧鐘時間";
            // 
            // cbSet
            // 
            this.cbSet.AutoSize = true;
            this.cbSet.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSet.Location = new System.Drawing.Point(125, 194);
            this.cbSet.Margin = new System.Windows.Forms.Padding(4);
            this.cbSet.Name = "cbSet";
            this.cbSet.Size = new System.Drawing.Size(176, 42);
            this.cbSet.TabIndex = 4;
            this.cbSet.Text = "Set Alarm";
            this.cbSet.UseVisualStyleBackColor = true;
            this.cbSet.CheckedChanged += new System.EventHandler(this.cbSet_CheckedChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(133, 119);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(168, 36);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "  時  分  秒";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labAlarm
            // 
            this.labAlarm.AutoSize = true;
            this.labAlarm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAlarm.Location = new System.Drawing.Point(127, 55);
            this.labAlarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAlarm.Name = "labAlarm";
            this.labAlarm.Size = new System.Drawing.Size(179, 38);
            this.labAlarm.TabIndex = 2;
            this.labAlarm.Text = "Alarm Time";
            // 
            // timernow
            // 
            this.timernow.Tick += new System.EventHandler(this.timernow_Tick);
            // 
            // labShowTime
            // 
            this.labShowTime.AutoSize = true;
            this.labShowTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowTime.Location = new System.Drawing.Point(247, 32);
            this.labShowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShowTime.Name = "labShowTime";
            this.labShowTime.Size = new System.Drawing.Size(77, 38);
            this.labShowTime.TabIndex = 2;
            this.labShowTime.Text = "時間";
            // 
            // timerEnd
            // 
            this.timerEnd.Interval = 500;
            this.timerEnd.Tick += new System.EventHandler(this.timerEnd_Tick);
            // 
            // HWAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.gbSetTime);
            this.Controls.Add(this.labShowTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HWAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alarm";
            this.gbSetTime.ResumeLayout(false);
            this.gbSetTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timernow;
        private System.Windows.Forms.Label labAlarm;
        private System.Windows.Forms.Label labShowTime;
        private System.Windows.Forms.CheckBox cbSet;
        private System.Windows.Forms.Timer timerEnd;
    }
}