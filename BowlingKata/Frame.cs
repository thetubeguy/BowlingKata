using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class Frame
    {
        public string Score{ get; set; }
        public int Numeric_Score { get; set; }

        public int Frame_Num { get; set; }

        public Frame(int frame_num)
        {
            Score = "";
            Frame_Num = frame_num;
            Numeric_Score = 0;
        }

        public int Calculate_Numeric_Score()
        {
            foreach(char c in Score)
            {
                if(c == 'X')
                {
                    Numeric_Score += 10;
                }
                else
                {
                    Numeric_Score += ((int)Char.GetNumericValue(c));
                }
            }
            return Numeric_Score;
        }


    }


}
