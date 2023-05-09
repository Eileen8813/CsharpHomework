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
    }
}
