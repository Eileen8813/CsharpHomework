using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace HomeWorkAll
{
    public partial class HomeWork04 : Form
    {
        public HomeWork04()
        {
            InitializeComponent();
        }
        Store store = new Store(); //施作Store

        private void btnStore_Click(object sender, EventArgs e)
        {  //在HWClass中建立一個類別:Store，並宣告需要的string，在按鈕儲存的時候將Lable的資料傳入store中。
            //checkstore是用來避免沒按過儲存鍵的時候，儲存顯示雖然不會接收到Textbox但會秀出其他中文。
           
            ScoreStore();
            store.checkstore += 1;

        }

        void ScoreStore()
        {
            store.StudentName = txtName.Text;
            store.ScoreChinese = txtCh.Text;
            store.ScoreEnglish = txtEn.Text;
            store.ScoreMath = txtMath.Text;
          
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (store.checkstore>0) //判斷只要按過儲存鍵就可以觸發。
            {
                ScoreShow();  //執行下面的方法ScoreShow。
            }
        }

        void ScoreShow()
        {
            //Label儲存顯示會匯入儲存鍵存的資料。
            labShow.Text = $"姓名 : {store.StudentName}\n國文: {store.ScoreChinese} 分。\n英文: {store.ScoreEnglish} 分。" +
                $"\n數學: {store.ScoreMath} 分。";

        }
        string highsubject, lowsubject;

        private void btnHighlow_Click(object sender, EventArgs e)
        {
            int highscore,lowscore;
            
            ScoreStore();
            string[] allsubject = {"國文","英文","數學"};
            int[] allscore = { Convert.ToInt32(store.ScoreChinese), Convert.ToInt32(store.ScoreEnglish), Convert.ToInt32(store.ScoreMath) };
           
            highscore = allscore.Max();
            lowscore = allscore.Min();

            for (int i = 0; i < allscore.Length; i++)
            {
                if (allscore[i] == highscore)
                {
                    highsubject = allsubject[i];
                }
            }
            for (int i = 0; i < allscore.Length; i++)
            {
                if (allscore[i] ==lowscore)
                {
                   lowsubject = allsubject[i];
                }
            }
            labHighlow.Text = $"最高科目分數:{highsubject}{highscore}分。" +
                $"\n最低科目分數:{ lowsubject}{lowscore}分。";
           
        }
    }
}
