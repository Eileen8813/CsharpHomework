using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorkAll
{
    public class Store
    {
        internal string StudentName,ScoreChinese,ScoreEnglish,ScoreMath;
        internal int checkstore;
    }

    public class XOGame
    {
        internal int xonumber, xoremainder;
    }
    public class BCgame
    {
        internal static int goal, high, low;
        internal static string titlelab;
        
    }
    public struct Score
    {  
        public string Name, Highsubject , Lowsubject;
        public int Totalscore, Chscore, Enscore, Mathscore,Highscore,Lowscore;
        public double Averagescore;
    }




}
