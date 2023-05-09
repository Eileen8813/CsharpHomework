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
    public partial class HomeWork04 : Form
    {
        public HomeWork04()
        {
            InitializeComponent();
        }
        string testtest = "姓名:0";
        private void btnStore_Click(object sender, EventArgs e)
        {

            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
        }
       
        private void btnShow_Click(object sender, EventArgs e)
        {

            Studenttest(testtest);
            this.btnShow.Click -= new System.EventHandler(this.btnShow_Click);

        }
        void Studenttest(string/* []*/ score)
        {
            Label studentshow = labShow;//透過宣告studentshow=要顯示在LABLE上面的文字。
            studentshow.Text = $"姓名 : {txtName.Text}\n國文: {txtCh.Text} 分。\n英文: {txtEn.Text} 分。" +
                $"\n數學: {txtMath.Text} 分。";
            //score = [ txtName.Text ,txtCh.Text, txtEn.Text, txtMath.Text ];
        }

        private void btnHighlow_Click(object sender, EventArgs e)
        {
            int average;

            //if(txtCh.Text-txtEn.Text-txtMath.Text)
        }
    }
}
