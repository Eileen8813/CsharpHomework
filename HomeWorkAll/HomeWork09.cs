using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkAll
{
    public partial class HomeWork09 : Form
    {
        public HomeWork09()
        {
            InitializeComponent();
        }


        int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arrstring = new string[] {"mother張","emma","迪克蕭","J40","Candy","Cindy","Coconut","Motherfacker"};

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int num = 0;
            string result;
            bool mistakecheck = int.TryParse(txtNumber.Text, out num);
            if (mistakecheck)
            {

                num %= 2;

                switch (num)
                {
                    case 0:
                        result = $"輸入的數{txtNumber.Text}為 偶數。";
                        labShow.Text = result;
                        break;
                    case 1:
                        result = $"輸入的數{txtNumber.Text}為 奇數。";
                        labShow.Text = result;
                        break;
                }
            }
            else
            {
                MessageBox.Show("請輸入數值!");
            }


        }
        
        private void ArrOddEven_Click(object sender, EventArgs e)
        {

            int oddnum = 0, evennum = 0;
            string result, arrshow = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arrshow += arr[i] + ",";
                arr[i] %= 2;
                if (arr[i] == 1)
                {
                    oddnum++;
                }
                else if (arr[i] == 0)
                {
                    evennum++;
                }
            }
            result = $"int陣列arr0711[{arrshow}]\n奇數共{oddnum}。\n偶數共{evennum}。";
            //result = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578 ]\n奇數共{oddnum}。\n偶數共{evennum}。";
            labShow.Text = result;
        }

        private void ArrMaxMin_Click(object sender, EventArgs e)
        {
            string result;
            int maxnum = 0, minnum = 0;
            maxnum = arr.Max();
            minnum = arr.Min();
            result = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578 ]\n最大值為{maxnum}。\n最大值為{minnum}。";
            labShow.Text = result;
        }

        private void btnOnsideOne_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] arrtenten = new int[10, 10];
            for (int i = 0; i < arrtenten.GetLength(0); i++)
            {
                for (int j = 0; j < arrtenten.GetLength(1); j++)
                {
                    bool check = (i == 0 || j == 0 || i == 9 || j == 9);
                    if (check)
                    {
                        arrtenten[i, j] = 1;
                        result += " " + arrtenten[i, j] + " ";
                    }
                    else if (!check)
                    {
                        arrtenten[i, j] = 0;
                        result += " " + arrtenten[i, j] + " ";

                    }

                }
                result += "\n";
            }
            labShow.Text = result ;


        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1=100, n2=200, nt=0;
            int[] arr=new int[4];
            arr[0] = n1;
            arr[1] = n2;
            nt = n1;
            n1 = n2;
            n2 = nt;
            labShow.Text = $"換位前n1={arr[0]}，n2={arr[1]}\n換位後n1={n1}，n2={n2}";
        }

        private void btnArrSum_Click(object sender, EventArgs e)
        {
            int sumnumber = 0;
            string result;
            sumnumber = arr.Sum();
            result = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578 ]\n加總為{sumnumber}。";
            labShow.Text = result;
        }

        private void btnArrMax_Click(object sender, EventArgs e)
        {
            string result;
            int maxnum = 0;
            maxnum = arr.Max();
            result = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578 ]\n最大值為{maxnum}。";
            labShow.Text = result;
        }

        private void btnArrMin_Click(object sender, EventArgs e)
        {
            string result;
            int  minnum = 0;
            minnum = arr.Min();
            result = $"int陣列arr0711[1,5,6,8,7,97,54,887,65,578 ]\n最大值為{minnum}。";
            labShow.Text = result;
        }

        private void btnOnsideZero_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] arrtenten = new int[10, 10];
            for (int i = 0; i < arrtenten.GetLength(0); i++)
            {
                for (int j = 0; j < arrtenten.GetLength(1); j++)
                {
                    bool check = (i == 0 || j == 0 || i == 9 || j == 9);
                    if (check)
                    {
                        arrtenten[i, j] = 0;
                        result += " "+arrtenten[i, j] + " ";
                    }
                    else if (!check)
                    {
                        arrtenten[i, j] =1;
                        result += " " + arrtenten[i, j] + " ";

                    }

                }
                result += "\n";
            }
            labShow.Text = result ;

        }

        private void btnOneZero_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] arrtenten = new int[10, 10];
            for (int i = 0; i < arrtenten.GetLength(0); i++)
            {
                for (int j = 0; j < arrtenten.GetLength(1); j++)
                {
                    bool checkone = ((i+j) %2==1 );
                    bool checkzero = ((i + j) % 2 == 0);
                    if (checkone)
                    {
                        arrtenten[i, j] = 0;
                        result += " " + arrtenten[i, j] + " ";
                    }
                    else if (checkzero)
                    {
                        arrtenten[i, j] = 1;
                        result += " " + arrtenten[i, j] + " ";
                    }
                }
                result += "\n";
            }
            labShow.Text = result + "";
        }

        private void btnArr0711String_Click(object sender, EventArgs e)
        {
            string countc = "";
            int totalc=0 ;

            for (int i = 0; i < arrstring.Length; i++)
            {
                
                countc = arrstring[i].ToLower();  // arrstring[i]文字全部轉小寫。
                char checknums = 'c' ;   //要尋找的字母
                int a = countc.Split(checknums).Length-1  ;
                
                bool check = (countc.Split(checknums).Length-1>0); //countc.Split('c').Length-1
                if (check)                          //要減1的原因是原字串原先沒有字母c的話不會分開，至少有是一個字串
                {                                         //，有一個C會分成2個字串，所以字串數是(C數量+1)，因此要減掉
                    totalc += 1;               //原來的一個字串數量。
                }
                else
                {
                    totalc += 0;
                }
            }

            labShow.Text = $"陣列arr0711_Str [mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,Motherfacker]" +
                $"\n有C及c的名字共有{totalc}個。";

        }

        private void btnLength_Click(object sender, EventArgs e)
        {

            int[] arrcount = new int[arrstring.Length];
            string result=null;
            for (int i = 0;i < arrstring.Length;i++) {
                arrcount[i] = arrstring[i].Length;
                            }
            
            int arrmaxlength = arrcount.Max();
            for (int i = 0; i < arrstring.Length; i++)
            {
                if (arrmaxlength == arrcount[i])
                {
                    result = arrstring[i];
                }
            }
            labShow.Text = $"陣列arr0711_Str [mother張,emma,迪克蕭,J40,Candy,Cindy,Coconut,Motherfacker]" +
                $"\n最長的名字為{result}。";
           
        }

        private void btnShowClean_Click(object sender, EventArgs e)
        {
            labShow.Text = null;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            int rows;
            string result = null, starnum = null;
            bool checkrows = int.TryParse(txtRows.Text, out rows);
            if (checkrows)
            {
                for (int i = 1; i <= rows; i++)
                {
                    starnum += " * ";
                    result += starnum + "\n";
                }
                labShow.Text = result;

            }
            else
            {
                MessageBox.Show("請輸入數值!");
            }
            
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int check = 100; 
            string binary = null;
            string result = null;
            while (check > 0)
            {
                binary = Convert.ToString(check % 2);
                check /= 2;
                result = binary+ result;/*小心方向相反*/
            }
            labShow.Text = result;
        }

        private void btnNineN_Click(object sender, EventArgs e)
        {
            string result = " 九九乘法表\n";
            int product;
            for(int i = 1; i < 10; i++)
            {
                for(int j=2; j < 10; j++)
                {
                    product = j * i;

                    string ialign = String.Format("{0,1}", i);
                    string productalign = String.Format("{0,3}", product);
                    result += $" {j}x {ialign}={productalign}{String.Format("{0,2}","l")}";
                }
                result += "\n";


            }
            labShow.Text = result;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        { string result = null;
            Random random = new Random();
            int[] lottery=new int[7];
            int lotterynum = random.Next(1, 50);
            lottery[0] =lotterynum;
            for (int i = 1; i <lottery.Length; i++)
            {
                lotterynum = random.Next(1,49);

                for (int j = 0; j < lottery.Length; j++)
                {
                    if (lottery[j] != lotterynum)
                    {
                        lottery[i] = lotterynum;

                    }
                    else
                    {
                        lotterynum = random.Next(1, 49);
                    }
                   
                }
                result += " "+lottery[i] + " ";
            }
            labShow.Text = $"樂透號碼\n{result}";


        }
               

            

                
               
        
    }
}
