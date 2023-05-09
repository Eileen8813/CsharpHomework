using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkAll
{
    public partial class HWAlarm : Form
    {
        public HWAlarm()
        {
            InitializeComponent();
            timernow.Start();
        }
        bool timer = false;
        bool checktime=false;
        private void timernow_Tick(object sender, EventArgs e)
        {
            labShowTime.Text = DateTime.Now.ToString("HH:mm:ss");
           
           
        }

        private void cbSet_CheckedChanged(object sender, EventArgs e)
        {
            string time= txtTime.Text;
            bool check = int.TryParse(time.Replace("時", "").Replace("分", "").Replace("秒", "").Replace(" ", ""), out int result );
                if (check)
            {
                
                string[] timesplit = time.Split('時', '分', '秒');

                int hour = int.Parse(timesplit[0]);
                int minute = int.Parse(timesplit[1]);
                int second = int.Parse(timesplit[2]);
                MessageBox.Show(hour+ minute+ second+"請輸入時間。");//
                if (hour==DateTime.Now.Hour)
                {
                    if(minute == DateTime.Now.Minute) {
                        if (second == DateTime.Now.Second)
                        {
                            checktime = true;
                            if (checktime) { timerEnd.Start(); }
                            MessageBox.Show("請輸入時間。");//
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("請輸入時間。");
            }
        }

        private void timerEnd_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("1。");
            this.BackColor = timer ? Color.IndianRed : Color.Black;
            timer = !timer;
            //if (!checktime)
            //{
            //    timerEnd.Stop();
            //}

        }
    }
}
