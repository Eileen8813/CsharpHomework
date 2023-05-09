using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkAll
{
    public partial class HomeWork02 : Form
    {
        public HomeWork02()
        {
            InitializeComponent();
        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {
           // double amount, year, rate, firstamount;
           // amount = double.Parse(txtAmount.Text);
           // year = double.Parse(txtYear.Text);
           // rate = double.Parse(txtRate.Text);
           // firstamount = double.Parse(txtFirstAmount.Text);
            
           // double month, monthrate,monthrateOne, square, payrate,pmtrate;
           // month = year * 12.0;
           // monthrate = (rate / 12.0)/100.0;
           // square =(Math.Pow((1+monthrate), month));
           // pmtrate = (square* monthrate) / (square - 1);
           //int pmt =Convert.ToInt32(pmtrate*amount);
           
           // MessageBox.Show("每月還" + pmt  );
            //每月應付本息金額之平均攤還率
            //＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
           
            int pmt01 = 0, total01 = 0;
            Count(out pmt01, out total01);

            MessageBox.Show("每月還" + pmt01+ "元。");
            }
                
        void Count(out int pmt,out int total)
        {
            double amount, year, rate, firstamount;
            amount = double.Parse(txtAmount.Text);
            year = double.Parse(txtYear.Text);
            rate = double.Parse(txtRate.Text);
            firstamount = double.Parse(txtFirstAmount.Text);

            double month, monthrate, square, pmtrate;
            month = year * 12.0;
            monthrate = (rate / 12.0) / 100.0;
            square = (Math.Pow((1 + monthrate), month));
            pmtrate = (square * monthrate) / (square - 1);
            pmt = Convert.ToInt32(pmtrate * (amount - firstamount)) ;
            total = Convert.ToInt32(pmt * month);


        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            int pmt02 = 0, total02 = 0;
            Count(out pmt02,out total02);
            MessageBox.Show("總付款" + total02+ "元。");

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            HomeWork02_Report hwr = new HomeWork02_Report();            
            hwr.Show();
            int ReportMonth = 0, ReportTotal = 0;
            Count(out ReportMonth,out ReportTotal);
            hwr.txtShowAmount.Text = txtAmount.Text;
            hwr.txtShowYear.Text = txtYear.Text;
            hwr.txtShowRate.Text = txtRate.Text;
            hwr.txtShowFirstAmount.Text = txtFirstAmount.Text;
            hwr.txtShowMonth.Text = ReportMonth.ToString();
            hwr.txtShowTotal.Text = ReportTotal.ToString();



        }
    }
}
