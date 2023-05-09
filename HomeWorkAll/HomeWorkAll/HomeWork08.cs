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

     

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double plus;
            plus = double.Parse(txtNum01.Text) + double.Parse(TxtNum02.Text);
            txtAnswer.Text= Convert.ToString(plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double minus;
            minus = double.Parse(txtNum01.Text) - double.Parse(TxtNum02.Text);
            txtAnswer.Text = Convert.ToString(minus);
        }

        private void btnMultiplied_Click(object sender, EventArgs e)
        {
            double multiplied;
            multiplied = double.Parse(txtNum01.Text) * double.Parse(TxtNum02.Text);
            txtAnswer.Text = Convert.ToString(multiplied);
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            double divided,result;
            string resultlength;
            divided = double.Parse(txtNum01.Text) / double.Parse(TxtNum02.Text);
            result = Math.Round(divided,4) ;
            resultlength =result.ToString("0.0000");
                        
            txtAnswer.Text = resultlength;
        }
    }
}
