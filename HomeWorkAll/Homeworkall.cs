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
            hw01.Show();
        }

        private void bntHomework02_Click(object sender, EventArgs e)
        {
            HomeWork02 hw02 = new HomeWork02();
            hw02.Show();
        }

        private void bntHomework03_Click(object sender, EventArgs e)
        {
            HomeWork03 hw03 = new HomeWork03();
            hw03.Show();
        }

        private void bntHomework04_Click(object sender, EventArgs e)
        {
            HomeWork04 hw04 = new HomeWork04();
            hw04.Show();
        }

        private void bntHomework05_Click(object sender, EventArgs e)
        {
            HomeWork05 hw05 = new HomeWork05();
            hw05.Show();
        }

        private void bntHomework06_Click(object sender, EventArgs e)
        {
            HomeWork06 hw06 = new HomeWork06();
            hw06.Show();
        }



        private void bntHomework08_Click(object sender, EventArgs e)
        {
            HomeWork08 hw08 = new HomeWork08();
            hw08.Show();    
        }

        private void bntHomework09_Click(object sender, EventArgs e)
        {
            HomeWork09 hw09 = new HomeWork09();
            hw09.Show();
        }

        private void bntHomework10_Click(object sender, EventArgs e)
        {
            HomeWork10XOgame  hw10 = new HomeWork10XOgame();
            hw10.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            HWAlarm hwAlarm = new HWAlarm();
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
            homeWork_BullsCows.Show();
        }
    }
}
