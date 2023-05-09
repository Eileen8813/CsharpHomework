using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkAll
{
    public partial class HomeWork03 : Form
    {
        public HomeWork03()
        {
            InitializeComponent();
        }

        int price = 0;
        int discountprice = 0;
        int displaynumber, blackteanum, juicenum, oolongteanum, greenteanum;
        string display, blackteadisplay, juicedisplay, oolongteadisplay, greenteadisplay;

     

        private void btnBlackTea_Click(object sender, EventArgs e)
        {
            price += 120; // price= price+120
            blackteanum += 1;
            labTotal.Text = "NT$"+price;
            blackteadisplay = "Black Tea x" + blackteanum + ", 共NT$" + Convert.ToString(120* blackteanum ) + " 元。";
            display = blackteadisplay + juicedisplay + oolongteadisplay + greenteadisplay;
            labDisplay.Text = display;
                                   

        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            price += 180;
            juicenum += 1;
            labTotal.Text = "NT$" + price;
            juicedisplay = "Juice x" + juicenum + ", 共NT$" + Convert.ToString(180 * juicenum) + " 元。\n";
            display = blackteadisplay + juicedisplay + oolongteadisplay + greenteadisplay;
            labDisplay.Text = display;

        }

        private void btnOolongTea_Click(object sender, EventArgs e)
        {
            price += 350;
            oolongteanum += 1;
            labTotal.Text = "NT$" + price;
            oolongteadisplay="Oolong Tea x"+ oolongteanum+ ", 共NT$" + Convert.ToString(350* oolongteanum) + " 元。" + "\r\n";
            display = blackteadisplay + juicedisplay + oolongteadisplay + greenteadisplay;
            labDisplay.Text = display;
        }

        private void btnGreenTea_Click(object sender, EventArgs e)
        {
            price += 320;
            greenteanum += 1;
            labTotal.Text = "NT$" + price;
            greenteadisplay = "Green Tea x" + greenteanum + ", 共NT$" + Convert.ToString(320 * greenteanum);
            display = blackteadisplay + juicedisplay + oolongteadisplay + greenteadisplay;
            labDisplay.Text = display;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            price = 0;
            displaynumber = 0;
            blackteanum = 0;
            juicenum = 0;
            oolongteanum = 0;
            greenteanum = 0;
            blackteadisplay = "";
            juicedisplay = "";
            oolongteadisplay = "";
            greenteadisplay = "";
            display = "尚未點餐。";
            labTotal.Text = "NT$" + price;
            labDisplay.Text = display;

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (price > 0)
            {
                MessageBox.Show("總金額:NT$" + price, "確認付款");
            }
            else
                MessageBox.Show("尚未點餐喔!", "確認付款",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            discountprice = Convert.ToInt32(price * 0.9);
            if (price > 0)
            {
                MessageBox.Show("總金額:NT" + price + Environment.NewLine
                    + "折扣後金額為: NT$" + discountprice, "確認付款");
            }
            else
                MessageBox.Show("尚未點餐喔!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
