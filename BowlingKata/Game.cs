using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public  class Game
    {
        public string Scores { get; set; }
        public List<Frame> _frameList = new();

        public Game(string scores)
        {
            Scores = scores;

        }


        public void AddFrames()
        {
            for (int framenum = 0; framenum < 10; framenum++)
            {
                _frameList.Add(new Frame(framenum));
            }
        }

        public void Process_Scores()
        {
            

            char[] scores_array = Scores.Replace('-', '0').ToCharArray();

            int framenum = 0;
            bool shot2 = false;

            for (int bowlnum = 0; (bowlnum < scores_array.Count()) && (framenum < 10); bowlnum++)
            {

 
                if (scores_array[bowlnum] == 'X')
                {

                    _frameList[framenum].Score = String.Concat('X', scores_array[bowlnum + 1], scores_array[bowlnum + 2]);

                    framenum++;

                }
                else if (scores_array[bowlnum] == '/')
                {
                    _frameList[framenum].Score = String.Concat('X', scores_array[bowlnum + 1]);
                    framenum++;
                    shot2 = false;
                }
                else if (shot2)
                {
                    _frameList[framenum].Score = String.Concat(_frameList[framenum].Score, scores_array[bowlnum]);
                    framenum++;
                    shot2 = false;
                }
                else
                {
                    _frameList[framenum].Score = scores_array[bowlnum].ToString();
                    shot2 = true;

                }
                

            }
        }

 

        public int GetScore()
        {
            AddFrames();

            Process_Scores();


            int totalscore = 0;
            foreach(Frame myframe in _frameList)
            {

                totalscore += myframe.Calculate_Numeric_Score();
            }

            return totalscore;
        }
    }


}
