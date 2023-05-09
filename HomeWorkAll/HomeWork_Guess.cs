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
    public partial class HomeWork_Guess : Form
    {
        public HomeWork_Guess(HomeWork_BullsCows Parentform)
        {
            InitializeComponent();
            this.Tag = Parentform;
        }
        HomeWork_BullsCows hwbc = new HomeWork_BullsCows();
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            BCgame bcgame= new BCgame();
           
            int guess = 0;
            bool check = int.TryParse(txtGuess.Text, out guess);
            if (check)
            {
                if (guess > BCgame.goal)
                {
                    BCgame.high = guess;
                    BCgame.titlelab = $"Please Select A Number Between {BCgame.low} To {BCgame.high}!";
                    ((HomeWork_BullsCows)this.Tag).labTitle.Text = BCgame.titlelab;
                    
                }
                else if (guess < BCgame.goal)
                {
                    BCgame.low = guess;
                    BCgame.titlelab = $"Please Select A Number Between {BCgame.low} To {BCgame.high}!";
                    ((HomeWork_BullsCows)this.Tag).labTitle.Text = BCgame.titlelab;
                }
                else if (guess == BCgame.goal)
                {
                    MessageBox.Show($"Congratulations!!!You got {BCgame.goal}");
                    Close();
                }
                else
                {
                    MessageBox.Show($"請輸入{BCgame.low}~{BCgame.high}之間的數字!");
                }
            }
        }
            private void btnCancel_Click(object sender, EventArgs e)
            {
                Close();
            }
        
    }
}