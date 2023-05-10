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
    public partial class HomeWorkMajor : Form
    {
        public HomeWorkMajor()
        {
            InitializeComponent();


        }




        private void bntHomework01_Click(object sender, EventArgs e)
        {
            HomeWork01 hw01= new HomeWork01();

       
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height+27 ;
            this.StartPosition = FormStartPosition.Manual;
            hw01.Location = new Point(x,y);
            hw01.Show();


        }

        private void bntHomework02_Click(object sender, EventArgs e)
        {
            HomeWork02 hw02 = new HomeWork02();

            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;
 
            hw02.Location = new Point(x, y);
            hw02.Show();
        }

        private void bntHomework03_Click(object sender, EventArgs e)
        {
            HomeWork03 hw03 = new HomeWork03();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw03.Location = new Point(x, y);
            hw03.Show();
        }

        private void bntHomework04_Click(object sender, EventArgs e)
        {
            HomeWork04 hw04 = new HomeWork04();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;
           
            hw04.Location = new Point(x, y);
            hw04.Show();
        }

        private void bntHomework05_Click(object sender, EventArgs e)
        {
            HomeWork05 hw05 = new HomeWork05();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw05.Location = new Point(x, y);
            hw05.Show();
        }

        private void bntHomework06_Click(object sender, EventArgs e)
        {
            HomeWork06 hw06 = new HomeWork06();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw06.Location = new Point(x, y);
            hw06.Show();
        }



        private void bntHomework08_Click(object sender, EventArgs e)
        {
            HomeWork08 hw08 = new HomeWork08();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw08.Location = new Point(x, y);
            hw08.Show();    
        }

        private void bntHomework09_Click(object sender, EventArgs e)
        {
            HomeWork09 hw09 = new HomeWork09();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw09.Location = new Point(x, y);
            hw09.Show();
        }

        private void bntHomework10_Click(object sender, EventArgs e)
        {
            HomeWork10XOgame  hw10 = new HomeWork10XOgame();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hw10.Location = new Point(x, y);
            hw10.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            HWAlarm hwAlarm = new HWAlarm();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            hwAlarm.Location = new Point(x, y);
            hwAlarm.Show();

        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            HomeWork_Screen hwScreen = new HomeWork_Screen();
            hwScreen.Show();
        }

        private void bntBullsCowws_Click(object sender, EventArgs e)
        {
            HomeWork_BullsCows homeWork_BullsCows = new HomeWork_BullsCows();
            int x = splitleftright.Panel1.Width;
            int y = splitTopBottom.Panel1.Height + 27;

            homeWork_BullsCows.Location = new Point(x, y);
            homeWork_BullsCows.Show();
        }

    }
}
