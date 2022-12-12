using KfksScore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KfksScore.Models
{
    public class KataFormViewModel : IKataForm, INotifyPropertyChanged
    {
        public KataFormViewModel()
        {
            JudgeScore1 = 0.0;
            JudgeScore2 = 0.0;
            JudgeScore3 = 0.0;
            JudgeScore4 = 0.0;
            JudgeScore5 = 0.0;
            AverageScore = CalculateAverage();
            ScoreHistory = String.Empty;
        }

        private double _judgeScore1;
        public double JudgeScore1
        {
            get { return _judgeScore1; }
            set { _judgeScore1 = value; OnPropertyChanged("JudgeScore1"); }
        }

        private double _judgeScore2;
        public double JudgeScore2
        {
            get { return _judgeScore2; }
            set { _judgeScore2 = value; OnPropertyChanged("JudgeScore2"); }
        }
        private double _judgeScore3;
        public double JudgeScore3
        {
            get { return _judgeScore3; }
            set { _judgeScore3 = value; OnPropertyChanged("JudgeScore3"); }
        }
        private double _judgeScore4;
        public double JudgeScore4
        {
            get { return _judgeScore4; }
            set { _judgeScore4 = value; OnPropertyChanged("JudgeScore4"); }
        }
        private double _judgeScore5;
        public double JudgeScore5
        {
            get { return _judgeScore5; }
            set { _judgeScore5 = value; OnPropertyChanged("JudgeScore5"); }
        }

        private double _averageScore;
        public double AverageScore
        {
            get { return _averageScore; }
            set { _averageScore = value; OnPropertyChanged("AverageScore"); }
        }

        private string _scoreHistory;
        public string ScoreHistory
        {
            get { return _scoreHistory; }
            set { _scoreHistory = value; OnPropertyChanged("ScoreHistory"); }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        public double CalculateAverage()
        {
            double average = 0;

            int judgesCount = 0;
            double judgesScoreSum = 0;
            //StringBuilder scoreHistorySb = new StringBuilder();
           // ScoreHistory = String.Empty;

            if (JudgeScore1 >= 5)
            {
                judgesScoreSum += JudgeScore1;
                judgesCount += 1;
                //scoreHistorySb.Append(JudgeScore1.ToString());
            }

            if (JudgeScore2 >= 5)
            {
                judgesScoreSum += JudgeScore2;
                judgesCount += 1;
                //scoreHistorySb.Append(JudgeScore2.ToString());
            }

            if (JudgeScore3 >= 5)
            {
                judgesScoreSum += JudgeScore3;
                judgesCount += 1;
                //scoreHistorySb.Append(JudgeScore3.ToString());
            }

            if (JudgeScore4 >= 5)
            {
                judgesScoreSum += JudgeScore4;
                judgesCount += 1;
                //scoreHistorySb.Append(JudgeScore4.ToString());
            }

            if (JudgeScore5 >= 5)
            {
                judgesScoreSum += JudgeScore5;
                judgesCount += 1;
               // scoreHistorySb.Append(JudgeScore5.ToString());
            }

            if (judgesCount > 0 && judgesScoreSum > 0)
            {
                average = judgesScoreSum / judgesCount;
                //ScoreHistory = scoreHistorySb.ToString();
            }



            return Math.Round(average,1);
        }
        public string GetScoreHistory()
        {
            StringBuilder sh = new StringBuilder();

            if (JudgeScore1 >= 5)
            {
                sh.Append($"+{JudgeScore1}");
            }

            if (JudgeScore2 >= 5)
            {
                sh.Append($"+{JudgeScore2}");
            }

            if (JudgeScore3 >= 5)
            {
                sh.Append($"+{JudgeScore3}");
            }

            if (JudgeScore4 >= 5)
            {
                sh.Append($"+{JudgeScore4}");
            }

            if (JudgeScore5 >= 5)
            {
                sh.Append($"+{JudgeScore5}");
            }

            return sh.ToString();
        }
    }
}
