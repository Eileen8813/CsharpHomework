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
    public partial class HomeWork_Screen : Form
    {
        public HomeWork_Screen()
        {
            InitializeComponent();
            
        }
        Point screenPoint;
        private void HomeWork_Screen_Load(object sender, EventArgs e)
        {
            //this.DoubleBuffered = true; //減少執行時圖片閃爍
            screenPoint = Control.MousePosition;
            timerStar.Start();
        }
        int speedx = 10, speedy =8;


        private void tinerStop_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeWork_Screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (screenPoint != Control.MousePosition)
            {
                timerStop.Start();
            }
            
            
        }

        private void timerStar_Tick(object sender, EventArgs e)
        {
            
            pbGengar.Left += speedx;
            pbGengar.Top += speedy;
            if (pbGengar.Right> this.ClientSize.Width|| pbGengar.Left<0) {
                speedx = -speedx;
            }
            if(pbGengar.Bottom> this.ClientSize.Height|| pbGengar.Top<0)
            {
                speedy=-speedy;
            }
        }

       
    }
}
