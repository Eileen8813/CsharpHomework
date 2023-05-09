using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HomeWorkAll
{
    public partial class HomeWork10 : Form
    {
        public HomeWork10()
        {
            InitializeComponent();
        }
        bool xocheck=true;
        //Xogame xogame = new Xogame();
        //int xonum01, xonum02, xonum03, xonum04, xonum05, xonum06, xonum07, xonum08, xonum09;
        int[] xonum = new int[9];
        private void btnXO01_Click(object sender, EventArgs e)
        {
            btnXO01.Text = xocheck ? "X" : "O";
            xonum[0] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO01.Enabled = false;            
            XOCheck();
        }

        private void btnXO02_Click(object sender, EventArgs e)
        {
            btnXO02.Text = xocheck ? "X" : "O";
            xonum[1] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO02.Enabled = false;
            
            XOCheck();
        }

        private void btnXO03_Click(object sender, EventArgs e)
        {
            btnXO03.Text = xocheck ? "X" : "O";
            xonum[2] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO03.Enabled = false;
           
            XOCheck();
        }

        private void btnXO04_Click(object sender, EventArgs e)
        {
            btnXO04.Text = xocheck ? "X" : "O";
            xonum[3] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO04.Enabled = false;
            
            XOCheck();
        }

        private void btnXO05_Click(object sender, EventArgs e)
        {
            btnXO05.Text = xocheck ? "X" : "O";
            xonum[4] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO05.Enabled = false;
            
            XOCheck();
        }

        private void btnXO06_Click(object sender, EventArgs e)
        {
            btnXO06.Text = xocheck ? "X" : "O";
            xonum[5] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO06.Enabled = false;
            
            XOCheck();
        }

        private void btnXO07_Click(object sender, EventArgs e)
        {
            btnXO07.Text = xocheck ? "X" : "O";
            xonum[6] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO07.Enabled = false;
            
            XOCheck();
        }

        private void btnXO08_Click(object sender, EventArgs e)
        {
            btnXO08.Text = xocheck ? "X" : "O";
            xonum[7] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO08.Enabled = false;
            
            XOCheck();
        }

        private void btnXO09_Click(object sender, EventArgs e)
        {
            btnXO09.Text = xocheck ? "X" : "O";
            xonum[8] = xocheck ? 1 : -1;
            xocheck = !xocheck;
            btnXO09.Enabled = false;
            
            XOCheck();
        }

        void XOCheck()
        {
            double check = 1d;
            for (int i = 0; i < 9; i += 3)
            {
                double checkxo = xonum[i] + xonum[i + 1] + xonum[i + 2];
                //double checkxo01 = xonum[0] + xonum[1] + xonum[2];
                //double checkxo02 = xonum[3] + xonum[4] + xonum[5];
                //double checkxo03 = xonum[6] + xonum[7] + xonum[8];
                checkxo /= 3;
                if(xonum[i]!=0)
                if (checkxo == 1)
                {
                    MessageBox.Show("X方勝利!");

                }
                else if (checkxo == -1)
                {
                    MessageBox.Show("O方勝利!");

                }
                //if (checkxo01 == 3 || checkxo02 == 3 || checkxo03 == 3)
                //{
                //    MessageBox.Show("X方勝利!");
                //    //btnXO01.ResetText();
                //    //btnXO02.ResetText();
                //    //btnXO03.ResetText();
                //    //btnXO04.ResetText();
                //    //btnXO05.ResetText();
                //    //btnXO06.ResetText();
                //    //btnXO07.ResetText();
                //    //btnXO08.ResetText();
                //    //btnXO09.ResetText();

                //}
                //else if (checkxo01 == 6 || checkxo02 == 6 || checkxo03 == 6)
                //{
                //    MessageBox.Show("O方勝利!");
                //}



                }

            }






    }
}
