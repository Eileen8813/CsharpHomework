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
    public partial class HomeWork10XOgame : Form
    {
        public HomeWork10XOgame()
        {
            InitializeComponent();
            //this.KeyPreview = true;
        }
        bool xo = true;
        int checknum = 0;
        int[,] num = new int[3,3];
        //string num01, num02, num03, num04, num05, num06, num07, num08, num09;
        private void btnXO01_Click(object sender, EventArgs e)
        {

            btnXO01.Text = xo ? btnXO01.Text = "X" : btnXO01.Text = "O";
            num[0,0] = xo ? 1 : -1;
            btnXO01.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO02_Click(object sender, EventArgs e)
        {
            btnXO02.Text = xo ? btnXO02.Text = "X" : btnXO02.Text = "O";
            num[1,0] = xo ? 1 : -1;
            btnXO02.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO03_Click(object sender, EventArgs e)
        {
            btnXO03.Text = xo ? btnXO03.Text = "X" : btnXO03.Text = "O";
            num[2,0] = xo ? 1 : -1;
            btnXO03.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO04_Click(object sender, EventArgs e)
        {
            btnXO04.Text = xo ? btnXO04.Text = "X" : btnXO04.Text = "O";
            num[0,1] = xo ? 1 : -1;
            btnXO04.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO05_Click(object sender, EventArgs e)
        {
            btnXO05.Text = xo ? btnXO05.Text = "X" : btnXO05.Text = "O";
            num[1,1] = xo ? 1 : -1;
            btnXO05.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO06_Click(object sender, EventArgs e)
        {
            btnXO06.Text = xo ? btnXO06.Text = "X" : btnXO06.Text = "O";
            num[2,1] = xo ? 1 : -1;
            btnXO06.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO07_Click(object sender, EventArgs e)
        {
            btnXO07.Text = xo ? btnXO07.Text = "X" : btnXO07.Text = "O";
            num[0,2] = xo ? 1 : -1;
            btnXO07.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO08_Click(object sender, EventArgs e)
        {
            btnXO08.Text = xo ? btnXO08.Text = "X" : btnXO08.Text = "O";
            num[1,2] = xo ? 1 : -1;
            btnXO08.Enabled = false;
            checknum++;
            ClickCheck();
            xo = !xo;
        }

        private void btnXO09_Click(object sender, EventArgs e)
        {
            btnXO09.Text = xo ? btnXO09.Text = "X" : btnXO09.Text = "O";
            num[2,2] = xo ? 1 : -1;
            btnXO09.Enabled = false;
            checknum++;
            ClickCheck();

            xo = !xo;
        }
        void ClickCheck()
        {
        
            int result=0;
            int i=0, j=0;
          
            while (i < num.GetLength(0))
            {
                result = 0;
                j = 0;
                result += num[i, j] + num[i, j+1] + num[i, j+2];
                if (result == 3)
                {
                    MessageBox.Show("X方勝利!");
                    
                    ResetMethod();
                }
                else if (result == -3)
                {
                    MessageBox.Show("O方勝利!");
                    
                    ResetMethod();
                }

                i++;
            }
            //橫排
            while ( j < num.GetLength(0))
            {
                result = 0;
                i = 0;
                result += num[i, j] + num[i+1, j ] + num[i+2, j];
                if (result == 3)
                {
                    MessageBox.Show("X方勝利!");
                    ResetMethod();



                }
                else if (result == -3)
                {
                    MessageBox.Show("O方勝利!");
                    ResetMethod();

                }

               j++;
            }
            //左斜
                          
                if (num[0, 0] + num[1, 1] + num[2, 2] == 3)
                {
                    MessageBox.Show("X方勝利!");
                    ResetMethod();


            }
                else if (num[0, 0] + num[1, 1] + num[2, 2] == -3)
                {
                    MessageBox.Show("O方勝利!");
                    ResetMethod();

            }

            
            //右斜
           
                
                if (num[0,2] + num[1,1] + num[2,0] == 3)
                {
                    MessageBox.Show("X方勝利!");
                    ResetMethod();


            }
                else if (num[0, 2] + num[1, 1] + num[2, 0] == -3)
                {
                    MessageBox.Show("O方勝利!");
                    ResetMethod();

            }

            }

       
        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetMethod();
            
            
        }


       
           
        void ResetMethod()
        {
            this.Controls.Clear();
            InitializeComponent();
 
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = 0; 
                }
            }
        }

        private void HomeWork10XOgame_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == 'r' || e.KeyChar == 'R')
            {
                btnReset.PerformClick();
            }

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeWork10XOgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }
    }

   
}


