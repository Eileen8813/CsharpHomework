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
    public partial class HomeWork01 : Form
    {
        public HomeWork01()
        {
            InitializeComponent();
           
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string nameen = txtNameEN.Text;
            string gender = txtGender.Text;
            string starsign = txtStarsign.Text;
            MessageBox.Show("Hello,我是" + name + Environment.NewLine + "英文名字是" + nameen
                + Environment.NewLine + "性別是" + gender + Environment.NewLine + "星座是" + starsign
                + Environment.NewLine + "很高興認識你。");
                   
        }
        private void btnHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string nameen = txtNameEN.Text;
            string gender = txtGender.Text;
            string starsign = txtStarsign.Text;
            MessageBox.Show("Hi,我是" + name + Environment.NewLine + "英文名字是" + nameen
                + Environment.NewLine + "性別是" + gender + Environment.NewLine + "星座是" + starsign
                + Environment.NewLine + "很高興認識你。");

        }




    }
}
