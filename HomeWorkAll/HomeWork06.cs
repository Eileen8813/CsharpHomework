using System;
using System.Collections;
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
    public partial class HomeWork06 : Form
    {
        public HomeWork06()
        {
            InitializeComponent();
        }

        ArrayList scorelist = new ArrayList();
        Score score;
        void Makelist()
        {

            txtShow.Text ="";
            foreach (Score forscore in scorelist)
            {

                txtShow.Text += $"\t{forscore.Name}\t{forscore.Chscore}\t{forscore.Enscore}\t{forscore.Mathscore}\t{forscore.Totalscore}" +
                           $"\t{forscore.Averagescore}\t{forscore.Lowsubject}{forscore.Lowscore}\t{forscore.Highsubject}{forscore.Highscore}"+Environment.NewLine;

            }
            btnStatic.Enabled = true;
        }




        private void btnJoinScore_Click(object sender, EventArgs e)
        {
            double Average;
            score.Name = txtName.Text;
            bool checkch = int.TryParse(txtCh.Text, out score.Chscore);
            bool checken = int.TryParse(txtEn.Text, out score.Enscore);
            bool checkmath = int.TryParse(txtMath.Text, out score.Mathscore);
            if (checkmath && checken && checkch)
            {
                score.Totalscore = score.Chscore + score.Enscore + score.Mathscore;
                Average = Convert.ToDouble(score.Totalscore) / 3;
                score.Averagescore = Math.Round(Average, 1);
                Maxminscore();
                scorelist.Add(score);
                Makelist();
            }
            else
            {
                MessageBox.Show("請輸入分數!");
            }

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            double Average;
            score.Name = txtName.Text;
            bool checkch = int.TryParse(txtCh.Text, out score.Chscore);
            bool checken = int.TryParse(txtEn.Text, out score.Enscore);
            bool checkmath = int.TryParse(txtMath.Text, out score.Mathscore);
            if (checkmath && checken && checkch)
            {
                score.Totalscore = score.Chscore + score.Enscore + score.Mathscore;
                Average = Convert.ToDouble(score.Totalscore) / 3;
                score.Averagescore = Math.Round(Average, 1);
                Maxminscore();
                scorelist.Insert(0,score);
                Makelist();
            }
            else
            {
                MessageBox.Show("請輸入分數!");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (scorelist.Count == 0)
            {
                MessageBox.Show("沒有資料可以清除了");
            }
            else
            {
                scorelist.RemoveAt(0);
                Makelist();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            scorelist.Clear();
            txtShow.Text = "";
            rtbStatistic.Text = "";
            btnJoin.Enabled = true;
            btnJoinScore.Enabled = true;
            btnStatic.Enabled = true;
            btnRemove.Enabled = true;
            btnSearch.Enabled = true;
          

        }

        private void btnSerch_Click(object sender, EventArgs e)
        {   int chlow,chhigh;
            bool checklow = int.TryParse(txtlow.Text,out chlow);
            bool checkhigh = int.TryParse(txthigh.Text, out chhigh);
            if(checklow && checkhigh)
            {
                
                ArrayList scoresearchlist = new ArrayList();
                txtShow.Text = "";
                for(int i = 0; i < scorelist.Count; i++) {
                    if (((Score)scorelist[i]).Chscore >= chlow && ((Score)scorelist[i]).Chscore <= chhigh)
                    {
                        scoresearchlist.Add(scorelist[i]); 
                    }
                }

                foreach (Score forscore in scoresearchlist)
                {
                    
                        txtShow.Text += $"\t{forscore.Name}\t{forscore.Chscore}\t{forscore.Enscore}\t{forscore.Mathscore}\t{forscore.Totalscore}" +
                                $"\t{forscore.Averagescore}\t{forscore.Lowsubject}{forscore.Lowscore}\t{forscore.Highsubject}{forscore.Highscore}" + Environment.NewLine;

                }

            }
           
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            int ststicch = 0, ststicen = 0, ststicmath = 0;
            int lowch, lowen, lowmath, highch, highen, highmath;
            double averageSch, averageSen, averageSmath;

            int[] Arrch = new int[scorelist.Count];
            int[] Arren = new int[scorelist.Count];
            int[] Arrmath = new int[scorelist.Count];

            int i = 0;
            foreach (Score forscore in scorelist)
            {
                ststicch += forscore.Chscore;
                ststicen += forscore.Enscore;
                ststicmath += forscore.Mathscore;
                Arrch[i] = forscore.Chscore;
                Arren[i] = forscore.Enscore;
                Arrmath[i] = forscore.Mathscore;
                i++;

            }
            if (txtShow.Text == "")
            {
                MessageBox.Show("請輸入成績才可統計!");
            }
            else
            {
                highch = Arrch.Max();
                lowch = Arrch.Min();
                highen = Arren.Max();
                lowen = Arren.Min();
                highmath = Arrmath.Max();
                lowmath = Arrmath.Min();
                averageSch = Math.Round(Convert.ToDouble(ststicch) / scorelist.Count, 1);
                averageSen = Math.Round(Convert.ToDouble(ststicen) / scorelist.Count, 1);
                averageSmath = Math.Round(Convert.ToDouble(ststicmath) / scorelist.Count, 1);

                rtbStatistic.Text = $"   總分 \t{ststicch}\t{ststicen}\t{ststicmath}\t\t\t\t\t\t\n" +
                    $"   平均 \t{averageSch}\t{averageSen}\t{averageSmath}\t\t\t\t\t\t\n" +
                    $"   最高分\t{highch}\t{highen}\t{highmath}\t\t\t\t\t\t\n" +
                    $"   最低分\t{lowch}\t{lowen}\t{lowmath}\t\t\t\t\t\t\n";
                btnJoin.Enabled = false;
                btnJoinScore.Enabled = false;
                btnStatic.Enabled = false;
                btnRemove.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        void Maxminscore()
        {
            if (score.Chscore > score.Enscore && score.Chscore > score.Mathscore)
            {
                score.Highscore = score.Chscore;
                score.Highsubject = "國文";
                if (score.Enscore < score.Mathscore)
                {
                    score.Lowscore = score.Enscore;
                    score.Lowsubject = "英文";
                }
                else
                {
                    score.Lowscore = score.Mathscore;
                    score.Lowsubject = "數學";
                }
            }
            else if (score.Enscore > score.Chscore && score.Enscore > score.Mathscore)
            {
                score.Highscore = score.Enscore;
                score.Highsubject = "英文";
                if (score.Chscore < score.Mathscore)
                {
                    score.Lowscore = score.Chscore;
                    score.Lowsubject = "國文";
                }
                else
                {
                    score.Lowscore = score.Mathscore;
                    score.Lowsubject = "數學";
                }
            }
            else if (score.Mathscore >= score.Chscore && score.Mathscore >= score.Enscore)
            {
                score.Highscore = score.Mathscore;
                score.Highsubject = "數學";
                if (score.Chscore < score.Enscore)
                {
                    score.Lowscore = score.Chscore;
                    score.Lowsubject = "國文";
                }
                else
                {
                    score.Lowscore = score.Enscore;
                    score.Lowsubject = "英文";
                }

            }
        }


    }
}
