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
    public partial class HomeWork_BullsCows : Form
    {
        public HomeWork_BullsCows()
        {
            InitializeComponent();
            Goal();
        }

        

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            HomeWork_Guess hwguess = new HomeWork_Guess(this);
            hwguess.Show();
            Goal();
            BCgame.high = 100;
            BCgame.low = 1;
            this.labTitle.Text = $"Please Select A Number Between {BCgame.low} To {BCgame.high}!";
             
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Answer:" + BCgame.goal);
        }

        void Goal()
        {
            int target;
            Random random = new Random();
            target = random.Next(1, 100);
            BCgame.goal=target;
        }




    }
}
