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
    public partial class HomeWork08 : Form
    {
        public HomeWork08()
        {
            InitializeComponent();
        }
        double num1, num2;
        bool nubcheck()
        {
            
            bool numn1check = double.TryParse(txtNum01.Text, out num1);
            bool numb2check = double.TryParse(TxtNum02.Text, out num2);
            return numn1check && numb2check;

        }
     

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double plus;
            
            if (nubcheck())
            {
                plus = num1 + num2;
                txtAnswer.Text = Convert.ToString(plus);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double minus;
            if (nubcheck())
            {
                minus= num1 - num2;
                txtAnswer.Text = Convert.ToString(minus);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }

        }

        private void btnMultiplied_Click(object sender, EventArgs e)
        {
            double multiplied;
            if (nubcheck())
            {
                multiplied = num1 * num2;
                txtAnswer.Text = Convert.ToString(multiplied);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }


        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            double divided,result;
            string resultlength;
            if (nubcheck())
            {
                divided = num1 / num2;
                //result = Math.Round(divided, 4);
                result = divided;
                resultlength = result.ToString("0.0000");
                txtAnswer.Text = resultlength;
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }


        }
    }
}
