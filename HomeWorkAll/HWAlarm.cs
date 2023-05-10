using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        bool alarmstart = false;
        bool checktime=false;
        
        private void timernow_Tick(object sender, EventArgs e)
        {

            labShowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (alarmstart)
            {
                Settime(out bool check, out string time);

                if (check)
                {
                    string[] timesplit = time.Split('時', '分', '秒');

                    int hour = int.Parse(timesplit[0]);
                    int minute = int.Parse(timesplit[1]);
                    int second = int.Parse(timesplit[2]);
                    if (hour == DateTime.Now.Hour)
                    {
                        if (minute == DateTime.Now.Minute)
                        {
                            if (second == DateTime.Now.Second)
                            {
                                checktime = true;
                                if (checktime) { timerEnd.Start(); }

                            }
                        }
                    }
                }

            }

        }

        private void cbSet_CheckedChanged(object sender, EventArgs e)
        {
            alarmstart = true;


        }

        private void timerEnd_Tick(object sender, EventArgs e)
        {
            Settime(out bool check, out string time);
            timer = !timer;
            this.BackColor = timer ? Color.IndianRed : Color.Black;

            string[] timesplit = time.Split('時', '分', '秒');

            int hour = int.Parse(timesplit[0]);
            int minute = int.Parse(timesplit[1]);
            int second = int.Parse(timesplit[2]);
            if (hour == DateTime.Now.Hour)
            {
                if (minute == DateTime.Now.Minute)
                {
                    if ((second+5) == (DateTime.Now.Second))
                    {

                        timerEnd.Stop();
                        
                        timer = false;
                        alarmstart = false;
                        checktime = false;
                        this.BackColor = Color.MistyRose;
                        MessageBox.Show("時間到了!時間到了");
                    }
                }
            }

        }

        void Settime(out bool check,out string datetime) {
             datetime = txtTime.Text;
             check = int.TryParse(datetime.Replace("時", "").Replace("分", "").Replace("秒", "").Replace(" ", ""), out int time);


        }



    }
}
